using InventoryApiClient.Model.Category;
using InventoryApiClient.Model.Order;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Services;
using InventoryWindowApp.Constant;
using InventoryWindowApp.CustomStyle;
using System.Data;
using Image = System.Drawing.Image;


namespace InventoryWindowApp.View
{
    public partial class HomeView : Form
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly CategoryService _categoryService;
        private readonly string DefaultImg = "https://cdn.spinn.com/assets/img/empty.jpeg";
        private List<ProductResponse> Carts { get; set; } = new List<ProductResponse>();

        public HomeView()
        {
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _orderService = new OrderService();
            InitializeComponent();

            if (panelMenuCategory != null)
            {
                touchScroll = new CustomTouchScroll(panelMenuCategory, ConstantScrollDirection.Horizontal);
                touchScrollProduct = new CustomTouchScroll(productPanel, ConstantScrollDirection.Vertical);
                touchScrollProductCart = new CustomTouchScroll(productPanel, ConstantScrollDirection.Vertical);
            }
            InitializeFlowLayoutPanel();
        }
        private void InitializeFlowLayoutPanel()
        {
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanelProducts);
            InitProductsFromApiAsync();
            InitBtnAllCategory();
            InitBtnCategory();
            InitButtonColumn();
        }

        private async void InitBtnCategory()
        {
            try
            {
                var categories = await _categoryService.ReadAllAsync();
                if (categories.Count > 0)
                {
                    for (int i = 0; i < categories.Count; i++)
                    {
                        CreateButtonCategory(categories[i]);
                    }
                }
            }
            catch { throw new Exception(); }
        }

        private async void InitProductsFromApiAsync()
        {
            var Test = new List<string>();
            try
            {
                var products = await _productService.ReadProductSellAsync();
                if (products.Any())
                {
                    foreach (var product in products)
                    {
                        CreateProductPanel(product);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }
        private void InitButtonColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Image", 50),
                Tuple.Create("Name", 90),
                Tuple.Create("Price", 35),
                Tuple.Create("Qty", 34),
                Tuple.Create("Total", 35),
                Tuple.Create("", 33)
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewProduct, columns!, BtnSubstract_Click, 50);
        }

        private void InitBtnAllCategory()
        {
            Button btnAllCategory = new Button();
            btnAllCategory.ForeColor = Color.DarkGray;
            btnAllCategory.Text = "All Category";
            btnAllCategory.FlatAppearance.BorderColor = Color.White;
            btnAllCategory.FlatAppearance.CheckedBackColor = Color.AliceBlue;
            btnAllCategory.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAllCategory.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllCategory.FlatStyle = FlatStyle.Flat;
            btnAllCategory.FlatAppearance.BorderSize = 0;
            btnAllCategory.Cursor = Cursors.Hand;
            btnAllCategory.Location = new Point(YOffSet, 7);
            btnAllCategory.Size = new Size(115, 40);
            btnAllCategory.BackColor = Color.White;
            btnAllCategory.Click += BtnAllCategory_Click!;

            panelMenuCategory.Controls.Add(btnAllCategory);
            // Active Button AllCategory
            lastClickedButton = btnAllCategory;
            YOffSet += 120;
        }
        // Create Button Category
        private void CreateButtonCategory(CategoryResponse category)
        {
            try
            {
                var btnCategory = new Button();
                btnCategory.ForeColor = Color.DarkGray;
                btnCategory.Text = category.Name;
                btnCategory.FlatAppearance.MouseOverBackColor = Color.LightGray;
                btnCategory.FlatStyle = FlatStyle.Flat;
                btnCategory.FlatAppearance.BorderSize = 0;

                btnCategory.Cursor = Cursors.Hand;
                //btnCategory.Location = new Point(YOffSet, 0);
                btnCategory.Location = new Point(YOffSet, 7);
                btnCategory.Size = new Size(120, 40);
                //
                btnCategory.BackColor = Color.White;
                btnAllCategory.Click += GetProductByCategory;
                btnCategory.Click += (sender, e) => GetProductByCategory(category);
                panelMenuCategory.Controls.Add(btnCategory);
                YOffSet += 120;
                touchScroll.AssignScrollEvent(btnCategory);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        private void GetProductByCategory(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is CategoryResponse category)
            {
                GetProductByCategory(category);
            }
        }

        private Button lastClickedButton;

        private void CategoryActiveButton(Button button, Color backgroundColor, Color textColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = textColor;
        }
        private async void GetProductByCategory(CategoryResponse category)
        {
            try
            {
                var products = new List<ProductResponse>();
                productPanel.Controls.Clear();
                if (lastClickedButton != null)
                {
                    CategoryActiveButton(lastClickedButton, Color.White, Color.DarkGray);
                }
                if (category.Id.ToString() != null)
                {
                    products = await _productService.GetProductByCategory(category.Id);
                }
                foreach (var item in products)
                {
                    CreateProductPanel(item);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        // Button All Category
        private void BtnAllCategory_Click(object sender, EventArgs e)
        {
            productPanel.Controls.Clear();
            if (lastClickedButton != null)
            {
                CategoryActiveButton(lastClickedButton, Color.White, Color.DarkGray);
            }
            InitProductsFromApiAsync();
        }
        // Button Action to Substract Qty
        private void BtnSubstract_Click(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProduct.Columns[""].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                if (index < Carts.Count)
                {
                    SubstractItem(index);
                }
                UpdateTotalPrice();
            }
        }
        // Substract Method 
        private void SubstractItem(int index)
        {
            if (Carts[index].Qty == 1)
            {
                Carts.Remove(Carts[index]);
                dataGridViewProduct.Rows.RemoveAt(index);
            }
            else
            {
                Carts[index].Qty -= 1;
                dataGridViewProduct.Rows[index].Cells[3].Value = Carts[index].Qty;
                double totalProductPrice = (double)(Carts[index].Price * Carts[index].Qty)!;
                dataGridViewProduct.Rows[index].Cells[4].Value = totalProductPrice;
            }
        }
        // Sum Price Method
        private void UpdateTotalPrice()
        {
            double totalPrice = 0.00;
            foreach (var product in Carts)
            {
                totalPrice += (double)(product.Price * product.Qty)!;
            }
            textTotalPrice.Text = "$ " + totalPrice.ToString("0.00");
        }
        private List<string> image = new List<string>();

        // Create Panel for each product
        private async void CreateProductPanel(ProductResponse product)
        {
            try
            {
                image.Add(product.Image);
                Panel btnProduct = new Panel();
                btnProduct.Size = new Size(190, 200);

                Panel imagePanel = new Panel();
                imagePanel.Size = new Size(200, 200);
                imagePanel.Location = new Point(0, 0);
                imagePanel.Dock = DockStyle.Top;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200, 155);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                Label nameLabel = new Label();
                nameLabel.Text = "Name: " + product.Name;
                nameLabel.BackColor = Color.White;
                nameLabel.Dock = DockStyle.Bottom;

                Label priceLabel = new Label();
                priceLabel.Text = "Price: " + product.Price;
                priceLabel.BackColor = Color.White;
                priceLabel.Dock = DockStyle.Bottom;

                btnProduct.Controls.Add(imagePanel);
                Image Image ;
                if(product.Image == null || product.Image=="")
                {
                    Image = await ItemComponent.GetImageFromUrl(DefaultImg);
                    product.Image = DefaultImg;
                }
                else
                {
                    Image = await ItemComponent.GetImageFromUrl(product.Image!);
                }
                pictureBox.Image = Image;
                imagePanel.Controls.Add(pictureBox);

                int topPosition = flowLayoutPanelProducts.Controls.Count * 260;
                btnProduct.Location = new Point(0, topPosition);
                imagePanel.Tag = product;
                pictureBox.Click += (sender, e) => AddProductCartToRow(product);
                //imagePanel.Click += CreateNewRowClick;
                imagePanel.Controls.Add(nameLabel);
                imagePanel.Controls.Add(priceLabel);
                btnProduct.Controls.Add(imagePanel);
                btnProduct.BackgroundImageLayout = ImageLayout.Center;
                flowLayoutPanelProducts.Controls.Add(btnProduct);
                productPanel.Controls.Add(btnProduct);
                //For Content Touc Scroll
                touchScrollProduct.AssignScrollEvent(btnProduct);
            }
            catch (Exception ex)
            {
                var t = image;
                throw new Exception(ex.Message + "\n" + ex.StackTrace);
            }

        }

        private async void AddProductCartToRow(ProductResponse product)
        {
            var checkProExist = Carts.FirstOrDefault(p => p.Id == product.Id);

            if (checkProExist == null)
            {
                Carts.Insert(0, product);
                //Carts.Add(product);
                product.Qty = 1;
                dataGridViewProduct.Rows.Clear();
                //dataGridViewProduct.Rows.Insert(0, product);
                foreach (var item in Carts)
                {
                    double totalProductPrice = (double)(item.Price * item.Qty)!;
                    var image = await ItemComponent.GetImageFromUrl(item.Image);
                    var index = dataGridViewProduct.Rows.Add(image, item.Name, item.Price, item.Qty, totalProductPrice);

                    DataGridViewButtonCell buttonSubtract = ItemComponent.CreateButtonSubstract("-");
                    buttonSubtract.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewProduct.Rows[index].Cells[5] = buttonSubtract;
                }
            }
            else
            {
                checkProExist.Qty++;
                int rowIndex = dataGridViewProduct.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[1].Value.ToString() == checkProExist.Name)
                    .Select(r => r.Index)
                    .FirstOrDefault();

                dataGridViewProduct.Rows[rowIndex].Cells[3].Value = checkProExist.Qty;

                double totalProductPrice = (double)(checkProExist.Price * checkProExist.Qty)!;
                dataGridViewProduct.Rows[rowIndex].Cells[4].Value = totalProductPrice;
            }
            //touchScrollProductCart.AssignScrollEvent(dataGridViewProduct);
            UpdateTotalPrice();
        }
        // Button To Clear All 
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            Carts.Clear();
            dataGridViewProduct.Rows.Clear();
            UpdateTotalPrice();
        }
        // Button Click Pay
        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetails = new List<OrderDetail>();
                foreach (var item in Carts)
                {
                    var orderDetail = new OrderDetail()
                    {
                        ProductId = item.Id,
                        Qty = (int)item.Qty 
                    };
                    orderDetails.Add(orderDetail);
                }
                if (orderDetails.Count <= 0)
                {
                    CustomMessageBox.ShowMessageBox("Payment failed. Please select the product", false);
                }
                else
                {
                    var data = new OrderCreateReq()
                    {
                        OrderDetails =  orderDetails,
                    };

                    var result = await _orderService.Create(data);
                    if (result != true)
                    {
                        CustomMessageBox.ShowMessageBox("Payment failed. Please try again!", false);
                    }
                    else
                    {
                        Carts.Clear();
                        UpdateTotalPrice();
                        dataGridViewProduct.Rows.Clear();
                        CustomMessageBox.ShowMessageBox("Payment successful!", true);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }
        // Create Panel For Cart 
        private void CheckExistOrNewProduct(ProductResponse product)
        {
            var productExist = Carts.FirstOrDefault(e => e.Id == product.Id);

            if (productExist == null)
            {
                DefaultQty = 1;
                CreatePanelProductAddToCart(product);
            }
            else
            {
                var productsPanel = panelMainCart.Controls.OfType<FlowLayoutPanel>()
                                .FirstOrDefault(panel => panel.Tag is ProductResponse && ((ProductResponse)panel.Tag).Id == productExist!.Id);
                DefaultQty += 1;
                productExist!.Qty = DefaultQty;
                BtnSubstractProduct_Click(productExist);
                CreatePanelProductAddToCart(productExist);
            }
            UpdateTotalPrice();
        }

        private int DefaultQty = 1;


        private async void CreatePanelProductAddToCart(ProductResponse product)
        {
            FlowLayoutPanel panelProductCart = new FlowLayoutPanel();
            panelProductCart.Size = new Size(345, 60);
            panelProductCart.Padding = new Padding(2, 5, 2, 5);
            panelProductCart.BorderStyle = BorderStyle.None;
            // Panel for product image
            Panel panelProCartImage = CreateSubPanel(new Size(50, 52));
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (!string.IsNullOrEmpty(product.Image))
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(product.Image);
                    var stream = new MemoryStream(imageBytes);
                    pictureBox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                pictureBox.Image = null;
            }
            panelProCartImage.Controls.Add(pictureBox);
            // Panel for product name
            Panel panelProName = CreateSubPanel(new Size(120, 52));
            Label nameLabel = new Label();
            nameLabel.Text = product.Name;
            panelProName.Controls.Add(nameLabel);

            // Panel for product price
            Panel panelProPrice = CreateSubPanel(new Size(40, 52));
            Label priceLabel = new Label();
            priceLabel.Text = product.Price.ToString();
            priceLabel.Dock = DockStyle.Fill;
            panelProPrice.Controls.Add(priceLabel);

            // Panel for product quantity
            Panel panelProQty = CreateSubPanel(new Size(20, 52));
            Label qtyLabel = new Label();
            qtyLabel.Name = "lblQty";
            qtyLabel.Text = DefaultQty.ToString();
            panelProQty.Controls.Add(qtyLabel);
            product.Qty = DefaultQty;

            // Panel for product total
            Panel panelProTotal = CreateSubPanel(new Size(45, 52));
            Label totalLabel = new Label();
            totalLabel.Text = (product.Price * 1).ToString();
            totalLabel.Name = "lblTotalPrice";
            panelProTotal.Controls.Add(totalLabel);
            // Panel for subtract button
            Button btnSubtract = new Button();
            btnSubtract.FlatStyle = FlatStyle.Standard;
            btnSubtract.FlatAppearance.BorderColor = Color.LightGray;
            btnSubtract.Text = "-";
            btnSubtract.Click += (sender, e) => BtnSubstractProduct_Click(product);
            Panel panelProBtnSubSt = CreateSubPanel(new Size(30, 40));
            panelProBtnSubSt.Padding = new Padding(0, 12, 0, 0);
            panelProBtnSubSt.Controls.Add(btnSubtract);
            // Add sub-panels to the main panel for the product in the cart
            panelProductCart.Controls.Add(panelProCartImage);
            panelProductCart.Controls.Add(panelProName);
            panelProductCart.Controls.Add(panelProPrice);
            panelProductCart.Controls.Add(panelProQty);
            panelProductCart.Controls.Add(panelProTotal);
            panelProductCart.Controls.Add(panelProBtnSubSt);

            // Set dynamic X positions
            int currentX = 0;
            foreach (Control subPanel in panelProductCart.Controls)
            {
                subPanel.Location = new Point(currentX, 0);
                currentX += subPanel.Width;
                foreach (Control contentControl in subPanel.Controls)
                {
                    if (contentControl is Label)
                    {
                        ((Label)contentControl).Dock = DockStyle.Fill;
                        ((Label)contentControl).TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else if (contentControl is Button)
                    {
                        ((Button)contentControl).Dock = DockStyle.Fill;
                        ((Button)contentControl).TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
            panelProductCart.Tag = product;
            // Add the product panel to the main cart panel
            int topPosition = panelMainCart.Controls.Count * panelProductCart.Height;
            //int topPosition = Carts.Count * panelProductCart.Height;
            panelProductCart.Location = new Point(0, topPosition);
            panelMainCart.Controls.Add(panelProductCart);
            //touchScrollProductCart.AssignScrollEvent(panelProductCart);
            Carts.Add(product);
        }

        private void BtnSubstractProduct_Click(ProductResponse product)
        {
            var productPanel = panelMainCart.Controls.OfType<FlowLayoutPanel>()
                               .FirstOrDefault(panel => panel.Tag is ProductResponse && ((ProductResponse)panel.Tag).Id == product.Id);
            if (productPanel != null)
            {
                panelMainCart.Controls.Remove(productPanel);
            }
            var Test = Carts.FirstOrDefault(e => e.Id == product.Id)!;
            Carts.Remove(Test);
            UpdateTotalPrice();
        }

        private Panel CreateSubPanel(Size size)
        {
            Panel panel = new Panel();
            panel.Size = size;
            return panel;
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panelMainCart_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panelMenuCategory_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textTotalPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextPrice_Click(object sender, EventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnAllCatgory_Click(object sender, EventArgs e)
        {
        }

        private void panelCategory_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtCatgoryName_Click(object sender, EventArgs e)
        {
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {

        }
    }
}
