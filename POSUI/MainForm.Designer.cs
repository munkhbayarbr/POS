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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///  private IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuProducts, mnuCategories, mnuHelp;
        private StatusStrip statusStrip1;
        private DataGridView dProducts;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd, btnEdit, btnDelete;
      
      
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
            menuStrip = new MenuStrip();
            mnuProducts = new ToolStripMenuItem();
            mnuCategories = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            dProducts = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            menuStrip.SuspendLayout();
            ((ISupportInitialize)dProducts).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuProducts, mnuCategories, mnuHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(990, 24);
            menuStrip.TabIndex = 3;
            // 
            // mnuProducts
            // 
            mnuProducts.Name = "mnuProducts";
            mnuProducts.Size = new Size(51, 20);
            mnuProducts.Text = "Бараа";
            // 
            // mnuCategories
            // 
            mnuCategories.Name = "mnuCategories";
            mnuCategories.Size = new Size(115, 20);
            mnuCategories.Text = "Барааны ангилал";
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(68, 20);
            mnuHelp.Text = "Тусламж";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 453);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(990, 22);
            statusStrip1.TabIndex = 2;
            // 
            // dProducts
            // 
            dProducts.Dock = DockStyle.Right;
            dProducts.Location = new Point(411, 24);
            dProducts.Name = "dProducts";
            dProducts.Size = new Size(579, 429);
            dProducts.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(411, 429);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(84, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(990, 475);
            Controls.Add(dProducts);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((ISupportInitialize)dProducts).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


    }
}