using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLibrary.Models;
using PosLibrary.Repositories.RepositoryImp;
using PosLibrary.Models;
namespace POSUI
{
    public partial class ManageForm : Form
    {
        private readonly string _mode; // "Product" or "Category"

        public ManageForm(string mode)
        {
            InitializeComponent();
            _mode = mode;
            btnSave.Click += btnSave_Click;
            //btnEdit.Click += btnEdit_Click;
            //btnDelete.Click += btnDelete_Click;
            if (_mode == "Product")
            {
                LoadProductUI();
                LoadProductGrid();
            }
            else
            {
                LoadCategoryUI();
                LoadCategoryGrid();
            }
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            if (_mode == "Product")
            {
                LoadProductUI();
                LoadProductGrid();
            }
            else
            {
                LoadCategoryUI();
                LoadCategoryGrid();
            }

        }
        private void LoadProductGrid()
        {
            var repo = new ProductRepository();
            var products = repo.GetProducts();

            dataGridList.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Code,
                p.Price,
                p.Stock
            }).ToList();
        }

        private void LoadCategoryGrid()
        {
            var repo = new CategoryRepository();
            var categories = repo.GetCategories();

            dataGridList.DataSource = categories.Select(c => new
            {
                c.Id,
                c.Name
            }).ToList();
        }

        private void LoadCategoryUI()
        {
            pnlDynamic.Controls.Clear();

            var lblName = new Label { Text = "Category Name:", Top = 10, Left = 10 };
            var txtCatName = new TextBox { Name = "txtCategoryName", Top = 10, Left = 120 };

            pnlDynamic.Controls.Add(lblName);
            pnlDynamic.Controls.Add(txtCatName);
        }
        private void LoadProductUI()
        {
           pnlDynamic.Controls.Clear();

            // Name
            var lblName = new Label { Text = "Name:", Top = 10, Left = 10 };
            var txtName = new TextBox { Name = "txtName", Top = 10, Left = 100 };

            // Barcode
            var lblBarcode = new Label { Text = "Barcode:", Top = 40, Left = 10 };
            var txtBarcode = new TextBox { Name = "txtBarcode", Top = 40, Left = 100 };

            // Price
            var lblPrice = new Label { Text = "Price:", Top = 70, Left = 10 };
            var txtPrice = new TextBox { Name = "txtPrice", Top = 70, Left = 100 };

            // Stock
            var lblStock = new Label { Text = "Stock:", Top = 100, Left = 10 };
            var txtStock = new TextBox { Name = "txtStock", Top = 100, Left = 100 };

            // Image picker
            var picImage = new PictureBox
            {
                Name = "picImage",
                Top = 130,
                Left = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                Width = 120,
                Height = 80
            };
            var btnChooseImage = new Button
            {
                Text = "Choose Image",
                Top = 130,
                Left = 230
            };
            btnChooseImage.Click += (s, e) =>
            {
                using var ofd = new OpenFileDialog { Filter = "Images|*.png;*.jpg" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                    picImage.Tag = ofd.FileName; // store path
                }
            };

            pnlDynamic.Controls.AddRange(new Control[]
            {
        lblName, txtName, lblBarcode, txtBarcode,
        lblPrice, txtPrice, lblStock, txtStock,
        picImage, btnChooseImage
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == "Product")
            {
                var name = pnlDynamic.Controls["txtName"]?.Text;
                var barcode = pnlDynamic.Controls["txtBarcode"]?.Text;
                var price = Convert.ToDecimal(pnlDynamic.Controls["txtPrice"]?.Text);
                var stock = Convert.ToInt32(pnlDynamic.Controls["txtStock"]?.Text);
                var imgControl = pnlDynamic.Controls["picImage"] as PictureBox;

                byte[]? imgData = null;
                if (imgControl?.Image != null)
                {
                    imgData = Helper.ImageHelper.ImageToByteArray(imgControl.Image);
                }

                var repo = new ProductRepository();
                var result = repo.AddProduct(new Product
                {
                    Name = name,
                    Code = barcode,
                    Price = price,
                    Stock = stock,
                    ImageData = imgData,
                    CategoryId = 1 // hardcoded for now, you can add dropdown later
                });

                MessageBox.Show(result);
            }
            else if (_mode == "Category")
            {
                var name = pnlDynamic.Controls["txtCategoryName"]?.Text;
                var repo = new CategoryRepository();
                var result = repo.AddCategory(new Category { Name = name });

                MessageBox.Show(result);
            }
        }


    }

}
