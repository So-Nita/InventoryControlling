using InventoryWindowApp.CustomStyle;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Services;
using InventoryWindowApp.View.Component;

namespace POSDesignDemo.View
{
    public partial class CategoryView : Form
    {
        private readonly ProductService _service;
        private readonly CategoryService _categoryService;
        private readonly string DefaultImg = "https://static.vecteezy.com/system/resources/previews/000/964/198/non_2x/fast-food-meal-set-vector.jpg";
        public CategoryView()
        {
            _service = new ProductService();
            _categoryService = new CategoryService();
            InitializeComponent();
            InitLoadData();
        }
        private void InitLoadData()
        {
            InitDataGridViewColumn();
            InitDataFromApi();
        }

        private void InitDataGridViewColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Image", 150),
                Tuple.Create("ID", 350),
                Tuple.Create("Name", 220),
                Tuple.Create("Description",150),
                Tuple.Create("", 80),
                Tuple.Create("", 80),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewCategory, columns!, CheckUpdateOrDelete, 55);
        }

        private async void CheckUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columnId = dataGridViewCategory.Rows[rowIndex];
            var product = new ProductUpdateReq();

            if (e.ColumnIndex == dataGridViewCategory.Columns[3].Index && e.RowIndex >= 0)
            {
                product.Id = columnId.Cells[0].Value.ToString()!;
                product.Name = columnId.Cells[1].Value?.ToString()!;
                /* formCreateProduct formCreate = new formCreateProduct(product);
                 formCreate.StartPosition = FormStartPosition.CenterScreen;
                 formCreate.ShowDialog();*/
            }
            else if (e.ColumnIndex == dataGridViewCategory.Columns[5].Index && e.RowIndex >= 0)
            {
                var service = new CategoryService();
                var getId = columnId.Cells[0].Value.ToString();
                var result = await service.DeleteAsync(getId!);
                if (result == true)
                {
                    CustomMessageBox.ShowMessageBox("Delete Successfully", true);
                }
                else
                {
                    CustomMessageBox.ShowMessageBox("Failed to Delete", false);
                }
                //MessageBox.Show(result);
            }
        }
        private async void InitDataFromApi()
        {
            try
            {
                var categories = await _categoryService.ReadAllAsync();
                foreach (var category in categories)
                {
                    Image Image;
                    if (category.Image == "")
                    {
                        Image = await ItemComponent.GetImageFromUrl(DefaultImg);
                    }
                    else
                    {
                        Image = await ItemComponent.GetImageFromUrl(category.Image);
                    }
                    var index = dataGridViewCategory.Rows.Add(Image, category.Id, category.Name, category.Description);

                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewCategory.Rows[index].Cells[4] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewCategory.Rows[index].Cells[5] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            var formCreate = new CategoryCompnentView();
            formCreate.StartPosition = FormStartPosition.CenterScreen;
            formCreate.ShowDialog();
            CenterPanel.BringToFront();
        }

    }
}
