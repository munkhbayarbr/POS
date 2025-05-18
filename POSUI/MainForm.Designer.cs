using System.ComponentModel;
using System.Windows.Forms;

namespace POSUI;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
        tableLayoutPanel1 = new TableLayoutPanel();
        flows = new TableLayoutPanel();
        panel1 = new Panel();
        button1 = new Button();
        txtCode = new TextBox();
        flowProducts = new FlowLayoutPanel();
        flowCategories = new FlowLayoutPanel();
        panel2 = new Panel();
        label1 = new Label();
        timeArea = new Label();
        panel3 = new Panel();
        HelperBtn = new Button();
        CategoryBtn = new Button();
        ProductBtn = new Button();
        pictureBox1 = new PictureBox();
        lblTotalAmount = new Label();
        flowCartPanel = new FlowLayoutPanel();
        timer = new System.Windows.Forms.Timer(components);
        tableLayoutPanel1.SuspendLayout();
        flows.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(flows, 1, 1);
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Controls.Add(panel3, 1, 0);
        tableLayoutPanel1.Controls.Add(lblTotalAmount, 0, 2);
        tableLayoutPanel1.Controls.Add(flowCartPanel, 0, 1);
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
        // flows
        // 
        flows.ColumnCount = 1;
        flows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        flows.Controls.Add(panel1, 0, 0);
        flows.Controls.Add(flowProducts, 0, 1);
        flows.Controls.Add(flowCategories, 0, 2);
        flows.Dock = DockStyle.Fill;
        flows.Location = new Point(463, 43);
        flows.Name = "flows";
        flows.RowCount = 3;
        flows.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        flows.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        flows.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        flows.Size = new Size(592, 352);
        flows.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Controls.Add(txtCode);
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
        // txtCode
        // 
        txtCode.Dock = DockStyle.Fill;
        txtCode.Location = new Point(0, 0);
        txtCode.Margin = new Padding(0);
        txtCode.Multiline = true;
        txtCode.Name = "txtCode";
        txtCode.PlaceholderText = "Барааны код";
        txtCode.Size = new Size(586, 34);
        txtCode.TabIndex = 0;
        // 
        // flowProducts
        // 
        flowProducts.AutoScroll = true;
        flowProducts.Dock = DockStyle.Fill;
        flowProducts.Location = new Point(3, 43);
        flowProducts.Name = "flowProducts";
        flowProducts.Size = new Size(586, 150);
        flowProducts.TabIndex = 1;
        // 
        // flowCategories
        // 
        flowCategories.Dock = DockStyle.Fill;
        flowCategories.Location = new Point(3, 199);
        flowCategories.Name = "flowCategories";
        flowCategories.Size = new Size(586, 150);
        flowCategories.TabIndex = 2;
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
        panel3.Controls.Add(HelperBtn);
        panel3.Controls.Add(CategoryBtn);
        panel3.Controls.Add(ProductBtn);
        panel3.Controls.Add(pictureBox1);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(463, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(592, 34);
        panel3.TabIndex = 3;
        // 
        // HelperBtn
        // 
        HelperBtn.Location = new Point(189, 3);
        HelperBtn.Name = "HelperBtn";
        HelperBtn.Size = new Size(87, 31);
        HelperBtn.TabIndex = 5;
        HelperBtn.Text = "Тусламж";
        HelperBtn.UseVisualStyleBackColor = true;
        // 
        // CategoryBtn
        // 
        CategoryBtn.Location = new Point(96, 3);
        CategoryBtn.Name = "CategoryBtn";
        CategoryBtn.Size = new Size(87, 31);
        CategoryBtn.TabIndex = 5;
        CategoryBtn.Text = "Төрөл";
        CategoryBtn.UseVisualStyleBackColor = true;
        CategoryBtn.Click += CategoryBtn_Click;
        // 
        // ProductBtn
        // 
        ProductBtn.Location = new Point(3, 3);
        ProductBtn.Name = "ProductBtn";
        ProductBtn.Size = new Size(87, 31);
        ProductBtn.TabIndex = 5;
        ProductBtn.Text = "Бараа";
        ProductBtn.UseVisualStyleBackColor = true;
        ProductBtn.Click += ProductBtn_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Cursor = Cursors.Hand;
        pictureBox1.Dock = DockStyle.Right;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(556, 0);
        pictureBox1.Margin = new Padding(3, 3, 10, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(36, 34);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        pictureBox1.Click += ShowProfile;
        // 
        // lblTotalAmount
        // 
        lblTotalAmount.AutoSize = true;
        lblTotalAmount.Location = new Point(3, 398);
        lblTotalAmount.Name = "lblTotalAmount";
        lblTotalAmount.Size = new Size(38, 15);
        lblTotalAmount.TabIndex = 4;
        lblTotalAmount.Text = "label2";
        // 
        // flowCartPanel
        // 
        flowCartPanel.AutoScroll = true;
        flowCartPanel.BorderStyle = BorderStyle.FixedSingle;
        flowCartPanel.Dock = DockStyle.Fill;
        flowCartPanel.FlowDirection = FlowDirection.TopDown;
        flowCartPanel.Location = new Point(3, 43);
        flowCartPanel.Name = "flowCartPanel";
        flowCartPanel.Size = new Size(454, 352);
        flowCartPanel.TabIndex = 5;
        flowCartPanel.WrapContents = false;
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Interval = 1000;
        timer.Tick += timer_run;
        // 
        // MainForm
        // 
        ClientSize = new Size(1058, 498);
        Controls.Add(tableLayoutPanel1);
        Name = "MainForm";
        Text = "MainForm";
        WindowState = FormWindowState.Maximized;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        flows.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        ((ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }
    #endregion


    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel flows;
    private Panel panel1;
    private Button button1;
    private TextBox txtCode;
    private FlowLayoutPanel flowProducts;
    private Panel panel2;
    private Label timeArea;
    private Label label1;
    private System.Windows.Forms.Timer timer;
   
    private Panel panel3;
    private PictureBox pictureBox1;
    private FlowLayoutPanel flowCategories;
    private ToolStripContainer toolStripContainer1;
    private Button HelperBtn;
    private Button CategoryBtn;
    private Button ProductBtn;
    private Label lblTotalAmount;
    private FlowLayoutPanel flowCartPanel;
}