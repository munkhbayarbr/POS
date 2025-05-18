using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.RepositoryImp;
using POSUI.Helper;
namespace POSUI
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private readonly ProductRepository _productRepo;
        private readonly CategoryRepository _categoryRepo;


        private List<Product> _allProducts = new();
        private List<Category> _allCategories = new();
        private int _selectedCategoryId = -1;

        private List<CartItem> _cartItems = new();
        private decimal _totalAmount = 0;

        public MainForm(User user)
        {
            InitializeComponent();

            _currentUser = user;
            if (_currentUser.Role != "Manager")
            {
                ProductBtn.Visible = false;
                CategoryBtn.Visible = false;
                HelperBtn.Visible = false;
            }
            _productRepo = new ProductRepository();
            _categoryRepo = new CategoryRepository();

            timer.Tick += timer_run;
            timer.Start();

            LoadCategories();
            ProductFilter(-1);

        }

        private void timer_run(object sender, EventArgs e)
        {
            timeArea.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void LoadCategories()
        {

            _allCategories = _categoryRepo.GetCategories().ToList();
            flowCategories.Controls.Clear();


            flowCategories.Controls.Add(CreateCategoryCard("All", -1));

            foreach (var cat in _allCategories)
                flowCategories.Controls.Add(CreateCategoryCard(cat.Name, cat.Id));

            HighlightSelectedCategory();
        }

        private Panel CreateCategoryCard(string text, int id)
        {
            var card = new Panel
            {
                Tag = id,
                Width = 100,
                Height = 60,
                Margin = new Padding(5),
                BackColor = Color.Green,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };
            var lbl = new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.White
            };
            card.Controls.Add(lbl);

            card.Click += (s, e) => ProductFilter((int)card.Tag);
            lbl.Click += (s, e) => ProductFilter((int)card.Tag);

            return card;
        }

        private void HighlightSelectedCategory()
        {
            foreach (Panel p in flowCategories.Controls.OfType<Panel>())
                p.BackColor = ((int)p.Tag == _selectedCategoryId)
                              ? Color.DarkGreen
                              : Color.Green;
        }

        private void ProductFilter(int filter)
        {
            _selectedCategoryId = filter;


            _allProducts = _productRepo.GetProducts().ToList();

            if (filter >= 0)
                LoadProducts(_allProducts.Where(p => p.CategoryId == filter).ToList());
            else
                LoadProducts(_allProducts);

            HighlightSelectedCategory();
        }

        private void LoadProducts(List<Product> productList)
        {
            flowProducts.Controls.Clear();

            foreach (var prod in productList)
            {
                var card = new Panel
                {
                    Tag = prod,
                    Width = 120,
                    Height = 140,
                    Margin = new Padding(5),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand
                };

                var pic = new PictureBox
                {
                    Image = ImageHelper.ByteArrayToImage(prod.ImageData),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 80
                };

                var lbl = new Label
                {
                    Text = $"{prod.Name}\n${prod.Price:F2}\n{prod.Code}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular)
                };

                card.Controls.Add(lbl);
                card.Controls.Add(pic);

                card.Click += (s, e) => AddToCart(prod);
                pic.Click += (s, e) => AddToCart(prod);
                lbl.Click += (s, e) => AddToCart(prod);

                flowProducts.Controls.Add(card);
            }
        }


        private void AddToCart(Product prod)
        {
            // check if product is already in cart
            var existing = _cartItems.FirstOrDefault(c => c.Product.Id == prod.Id);

            if (existing != null)
            {
                existing.Quantity++;

                // ✅ find corresponding control and update it
                foreach (CartItemControl ctrl in flowCartPanel.Controls)
                {
                    if (ctrl.GetItem().Product.Id == prod.Id)
                    {
                        ctrl.RefreshUI(); // a method you'll define in the control
                        break;
                    }
                }
            }
            else
            {
                // ✅ create CartItem and CartItemControl
                var newItem = new CartItem { Product = prod, Quantity = 1 };
                _cartItems.Add(newItem);

                var cartCtrl = new CartItemControl(newItem);
                cartCtrl.OnQuantityChanged += CartItemChanged;
                flowCartPanel.Controls.Add(cartCtrl);
            }

            UpdateTotal();
        }

        private void CartItemChanged(CartItem updatedItem)
        {
            _cartItems = flowCartPanel.Controls
                         .OfType<CartItemControl>()
                         .Select(c => c.GetItem())
                         .Where(i => i.Quantity > 0)
                         .ToList();

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            _totalAmount = _cartItems.Sum(i => i.Total);
            lblTotalAmount.Text = $"Нийт: ₮ {_totalAmount:F0}";
        }



        private void ShowProfile(object sender, EventArgs e)
        {
            Hide();
            using var profile = new Profile(_currentUser);
            profile.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void ProductBtn_Click(object sender, EventArgs e)
        {
            using var form = new ManageForm("Product");
            form.ShowDialog();
            LoadCategories();
            ProductFilter(_selectedCategoryId);
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            using var form = new ManageForm("Category");
            form.ShowDialog();
            LoadCategories();
            ProductFilter(_selectedCategoryId);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
