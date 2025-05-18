using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSUI
{
    public partial class Payment : Form
    {
        public decimal ReceivedAmount { get; private set; }

        private decimal _total;

        public Payment(decimal totalAmount)
        {

            InitializeComponent();
            _total = totalAmount;
            lblTotal.Text = $"Нийт төлөх: ₮ {_total:F0}";
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCash.Text.Trim(), out decimal cash))
            {
                MessageBox.Show("Зөв мөнгөний утга оруулна уу!", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cash < _total)
            {
                MessageBox.Show("Төлсөн мөнгө хүрэлцэхгүй байна!", "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReceivedAmount = cash;
            decimal change = cash - _total;
            lblChange.Text = $"Хариулт: ₮ {change:F0}";

            var confirm = MessageBox.Show(
    $"Үнийн дүн: ₮{_total:F0}\nТөлбөр: ₮{cash:F0}\nХариулт: ₮{change:F0}\n\nБатлах уу?",
    "Төлбөр батлах",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (confirm == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}