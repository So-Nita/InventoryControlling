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
        public ProductView()
        {
            InitializeComponent();
            _service = new ProductService();
            InitLoadData();
            InitGridViewColumn();
        }

        private void btnCreatePro_Click(object sender, EventArgs e)
        {
            AddControlls(new ProductComponentView());
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
                Tuple.Create("Image", 130),
                Tuple.Create("Code", 120),
                Tuple.Create("Name", 250),
                Tuple.Create("Price", 100),
                Tuple.Create("Quantity", 100),
                Tuple.Create("Category", 150),
                Tuple.Create("", 75),
                Tuple.Create("", 75),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewProduct, columns!, ClickUpdateOrDelete, 55);
        }
        private async void InitLoadData()
        {
            try
            {
                var products = await _service.ReadAllAsync();

                foreach (var product in products)
                {
                    var Image = await ItemComponent.GetImageFromUrl(product.Image);
                    var index = dataGridViewProduct.Rows.Add(Image, product.Code, product.Name, product.Price, product.Qty, product.CategoryName);

                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(2, 13, 0, 13);
                    dataGridViewProduct.Rows[index].Cells[6] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(2, 13, 0, 13);
                    dataGridViewProduct.Rows[index].Cells[7] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClickUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
           /* int rowIndex = e.RowIndex;
            var columnId = dataGridViewProduct.Rows[rowIndex];
            var product = new ProductUpdateReq();

            if (e.ColumnIndex == dataGridViewProduct.Columns[6].Index && e.RowIndex >= 0)
            {
                product.Id = Convert.ToInt32(columnId.Cells[1].Value);
                product.Name = columnId.Cells[2].Value?.ToString();
                product.Category = columnId.Cells[4].Value?.ToString();

                if (double.TryParse(columnId.Cells[3].Value?.ToString(), out double price))
                {
                    product.Price = price;
                }
                formCreateProduct formCreate = new formCreateProduct(product);
                formCreate.StartPosition = FormStartPosition.CenterScreen;
                formCreate.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewProduct.Columns[7].Index && e.RowIndex >= 0)
            {
                var service = new ProductController();
                var getId = columnId.Cells[1].Value;
                var result = service.DeleteProduct(Convert.ToInt32(getId));
                MessageBox.Show(result);
            }*/
        }



    }
}
