using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories;
namespace POSUI;
public partial class MainForm : Form
{
    private readonly User _currentUser;
    private readonly ProductRepository _productRepo;

    public MainForm(User user)
    {
        InitializeComponent();
        _productRepo = new ProductRepository();
         timer.Start();
        _currentUser = user;
        gridCart.AutoGenerateColumns = false;
        gridCart.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ItemName",
            HeaderText = "Item Name",
            DataPropertyName = "Name"
        });
        gridCart.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Quantity",
            HeaderText = "Qty",
            DataPropertyName = "Quantity"
        });
       
        gridCart.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "Edit",
            Text = "✎",
            UseColumnTextForButtonValue = true
        });
        gridCart.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "Delete",
            Text = "🗑",
            UseColumnTextForButtonValue = true
        });

        LoadProducts();

    }

    private void LoadProducts()
    {

        var productList = _productRepo.GetProducts();

        flowProducts.Controls.Clear();

        foreach (var prod in productList)
        {

            var card = new Panel
            {
                Width = 120,
                Height = 140,
                Margin = new Padding(5),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var pic = new PictureBox
            {
                Image = Image.FromFile(@"C:\Users\munkh\Source\Repos\POS\POSUI\shop.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top,
                Height = 80
            };

            var lbl = new Label
            {
                Text = $"{prod.Name}\n${prod.Price:F2}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Regular)
            };

            card.Controls.Add(lbl);
            card.Controls.Add(pic);
            flowProducts.Controls.Add(card);

            card.Click += (s, e) => AddToCart(prod);
        }
    }

    private void AddToCart(Product prod)
    {

    }
    private void timer_run(object sender, EventArgs e)
    {
        timeArea.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
    private void ShowProfile(object sender, EventArgs e)
    {
        Hide();
        using var profile = new Profile(_currentUser);
        profile.ShowDialog();
        Show();
    }

 
}
    