namespace POSUI
{
    partial class CartItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblTotal = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            lblQty = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Product = x";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(329, 10);
            lblTotal.MinimumSize = new Size(90, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0 ₮";
            // 
            // btnPlus
            // 
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Location = new Point(178, 10);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(30, 30);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(270, 10);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(30, 30);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(232, 18);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(14, 15);
            lblQty.TabIndex = 0;
            lblQty.Text = "X";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(109, 10);
            lblPrice.MinimumSize = new Size(50, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "0 ₮";
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(lblTotal);
            Controls.Add(lblQty);
            Controls.Add(lblName);
            Name = "CartItemControl";
            Size = new Size(422, 478);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTotal;
        private Button btnPlus;
        private Button btnMinus;
        private Label lblQty;
        private Label lblPrice;
    }
}
