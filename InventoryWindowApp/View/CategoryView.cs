using InventoryWindowApp.CustomStyle;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Services;

namespace POSDesignDemo.View
{
    public partial class CategoryView : Form
    {
        private readonly ProductService _service;
        private readonly CategoryService _categoryService;

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
                Tuple.Create("ID", 300),
                Tuple.Create("Name", 270),
                Tuple.Create("Description",93),
                Tuple.Create("", 80),
                Tuple.Create("", 80),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewCategory, columns!, CheckUpdateOrDelete, 55);
        }

        private void CheckUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columnId = dataGridViewCategory.Rows[rowIndex];
            var product = new ProductUpdateReq();

            if (e.ColumnIndex == dataGridViewCategory.Columns[3].Index && e.RowIndex >= 0)
            {
                product.Id = columnId.Cells[0].Value.ToString()!;
                product.Name = columnId.Cells[1].Value?.ToString()!;
                product.CategoryName = columnId.Cells[3].Value?.ToString()!;
               /* formCreateProduct formCreate = new formCreateProduct(product);
                formCreate.StartPosition = FormStartPosition.CenterScreen;
                formCreate.ShowDialog();*/
            }
            else if (e.ColumnIndex == dataGridViewCategory.Columns[6].Index && e.RowIndex >= 0)
            {
                var service = new ProductService();
                var getId = columnId.Cells[0].Value.ToString();
                var result = service.DeleteAsync(getId!);
                if(result==true)
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
                    var Image = await ItemComponent.GetImageFromUrl("https://static.vecteezy.com/system/resources/previews/000/964/198/non_2x/fast-food-meal-set-vector.jpg");
                    var index = dataGridViewCategory.Rows.Add(Image, category.Id, category.Name, "Main Category", category.Description);

                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewCategory.Rows[index].Cells[5] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewCategory.Rows[index].Cells[6] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            /*var formCreate = new FormCreateCategory();
            formCreate.StartPosition = FormStartPosition.CenterScreen;
            formCreate.ShowDialog();
            CenterPanel.BringToFront();*/
        }

    }
}
