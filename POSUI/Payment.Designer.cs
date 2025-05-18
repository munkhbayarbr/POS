namespace POSUI
{
    partial class Payment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotal = new Label();
            label1 = new Label();
            txtCash = new TextBox();
            lblChange = new Label();
            btnPay = new Button();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(20, 20);
            lblTotal.MinimumSize = new Size(280, 30);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(280, 30);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Нийт төлөх: ₮ 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 60);
            label1.MinimumSize = new Size(100, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 1;
            label1.Text = "Бэлэн мөнгө:";
            // 
            // txtCash
            // 
            txtCash.Location = new Point(130, 58);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(150, 23);
            txtCash.TabIndex = 2;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(20, 100);
            lblChange.MinimumSize = new Size(280, 30);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(280, 30);
            lblChange.TabIndex = 3;
            lblChange.Text = "Хариулт: ₮ 0";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(20, 150);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(260, 40);
            btnPay.TabIndex = 4;
            btnPay.Text = "Төлбөр хийх";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnConfirm_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 221);
            Controls.Add(btnPay);
            Controls.Add(lblChange);
            Controls.Add(txtCash);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label label1;
        private TextBox txtCash;
        private Label lblChange;
        private Button btnPay;
    }
}