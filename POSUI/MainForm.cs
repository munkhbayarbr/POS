using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PosLibrary.Models;
using PosLibrary.Repositories;

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

        public MainForm(User user)
        {
            InitializeComponent();

            _currentUser = user;
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
                    Image = Image.FromFile(@"C:\Users\muba\Desktop\RESULT\POSUI\shop.png"),
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

                flowProducts.Controls.Add(card);
            }
        }

        private void AddToCart(Product prod)
        {

        }

        private void ShowProfile(object sender, EventArgs e)
        {
            Hide();
            using var profile = new Profile(_currentUser);
            profile.ShowDialog();
            Show();
        }
    }
}
