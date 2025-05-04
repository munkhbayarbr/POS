namespace POSUI
{
    partial class Profile
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
            tableLayoutPanel1 = new TableLayoutPanel();
            LogOutBtn = new Button();
            backBtn = new Button();
            panel1 = new Panel();
            lblRole = new Label();
            lblName = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(LogOutBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(backBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.Red;
            LogOutBtn.Dock = DockStyle.Fill;
            LogOutBtn.ForeColor = SystemColors.ButtonFace;
            LogOutBtn.Location = new Point(3, 408);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(794, 39);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "Гарах";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOut;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ActiveCaption;
            backBtn.Dock = DockStyle.Left;
            backBtn.Location = new Point(3, 3);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 39);
            backBtn.TabIndex = 0;
            backBtn.Text = "Буцах";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += back;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 354);
            panel1.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRole.Location = new Point(288, 150);
            lblRole.MinimumSize = new Size(200, 50);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(200, 50);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role: ";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(288, 78);
            lblName.MinimumSize = new Size(200, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(200, 50);
            lblName.TabIndex = 0;
            lblName.Text = "UserName: ";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Profile";
            Text = "Profile";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button backBtn;
        private Button LogOutBtn;
        private Panel panel1;
        private Label lblRole;
        private Label lblName;
    }
}