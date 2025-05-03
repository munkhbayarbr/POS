using PosLibrary.Data;
using PosLibrary.Models;
namespace POSUI;
public partial class MainForm : Form
{
    private readonly User _currentUser;

    public MainForm(User user)
    {
        InitializeComponent();
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
        // … U/Price, Dis%, Total …
        // Then Add Edit/Delete buttons if you like:
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

        var productList = new Context().Products.ToList();

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
                Image = Image.FromFile(@"C:\Users\muba\Downloads\goods.png"),
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

   
}
