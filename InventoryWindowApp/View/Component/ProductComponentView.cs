using InventoryApiClient.Model.Category;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Services;
using InventoryWindowApp.CustomStyle;
using POSDesignDemo.View;
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
    public partial class ProductComponentView : Form
    {
        private readonly ProductService _service;
        private readonly CategoryService _category = new();
        private readonly ProductUpdateReq _product;
        public ProductComponentView(ProductUpdateReq product = null!)
        {
            InitializeComponent();
            _service = new ProductService();
            _product = product;
            InitData();
            if (product != null) { PopulateFormForUpdate(); }
        }

        private void InitData()
        {
            InitListCategory();
            _ = _product == null ? labelTitle.Text = "Create New Product" : labelTitle.Text = "Update Product";
        }
        private async void InitListCategory()
        {
            try
            {
                var categories = await _category.ReadAllAsync();
                if (categories != null)
                {
                    foreach (var item in categories)
                    {
                        comboCategory.Items.Add(item.Name);
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        private async void PopulateFormForUpdate()
        {
            //var product = _service.Read(_product.Id);
            txtName.Text = _product.Name;
            txtCode.Text = _product.Code;
            txtCode.Text = _product.Name;
            txtCost.Text = _product.Cost.ToString();
            txtPrice.Text = _product.Price.ToString();
            txtImage.Text = _product.Image;
            txtDescription.Text = _product.Description;
            comboCategory.SelectedValue = _product.CategoryId;
        }
        public void AddControlls(Form form)
        {
            if (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }
            this.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            CreateOrUpdate();
        }
        private async void CreateOrUpdate()
        {
            if (_product == null)
            {
                Create();
            }
            else
            {
                var category = new CategoryService();
                var categoryId = category.ReadAllAsync().Result.FirstOrDefault(e => e.Name == _product.CategoryId);
                var updateReq = new ProductUpdateReq()
                {
                    Id = _product.Id,
                    CategoryId = categoryId.Id,
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    Cost = Convert.ToDecimal(txtCost.Text),
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Image = _product.Image,
                    Description = txtDescription.Text,
                };
                var update = await _service.UpdateAsync(updateReq);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddControlls(new ProductView());
        }
        private async void Create()
        {
            var data = await _category.ReadAllAsync();
            var category = data.FirstOrDefault(e => e.Name.Equals(comboCategory.SelectedItem.ToString()));
            var createReq = new ProductCreateReq()
            {
                Code = txtCost.Text,
                Name = txtCode.Text,
                Cost = decimal.TryParse(txtCost.Text, out decimal costValue) ? costValue : 0m,
                Price = decimal.TryParse(txtPrice.Text, out decimal priceValue) ? priceValue : 0m,
                CategoryId = category!.Id,
                Description = txtDescription.Text,
                Image = txtImage.Text
            };
            var create = await _service.CreateAsync(createReq);
            if (create.Status == 200)
            {
                CustomMessageBox.ShowMessageBox("Create Product Successfully", true);
                AddControlls(new ProductView());
            }
            else
            {
                CustomMessageBox.ShowMessageBox(create.Result.ToString()!, false);
            }
        }
    }
}
