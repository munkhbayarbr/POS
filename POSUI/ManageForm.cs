using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.RepositoryImp;

namespace POSUI
{
    public partial class ManageForm : Form
    {
        private readonly string _mode; // "Product" || "Category"
        private int? _editId = null;
        private bool _isEditMode = false;
        private readonly Context _context;
        public ManageForm(string mode, Context context)
        {
            InitializeComponent();
            _context = context;
            _mode = mode;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;

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
            var productRepo = new ProductRepository(_context);
            var categoryRepo = new CategoryRepository(_context);

            var categories = categoryRepo.GetCategories();

            var products = productRepo.GetProducts();

            dataGridList.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Code,
                p.Price,
                p.Stock,
                Category = categories.FirstOrDefault(c => c.Id == p.CategoryId)?.Name ?? "Unknown",
                Image = p.ImageData != null
                    ? Helper.ImageHelper.ByteArrayToImage(p.ImageData)
                    : null
            }).ToList();

            dataGridList.RowTemplate.Height = 60;
            dataGridList.Columns["Image"].DefaultCellStyle.NullValue = null;
            ((DataGridViewImageColumn)dataGridList.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        private void LoadCategoryGrid()
        {
            var repo = new CategoryRepository(_context);
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
            var txtCatName = new TextBox { Name = "txtCategoryName", Top = 10, Left = 150 };

            pnlDynamic.Controls.Add(lblName);
            pnlDynamic.Controls.Add(txtCatName);
        }
        private void LoadProductUI()
        {
            pnlDynamic.Controls.Clear();

            // Name
            var lblName = new Label { Text = "Name:", Top = 10, Left = 10 };
            var txtName = new TextBox { Name = "txtName", Top = 10, Left = 150 };

            // Barcode
            var lblBarcode = new Label { Text = "Barcode:", Top = 40, Left = 10 };
            var txtBarcode = new TextBox { Name = "txtBarcode", Top = 40, Left = 150 };

            // Price
            var lblPrice = new Label { Text = "Price:", Top = 70, Left = 10 };
            var txtPrice = new TextBox { Name = "txtPrice", Top = 70, Left = 150 };

            // Stock
            var lblStock = new Label { Text = "Stock:", Top = 100, Left = 10 };
            var txtStock = new TextBox { Name = "txtStock", Top = 100, Left = 150 };

            // Category
            var lblCategory = new Label { Text = "Category:", Top = 130, Left = 10 };
            var cmbCategory = new ComboBox
            {
                Name = "cmbCategory",
                Top = 130,
                Left = 150,
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            var catRepo = new CategoryRepository(_context);
            var categories = catRepo.GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            // Image 
            var picImage = new PictureBox
            {
                Name = "picImage",
                Top = 170,
                Left = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                Width = 120,
                Height = 80
            };
            var btnChooseImage = new Button
            {
                Text = "Choose Image",
                Top = 170,
                Left = 230
            };
            btnChooseImage.Click += (s, e) =>
            {
                using var ofd = new OpenFileDialog { Filter = "Images|*.png;*.jpg" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                    picImage.Tag = ofd.FileName; 
                }
            };

            pnlDynamic.Controls.AddRange(new Control[]
            {
        lblName, txtName, lblBarcode, txtBarcode,
        lblPrice, txtPrice, lblStock, txtStock,
          lblCategory, cmbCategory,
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
                var cmbCategory = pnlDynamic.Controls["cmbCategory"] as ComboBox;
                int selectedCategoryId = (int)cmbCategory.SelectedValue;
                byte[]? imgData = null;
                if (imgControl?.Image != null)
                {
                    imgData = Helper.ImageHelper.ImageToByteArray(imgControl.Image);
                }

                var repo = new ProductRepository(_context);

                string result;
                if (_isEditMode && _editId.HasValue)
                {
                    result = repo.UpdateProduct(new Product
                    {
                        Id = _editId.Value,
                        Name = name,
                        Code = barcode,
                        Price = price,
                        Stock = stock,
                        ImageData = imgData,
                        CategoryId = selectedCategoryId
                    });
                }
                else
                {
                    result = repo.AddProduct(new Product
                    {
                        Name = name,
                        Code = barcode,
                        Price = price,
                        Stock = stock,
                        ImageData = imgData,
                        CategoryId = selectedCategoryId
                    });
                }

                MessageBox.Show(result);
                LoadProductGrid();
                foreach (Control ctrl in pnlDynamic.Controls)
                {
                    if (ctrl is TextBox tb) tb.Text = "";
                    if (ctrl is ComboBox cb) cb.SelectedIndex = 0;
                    if (ctrl is PictureBox pb) pb.Image = null;
                }

            }
            else // Category
            {
                var name = pnlDynamic.Controls["txtCategoryName"]?.Text;
                var repo = new CategoryRepository(_context);

                string result;
                if (_isEditMode && _editId.HasValue)
                {
                    result = repo.UpdateCategory(new Category
                    {
                        Id = _editId.Value,
                        Name = name
                    });
                }
                else
                {
                    result = repo.AddCategory(new Category { Name = name });
                }

                MessageBox.Show(result);
                LoadCategoryGrid();
            }

            
            _editId = null;
            _isEditMode = false;

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Засварлах мөрийг сонгоно уу.");
                return;
            }

            _editId = Convert.ToInt32(dataGridList.SelectedRows[0].Cells["Id"].Value);
            _isEditMode = true;

            if (_mode == "Product")
            {
                var repo = new ProductRepository(_context);
                var product = repo.GetProductById(_editId.Value);
                if (product == null) return;

                pnlDynamic.Controls["txtName"].Text = product.Name;
                pnlDynamic.Controls["txtBarcode"].Text = product.Code;
                pnlDynamic.Controls["txtPrice"].Text = product.Price.ToString();
                pnlDynamic.Controls["txtStock"].Text = product.Stock.ToString();

                var picImage = pnlDynamic.Controls["picImage"] as PictureBox;
                picImage.Image = product.ImageData != null
                    ? Helper.ImageHelper.ByteArrayToImage(product.ImageData)
                    : null;
                var cmbCategory = pnlDynamic.Controls["cmbCategory"] as ComboBox;
                cmbCategory.SelectedValue = product.CategoryId;

            }
            else // Category
            {
                var repo = new CategoryRepository(_context);
                var category = repo.GetCategoryById(_editId.Value);
                if (category == null) return;

                pnlDynamic.Controls["txtCategoryName"].Text = category.Name;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Устгах мөрийг сонгоно уу.");
                return;
            }

            var id = Convert.ToInt32(dataGridList.SelectedRows[0].Cells["Id"].Value);

            var confirm = MessageBox.Show("Үнэхээр устгах уу?", "Баталгаажуулах", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            string result;
            if (_mode == "Product")
            {
                var repo = new ProductRepository(_context);
                result = repo.DeleteProduct(id);
                LoadProductGrid();
            }
            else
            {
                var productRepo = new ProductRepository(_context);
                var usedCount = productRepo.GetProducts().Count(p => p.CategoryId == id);
                if (usedCount > 0)
                {
                    MessageBox.Show("Энэ ангилалд хамаарах бараа байна.", "Ангиллыг устгах боломжгүй", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var repo = new CategoryRepository(_context);
                result = repo.DeleteCategory(id);
                LoadCategoryGrid();
            }

            MessageBox.Show(result);
        }


    }

}
