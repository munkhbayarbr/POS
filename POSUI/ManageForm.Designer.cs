namespace POSUI
{
    partial class ManageForm
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
            pnlDynamic = new Panel();
            dataGridList = new DataGridView();
            panel1 = new Panel();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDynamic
            // 
            pnlDynamic.Dock = DockStyle.Top;
            pnlDynamic.Location = new Point(0, 0);
            pnlDynamic.Name = "pnlDynamic";
            pnlDynamic.Size = new Size(1008, 220);
            pnlDynamic.TabIndex = 0;
            // 
            // dataGridList
            // 
            dataGridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridList.Dock = DockStyle.Fill;
            dataGridList.Location = new Point(0, 220);
            dataGridList.Name = "dataGridList";
            dataGridList.ReadOnly = true;
            dataGridList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridList.Size = new Size(1008, 430);
            dataGridList.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 550);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 100);
            panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 23);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 51);
            btnSave.TabIndex = 0;
            btnSave.Text = "Хадгалах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(173, 23);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 51);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(320, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 51);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 650);
            Controls.Add(panel1);
            Controls.Add(dataGridList);
            Controls.Add(pnlDynamic);
            Name = "ManageForm";
            Text = "ManageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDynamic;
        private DataGridView dataGridList;
        private Panel panel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
    }
}