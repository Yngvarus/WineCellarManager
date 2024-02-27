namespace WineBottleManagerForm
{
    partial class shelfForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shelfForm));
            doublePanelContainer = new SplitContainer();
            btnToMain = new Button();
            pictureBox1 = new PictureBox();
            btnToInfo = new Button();
            btnToModify = new Button();
            btnToCatalogue = new Button();
            btnToShelf = new Button();
            btnModify = new Button();
            btnSelect = new Button();
            shelfDataGrid = new DataGridView();
            label2 = new Label();
            shelfListBox = new CheckedListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).BeginInit();
            doublePanelContainer.Panel1.SuspendLayout();
            doublePanelContainer.Panel2.SuspendLayout();
            doublePanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shelfDataGrid).BeginInit();
            SuspendLayout();
            // 
            // doublePanelContainer
            // 
            doublePanelContainer.BorderStyle = BorderStyle.Fixed3D;
            doublePanelContainer.Dock = DockStyle.Fill;
            doublePanelContainer.Location = new Point(0, 0);
            doublePanelContainer.Name = "doublePanelContainer";
            // 
            // doublePanelContainer.Panel1
            // 
            doublePanelContainer.Panel1.BackColor = Color.Wheat;
            doublePanelContainer.Panel1.Controls.Add(btnToMain);
            doublePanelContainer.Panel1.Controls.Add(pictureBox1);
            doublePanelContainer.Panel1.Controls.Add(btnToInfo);
            doublePanelContainer.Panel1.Controls.Add(btnToModify);
            doublePanelContainer.Panel1.Controls.Add(btnToCatalogue);
            doublePanelContainer.Panel1.Controls.Add(btnToShelf);
            // 
            // doublePanelContainer.Panel2
            // 
            doublePanelContainer.Panel2.BackColor = Color.Peru;
            doublePanelContainer.Panel2.Controls.Add(btnModify);
            doublePanelContainer.Panel2.Controls.Add(btnSelect);
            doublePanelContainer.Panel2.Controls.Add(shelfDataGrid);
            doublePanelContainer.Panel2.Controls.Add(label2);
            doublePanelContainer.Panel2.Controls.Add(shelfListBox);
            doublePanelContainer.Panel2.Controls.Add(label1);
            doublePanelContainer.Size = new Size(784, 561);
            doublePanelContainer.SplitterDistance = 187;
            doublePanelContainer.TabIndex = 1;
            // 
            // btnToMain
            // 
            btnToMain.BackColor = Color.Wheat;
            btnToMain.FlatStyle = FlatStyle.Popup;
            btnToMain.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToMain.ForeColor = Color.Red;
            btnToMain.Location = new Point(8, 102);
            btnToMain.Name = "btnToMain";
            btnToMain.Size = new Size(175, 32);
            btnToMain.TabIndex = 6;
            btnToMain.Text = "Menù Principale";
            btnToMain.TextAlign = ContentAlignment.MiddleRight;
            btnToMain.UseMnemonic = false;
            btnToMain.UseVisualStyleBackColor = false;
            btnToMain.Click += btnToMain_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.design_package_packet_bottles_box_icon_153191;
            pictureBox1.Location = new Point(37, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnToInfo
            // 
            btnToInfo.FlatStyle = FlatStyle.Popup;
            btnToInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnToInfo.ForeColor = Color.Red;
            btnToInfo.Location = new Point(12, 406);
            btnToInfo.Name = "btnToInfo";
            btnToInfo.Size = new Size(175, 32);
            btnToInfo.TabIndex = 3;
            btnToInfo.Text = "Impostazioni";
            btnToInfo.TextAlign = ContentAlignment.MiddleRight;
            btnToInfo.UseMnemonic = false;
            btnToInfo.UseVisualStyleBackColor = true;
            // 
            // btnToModify
            // 
            btnToModify.FlatStyle = FlatStyle.Popup;
            btnToModify.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToModify.ForeColor = Color.Red;
            btnToModify.Location = new Point(8, 220);
            btnToModify.Name = "btnToModify";
            btnToModify.Size = new Size(175, 32);
            btnToModify.TabIndex = 2;
            btnToModify.Text = "Menù Modifica";
            btnToModify.TextAlign = ContentAlignment.MiddleRight;
            btnToModify.UseMnemonic = false;
            btnToModify.UseVisualStyleBackColor = true;
            btnToModify.Click += btnToModify_Click;
            // 
            // btnToCatalogue
            // 
            btnToCatalogue.FlatStyle = FlatStyle.Popup;
            btnToCatalogue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToCatalogue.ForeColor = Color.Red;
            btnToCatalogue.Location = new Point(8, 180);
            btnToCatalogue.Name = "btnToCatalogue";
            btnToCatalogue.Size = new Size(175, 34);
            btnToCatalogue.TabIndex = 1;
            btnToCatalogue.Text = "Catalogo";
            btnToCatalogue.TextAlign = ContentAlignment.MiddleRight;
            btnToCatalogue.UseMnemonic = false;
            btnToCatalogue.UseVisualStyleBackColor = true;
            btnToCatalogue.Click += btnToCatalogue_Click;
            // 
            // btnToShelf
            // 
            btnToShelf.BackColor = Color.Peru;
            btnToShelf.Enabled = false;
            btnToShelf.FlatStyle = FlatStyle.Popup;
            btnToShelf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToShelf.ForeColor = Color.Red;
            btnToShelf.Location = new Point(8, 140);
            btnToShelf.Name = "btnToShelf";
            btnToShelf.Size = new Size(175, 34);
            btnToShelf.TabIndex = 0;
            btnToShelf.Text = "Cantina";
            btnToShelf.TextAlign = ContentAlignment.MiddleRight;
            btnToShelf.UseMnemonic = false;
            btnToShelf.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.SandyBrown;
            btnModify.FlatStyle = FlatStyle.Popup;
            btnModify.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModify.ForeColor = Color.Red;
            btnModify.Location = new Point(3, 384);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(113, 35);
            btnModify.TabIndex = 27;
            btnModify.Text = "Modifica Bottiglia";
            btnModify.UseMnemonic = false;
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.SandyBrown;
            btnSelect.FlatStyle = FlatStyle.Popup;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.Red;
            btnSelect.Location = new Point(3, 343);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(113, 35);
            btnSelect.TabIndex = 26;
            btnSelect.Text = "Seleziona Bottiglia ";
            btnSelect.UseMnemonic = false;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // shelfDataGrid
            // 
            shelfDataGrid.AllowUserToAddRows = false;
            shelfDataGrid.AllowUserToDeleteRows = false;
            shelfDataGrid.AllowUserToResizeColumns = false;
            shelfDataGrid.AllowUserToResizeRows = false;
            shelfDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shelfDataGrid.BackgroundColor = Color.Moccasin;
            shelfDataGrid.BorderStyle = BorderStyle.Fixed3D;
            shelfDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            shelfDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            shelfDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            shelfDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            shelfDataGrid.GridColor = Color.Wheat;
            shelfDataGrid.Location = new Point(122, 4);
            shelfDataGrid.MultiSelect = false;
            shelfDataGrid.Name = "shelfDataGrid";
            shelfDataGrid.ReadOnly = true;
            shelfDataGrid.RowHeadersVisible = false;
            shelfDataGrid.RowTemplate.Height = 25;
            shelfDataGrid.ScrollBars = ScrollBars.Vertical;
            shelfDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shelfDataGrid.ShowEditingIcon = false;
            shelfDataGrid.Size = new Size(460, 550);
            shelfDataGrid.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(4, 60);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 2;
            label2.Text = "Scaffale:";
            // 
            // shelfListBox
            // 
            shelfListBox.BackColor = Color.Wheat;
            shelfListBox.CheckOnClick = true;
            shelfListBox.FormattingEnabled = true;
            shelfListBox.Location = new Point(3, 84);
            shelfListBox.Name = "shelfListBox";
            shelfListBox.Size = new Size(113, 256);
            shelfListBox.TabIndex = 1;
            shelfListBox.ItemCheck += shelfListBox_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Cantina";
            // 
            // shelfForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(doublePanelContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "shelfForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cantina";
            FormClosing += shelfForm_FormClosing;
            VisibleChanged += shelfForm_VisibleChanged;
            doublePanelContainer.Panel1.ResumeLayout(false);
            doublePanelContainer.Panel2.ResumeLayout(false);
            doublePanelContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).EndInit();
            doublePanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shelfDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer doublePanelContainer;
        private PictureBox pictureBox1;
        private Button btnToInfo;
        private Button btnToModify;
        private Button btnToCatalogue;
        private Button btnToShelf;
        private Label label1;
        private Label label2;
        private CheckedListBox shelfListBox;
        private DataGridView shelfDataGrid;
        private Button btnModify;
        private Button btnSelect;
        private Button btnToMain;
    }
}