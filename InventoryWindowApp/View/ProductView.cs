using InventoryApiClient.Model.Category;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Services;
using InventoryWindowApp.CustomStyle;
using InventoryWindowApp.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDesignDemo.View
{
    public partial class ProductView : Form
    {
        private readonly ProductService _service;

        public string DefaultImg = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTsY41l_ifhaMe423V82-fagWBkVLANTLgwoQ&usqp=CAU";

        public ProductView()
        {
            InitializeComponent();
            _service = new ProductService();
            InitLoadData();
            InitGridViewColumn();
        }

        private void btnCreatePro_Click(object sender, EventArgs e)
        {
            var formCreate = new ProductComponentView();
            formCreate.StartPosition = FormStartPosition.CenterScreen;
            AddControlls(formCreate);

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
        private void InitGridViewColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Image", 100),
                Tuple.Create("ID",320),
                Tuple.Create("Code", 120),
                Tuple.Create("Name", 240),
                Tuple.Create("Cost", 80),
                Tuple.Create("Price", 80),
                Tuple.Create("Quantity", 90),
                Tuple.Create("Category", 140),
                Tuple.Create("", 70),
                Tuple.Create("", 70),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewProduct, columns!, ClickUpdateOrDelete, 70);
        }
        private async void InitLoadData()
        {
            try
            {
                var products = await _service.ReadAllAsync();

                foreach (var product in products)
                {
                    Image Image;
                    if (product.Image == "")
                    {
                        Image = await ItemComponent.GetImageFromUrl(DefaultImg);
                    }
                    else
                    {
                        Image = await ItemComponent.GetImageFromUrl(product.Image);
                    }
                    var index = dataGridViewProduct.Rows.Add(Image, product.Id, product.Code, product.Name, product.Cost, product.Price, product.Qty??0, product.CategoryName);

                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(2, 16, 0, 16);
                    dataGridViewProduct.Rows[index].Cells[8] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(2, 16, 0, 16);
                    dataGridViewProduct.Rows[index].Cells[9] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void ClickUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columnId = dataGridViewProduct.Rows[rowIndex];
            //var product = new ProductUpdateReq();

            if (e.ColumnIndex == dataGridViewProduct.Columns[8].Index && e.RowIndex >= 0)
            {
                var product = new ProductUpdateReq()
                {
                    Image = columnId.Cells[0].Value.ToString()!,
                    Id = columnId.Cells[1].Value.ToString()!,
                    Code = columnId.Cells[2].Value.ToString()!,
                    Name = columnId.Cells[3].Value.ToString()!,
                    Cost = (decimal)columnId.Cells[4].Value,
                    Price = (decimal)columnId.Cells[5].Value,
                    CategoryId = columnId.Cells[6].Value.ToString()!,
                    Description = columnId.Cells[7].Value.ToString(),
                };
                var formCreate = new ProductComponentView(product);
                AddControlls(formCreate);
            }
            else if (e.ColumnIndex == dataGridViewProduct.Columns[9].Index && e.RowIndex >= 0)
            {
                var productName = columnId.Cells[3].Value;
                var result = MessageBox.Show($"Are you sure to delete product {productName}?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var productId = columnId.Cells[1].Value.ToString();
                    var data = await _service.DeleteAsync(productId!);
                    if (data == true)
                    {
                        CustomMessageBox.ShowMessageBox("Delete Successfully", true);
                        dataGridViewProduct.Rows.Clear();
                        InitLoadData();
                    }
                    else
                    {
                        CustomMessageBox.ShowMessageBox("Failed to Delete", false);
                    }
                }
            }
        }


    }
    public class ProductEventArgs : EventArgs
    {
        public bool IsCreate { get; }
        public object Object { get; }

        public ProductEventArgs(bool isCreate, object obj = null)
        {
            IsCreate = isCreate;
            Object = obj;
        }
    }

}
