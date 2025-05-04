using System.ComponentModel;
using System.Windows.Forms;

namespace POSUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      
      
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
            components = new Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            gridCart = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            flowProducts = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            timeArea = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            MenuStrip = new ContextMenuStrip(components);
            profileToolStripMenuItem = new ToolStripMenuItem();
            ангилалToolStripMenuItem = new ToolStripMenuItem();
            тусламжToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)gridCart).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(gridCart, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(1058, 498);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gridCart
            // 
            gridCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCart.Dock = DockStyle.Fill;
            gridCart.Location = new Point(3, 43);
            gridCart.Name = "gridCart";
            gridCart.Size = new Size(454, 352);
            gridCart.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(flowProducts, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(463, 43);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.Size = new Size(592, 352);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 34);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(558, 0);
            button1.Name = "button1";
            button1.Size = new Size(28, 34);
            button1.TabIndex = 1;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(586, 34);
            textBox1.TabIndex = 0;
            // 
            // flowProducts
            // 
            flowProducts.AutoScroll = true;
            flowProducts.Dock = DockStyle.Fill;
            flowProducts.Location = new Point(3, 43);
            flowProducts.Name = "flowProducts";
            flowProducts.Size = new Size(586, 186);
            flowProducts.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(timeArea);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 0, 0);
            panel2.Size = new Size(454, 34);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "SUPERMARKET";
            // 
            // timeArea
            // 
            timeArea.AutoSize = true;
            timeArea.Dock = DockStyle.Bottom;
            timeArea.Location = new Point(10, 19);
            timeArea.Name = "timeArea";
            timeArea.Size = new Size(136, 15);
            timeArea.TabIndex = 1;
            timeArea.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(463, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 34);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(556, 0);
            pictureBox1.Margin = new Padding(3, 3, 10, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ShowProfile;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_run;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, ангилалToolStripMenuItem, тусламжToolStripMenuItem });
            MenuStrip.Name = "Цэс";
            MenuStrip.Size = new Size(124, 70);
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(123, 22);
            profileToolStripMenuItem.Text = "Бараа";
            // 
            // ангилалToolStripMenuItem
            // 
            ангилалToolStripMenuItem.Name = "ангилалToolStripMenuItem";
            ангилалToolStripMenuItem.Size = new Size(123, 22);
            ангилалToolStripMenuItem.Text = "Ангилал";
            // 
            // тусламжToolStripMenuItem
            // 
            тусламжToolStripMenuItem.Name = "тусламжToolStripMenuItem";
            тусламжToolStripMenuItem.Size = new Size(123, 22);
            тусламжToolStripMenuItem.Text = "Тусламж";
            // 
            // MainForm
            // 
            ClientSize = new Size(1058, 498);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)gridCart).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            MenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion


        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private FlowLayoutPanel flowProducts;
        private DataGridView gridCart;
        private Panel panel2;
        private Label timeArea;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private ContextMenuStrip MenuStrip;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem ангилалToolStripMenuItem;
        private ToolStripMenuItem тусламжToolStripMenuItem;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}