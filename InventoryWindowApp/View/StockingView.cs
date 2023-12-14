using InventoryApiClient.Model.Stocking;
using InventoryApiClient.Services;
using InventoryWindowApp.CustomStyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWindowApp.View.Component
{
    public partial class StockingView : Form
    {
        private readonly StockingService _service;

        public StockingView()
        {
            InitializeComponent();
            _service = new StockingService();
            InitGridViewColumn();
            InitLoadData();
        }


        private void InitGridViewColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("ID",200),
                Tuple.Create("Quantity", 300),
                Tuple.Create("Name", 230),
                Tuple.Create("Quantity", 80),
                Tuple.Create("Status", 120),
                Tuple.Create("Note", 150),
                Tuple.Create("", 70),
                Tuple.Create("", 70),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewStock, columns!, ClickUpdateOrDelete, 65);
        }


        private async void InitLoadData()
        {
            try
            {
                var stocks = await _service.ReadAllAsync();
                if (stocks.Any())
                {
                    foreach (var stock in stocks)
                    {

                        var index = dataGridViewStock.Rows.Add(stock.TransactionDate, stock.Id,stock.ProductName, stock.Qty, stock.Status, stock.Note);

                        DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                        btnUpdate.Style.Padding = new Padding(2, 18, 0, 18);
                        dataGridViewStock.Rows[index].Cells[6] = btnUpdate;

                        DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                        btnDelete.Style.Padding = new Padding(2, 18, 0, 18);
                        dataGridViewStock.Rows[index].Cells[7] = btnDelete;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddControlls(Form form)
        {
            if (productCenterPanel.Controls.Count > 0)
            {
                productCenterPanel.Controls.RemoveAt(0);
            }
            productCenterPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            productCenterPanel.Controls.Add(form);
            form.Show();
        }
        private async void ClickUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columnId = dataGridViewStock.Rows[rowIndex];

            if (e.ColumnIndex == dataGridViewStock.Columns[6].Index && e.RowIndex >= 0)
            {
                var stock = new StockUpdateReq()
                {
                    Id = columnId.Cells[1].Value.ToString()!,
                    
                    Qty = Convert.ToInt32(columnId.Cells[3].Value ?? 0),
                    Status = columnId.Cells[4].Value.ToString()!,
                    Note = columnId.Cells[5].Value.ToString()!,
                };
                var formCreate = new StockComonentView(stock);
                AddControlls(formCreate);
            }
            else if (e.ColumnIndex == dataGridViewStock.Columns[7].Index && e.RowIndex >= 0)
            {
                var productName = columnId.Cells[3].Value;
                var result = MessageBox.Show($"Are you sure to delete product {productName}?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var id = columnId.Cells[0].Value.ToString();
                    var data = await _service.DeleteAsync(id!);
                    if (data == true)
                    {
                        CustomMessageBox.ShowMessageBox("Delete Successfully", true);
                        dataGridViewStock.Rows.Clear();
                        InitLoadData();
                    }
                    else
                    {
                        CustomMessageBox.ShowMessageBox("Failed to Delete", false);
                    }
                }
            }
        }

        private void btnCreateStock_Click(object sender, EventArgs e)
        {
            AddControlls(new StockComonentView());
        }
    }
}
