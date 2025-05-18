using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace POSUI
{
    public partial class CartItemControl : UserControl
    {
        public event Action<CartItem> OnQuantityChanged;

        private CartItem _item;
        public CartItemControl(CartItem item)
        {
            InitializeComponent();
            this.Margin = new Padding(0);
            this.AutoSize = false;
            this.Height = 60; 


            _item = item;
            Render();
        
        }

        private void Render()
        {
            lblName.Text = $"{_item.Product.Name} ";
            lblPrice.Text = $"₮ {_item.Product.Price:F0}";
            lblQty.Text = _item.Quantity.ToString();
            lblTotal.Text = $"₮ {_item.Total}";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _item.Quantity++;
            Render();
            OnQuantityChanged?.Invoke(_item);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _item.Quantity--;
            if (_item.Quantity <= 0)
            {
                this.Parent.Controls.Remove(this); 
            }
            else
            {
                Render();
            }

            OnQuantityChanged?.Invoke(_item);
        }
        public void RefreshUI()
        {
            lblQty.Text = _item.Quantity.ToString();
            lblTotal.Text = $"₮ {_item.Total:F0}";
        }

        public CartItem GetItem() => _item;


    }
}
