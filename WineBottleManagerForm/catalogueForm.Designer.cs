namespace WineBottleManagerForm
{
    partial class catalogueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogueForm));
            doublePanelContainer = new SplitContainer();
            btnToMain = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            btnToModify = new Button();
            btnToCatalogue = new Button();
            btnToShelf = new Button();
            catalogueDataGrid = new DataGridView();
            btnModify = new Button();
            btnSelect = new Button();
            filtrePanel = new Panel();
            visualCheckedListBox = new CheckedListBox();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            deCreListBox = new CheckedListBox();
            label2 = new Label();
            keyWordTextBox = new TextBox();
            btnToScan = new Button();
            propertyComboBox = new ComboBox();
            Catalogo = new Label();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).BeginInit();
            doublePanelContainer.Panel1.SuspendLayout();
            doublePanelContainer.Panel2.SuspendLayout();
            doublePanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogueDataGrid).BeginInit();
            filtrePanel.SuspendLayout();
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
            doublePanelContainer.Panel1.Controls.Add(button7);
            doublePanelContainer.Panel1.Controls.Add(btnToModify);
            doublePanelContainer.Panel1.Controls.Add(btnToCatalogue);
            doublePanelContainer.Panel1.Controls.Add(btnToShelf);
            // 
            // doublePanelContainer.Panel2
            // 
            doublePanelContainer.Panel2.BackColor = Color.Peru;
            doublePanelContainer.Panel2.Controls.Add(catalogueDataGrid);
            doublePanelContainer.Panel2.Controls.Add(btnModify);
            doublePanelContainer.Panel2.Controls.Add(btnSelect);
            doublePanelContainer.Panel2.Controls.Add(filtrePanel);
            doublePanelContainer.Panel2.Controls.Add(Catalogo);
            doublePanelContainer.Size = new Size(784, 561);
            doublePanelContainer.SplitterDistance = 187;
            doublePanelContainer.TabIndex = 2;
            // 
            // btnToMain
            // 
            btnToMain.BackColor = Color.Wheat;
            btnToMain.FlatStyle = FlatStyle.Popup;
            btnToMain.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToMain.ForeColor = Color.Red;
            btnToMain.Location = new Point(10, 102);
            btnToMain.Name = "btnToMain";
            btnToMain.Size = new Size(175, 32);
            btnToMain.TabIndex = 7;
            btnToMain.Text = "Menù Principale";
            btnToMain.TextAlign = ContentAlignment.MiddleRight;
            btnToMain.UseMnemonic = false;
            btnToMain.UseVisualStyleBackColor = false;
            btnToMain.Click += btnToMain_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.design_package_packet_bottles_box_icon_153191;
            pictureBox1.Location = new Point(39, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(12, 406);
            button7.Name = "button7";
            button7.Size = new Size(175, 32);
            button7.TabIndex = 3;
            button7.Text = "Impostazioni";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseMnemonic = false;
            button7.UseVisualStyleBackColor = true;
            // 
            // btnToModify
            // 
            btnToModify.FlatStyle = FlatStyle.Popup;
            btnToModify.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToModify.ForeColor = Color.Red;
            btnToModify.Location = new Point(10, 220);
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
            btnToCatalogue.BackColor = Color.Peru;
            btnToCatalogue.Enabled = false;
            btnToCatalogue.FlatStyle = FlatStyle.Popup;
            btnToCatalogue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToCatalogue.ForeColor = Color.Red;
            btnToCatalogue.Location = new Point(10, 180);
            btnToCatalogue.Name = "btnToCatalogue";
            btnToCatalogue.Size = new Size(175, 34);
            btnToCatalogue.TabIndex = 1;
            btnToCatalogue.Text = "Catalogo";
            btnToCatalogue.TextAlign = ContentAlignment.MiddleRight;
            btnToCatalogue.UseMnemonic = false;
            btnToCatalogue.UseVisualStyleBackColor = false;
            // 
            // btnToShelf
            // 
            btnToShelf.BackColor = Color.Wheat;
            btnToShelf.FlatStyle = FlatStyle.Popup;
            btnToShelf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToShelf.ForeColor = Color.Red;
            btnToShelf.Location = new Point(10, 140);
            btnToShelf.Name = "btnToShelf";
            btnToShelf.Size = new Size(175, 34);
            btnToShelf.TabIndex = 0;
            btnToShelf.Text = "Cantina";
            btnToShelf.TextAlign = ContentAlignment.MiddleRight;
            btnToShelf.UseMnemonic = false;
            btnToShelf.UseVisualStyleBackColor = false;
            btnToShelf.Click += btnToShelf_Click;
            // 
            // catalogueDataGrid
            // 
            catalogueDataGrid.AllowUserToAddRows = false;
            catalogueDataGrid.AllowUserToDeleteRows = false;
            catalogueDataGrid.AllowUserToResizeColumns = false;
            catalogueDataGrid.AllowUserToResizeRows = false;
            catalogueDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            catalogueDataGrid.BackgroundColor = Color.Moccasin;
            catalogueDataGrid.BorderStyle = BorderStyle.Fixed3D;
            catalogueDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            catalogueDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            catalogueDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            catalogueDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            catalogueDataGrid.GridColor = Color.Wheat;
            catalogueDataGrid.Location = new Point(122, 4);
            catalogueDataGrid.MultiSelect = false;
            catalogueDataGrid.Name = "catalogueDataGrid";
            catalogueDataGrid.ReadOnly = true;
            catalogueDataGrid.RowHeadersVisible = false;
            catalogueDataGrid.RowTemplate.Height = 25;
            catalogueDataGrid.ScrollBars = ScrollBars.Vertical;
            catalogueDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            catalogueDataGrid.ShowEditingIcon = false;
            catalogueDataGrid.Size = new Size(460, 550);
            catalogueDataGrid.TabIndex = 26;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.SandyBrown;
            btnModify.FlatStyle = FlatStyle.Popup;
            btnModify.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModify.ForeColor = Color.Red;
            btnModify.Location = new Point(3, 513);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(119, 37);
            btnModify.TabIndex = 25;
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
            btnSelect.Location = new Point(3, 470);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(119, 37);
            btnSelect.TabIndex = 24;
            btnSelect.Text = "Seleziona Bottiglia ";
            btnSelect.UseMnemonic = false;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // filtrePanel
            // 
            filtrePanel.BorderStyle = BorderStyle.Fixed3D;
            filtrePanel.Controls.Add(visualCheckedListBox);
            filtrePanel.Controls.Add(label5);
            filtrePanel.Controls.Add(label1);
            filtrePanel.Controls.Add(label3);
            filtrePanel.Controls.Add(label4);
            filtrePanel.Controls.Add(deCreListBox);
            filtrePanel.Controls.Add(label2);
            filtrePanel.Controls.Add(keyWordTextBox);
            filtrePanel.Controls.Add(btnToScan);
            filtrePanel.Controls.Add(propertyComboBox);
            filtrePanel.Location = new Point(3, 32);
            filtrePanel.Name = "filtrePanel";
            filtrePanel.Size = new Size(117, 432);
            filtrePanel.TabIndex = 4;
            // 
            // visualCheckedListBox
            // 
            visualCheckedListBox.BackColor = Color.Wheat;
            visualCheckedListBox.CheckOnClick = true;
            visualCheckedListBox.FormattingEnabled = true;
            visualCheckedListBox.Location = new Point(-2, 42);
            visualCheckedListBox.Name = "visualCheckedListBox";
            visualCheckedListBox.ScrollAlwaysVisible = true;
            visualCheckedListBox.Size = new Size(112, 148);
            visualCheckedListBox.TabIndex = 21;
            visualCheckedListBox.ItemCheck += visualCheckedListBox_ItemCheck;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(9, 20);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 19;
            label5.Text = "Visualizza:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(26, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 17;
            label1.Text = "Filtri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 294);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 16;
            label3.Text = "Ricerca parola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(9, 344);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 15;
            label4.Text = "Filtra per:";
            // 
            // deCreListBox
            // 
            deCreListBox.BackColor = Color.Wheat;
            deCreListBox.CheckOnClick = true;
            deCreListBox.FormattingEnabled = true;
            deCreListBox.Items.AddRange(new object[] { "Crescente", "Decrescente" });
            deCreListBox.Location = new Point(-2, 233);
            deCreListBox.Name = "deCreListBox";
            deCreListBox.Size = new Size(112, 40);
            deCreListBox.TabIndex = 10;
            deCreListBox.SelectedValueChanged += deCreListBox_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(11, 209);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 11;
            label2.Text = "Ordine:";
            // 
            // keyWordTextBox
            // 
            keyWordTextBox.BackColor = Color.Wheat;
            keyWordTextBox.ForeColor = Color.Red;
            keyWordTextBox.Location = new Point(0, 318);
            keyWordTextBox.Name = "keyWordTextBox";
            keyWordTextBox.Size = new Size(108, 23);
            keyWordTextBox.TabIndex = 12;
            // 
            // btnToScan
            // 
            btnToScan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnToScan.BackColor = Color.SandyBrown;
            btnToScan.FlatStyle = FlatStyle.Popup;
            btnToScan.ForeColor = Color.Red;
            btnToScan.Location = new Point(-2, 400);
            btnToScan.Name = "btnToScan";
            btnToScan.Size = new Size(112, 25);
            btnToScan.TabIndex = 14;
            btnToScan.Text = "Applica Filtro";
            btnToScan.UseVisualStyleBackColor = false;
            btnToScan.Click += btnToScan_Click;
            // 
            // propertyComboBox
            // 
            propertyComboBox.BackColor = Color.Wheat;
            propertyComboBox.ForeColor = Color.Red;
            propertyComboBox.FormattingEnabled = true;
            propertyComboBox.Location = new Point(0, 368);
            propertyComboBox.Name = "propertyComboBox";
            propertyComboBox.Size = new Size(108, 23);
            propertyComboBox.TabIndex = 13;
            // 
            // Catalogo
            // 
            Catalogo.AutoSize = true;
            Catalogo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Catalogo.ForeColor = Color.Red;
            Catalogo.Location = new Point(3, 4);
            Catalogo.Name = "Catalogo";
            Catalogo.Size = new Size(80, 25);
            Catalogo.TabIndex = 0;
            Catalogo.Text = "Cantina";
            // 
            // catalogueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(doublePanelContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "catalogueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ricerca nel Catalogo Vini";
            FormClosed += catalogueForm_FormClosed;
            doublePanelContainer.Panel1.ResumeLayout(false);
            doublePanelContainer.Panel2.ResumeLayout(false);
            doublePanelContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).EndInit();
            doublePanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogueDataGrid).EndInit();
            filtrePanel.ResumeLayout(false);
            filtrePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer doublePanelContainer;
        private PictureBox pictureBox1;
        private Button button7;
        private Button btnToModify;
        private Button btnToCatalogue;
        private Button btnToShelf;
        private Label Catalogo;
        private Panel filtrePanel;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnToScan;
        private ComboBox propertyComboBox;
        private TextBox keyWordTextBox;
        private Label label2;
        private CheckedListBox deCreListBox;
        private Button btnModify;
        private Button btnSelect;
        private Button btnToMain;
        private Label label5;
        private ComboBox comboBox1;
        private DataGridView catalogueDataGrid;
        private CheckedListBox visualCheckedListBox;
        private ComboBox comboBox2;
    }
}