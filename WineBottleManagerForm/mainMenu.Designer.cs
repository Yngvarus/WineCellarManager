namespace WineBottleManagerForm
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            doublePanelContainer = new SplitContainer();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            btnToInfo = new Button();
            btnToModify = new Button();
            btnToCatalogue = new Button();
            btnToShelf = new Button();
            btnCreate = new Button();
            btnSelect = new Button();
            lblPrice = new Label();
            lblStockPos = new Label();
            lblNote = new Label();
            lblVineyard = new Label();
            lblLocYear = new Label();
            modifyBottleBtn = new Button();
            addRemBottleBtn = new Button();
            lblName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).BeginInit();
            doublePanelContainer.Panel1.SuspendLayout();
            doublePanelContainer.Panel2.SuspendLayout();
            doublePanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            doublePanelContainer.Panel1.Controls.Add(button4);
            doublePanelContainer.Panel1.Controls.Add(pictureBox1);
            doublePanelContainer.Panel1.Controls.Add(btnToInfo);
            doublePanelContainer.Panel1.Controls.Add(btnToModify);
            doublePanelContainer.Panel1.Controls.Add(btnToCatalogue);
            doublePanelContainer.Panel1.Controls.Add(btnToShelf);
            // 
            // doublePanelContainer.Panel2
            // 
            doublePanelContainer.Panel2.BackColor = Color.Peru;
            doublePanelContainer.Panel2.Controls.Add(btnCreate);
            doublePanelContainer.Panel2.Controls.Add(btnSelect);
            doublePanelContainer.Panel2.Controls.Add(lblPrice);
            doublePanelContainer.Panel2.Controls.Add(lblStockPos);
            doublePanelContainer.Panel2.Controls.Add(lblNote);
            doublePanelContainer.Panel2.Controls.Add(lblVineyard);
            doublePanelContainer.Panel2.Controls.Add(lblLocYear);
            doublePanelContainer.Panel2.Controls.Add(modifyBottleBtn);
            doublePanelContainer.Panel2.Controls.Add(addRemBottleBtn);
            doublePanelContainer.Panel2.Controls.Add(lblName);
            doublePanelContainer.Panel2.Controls.Add(label1);
            doublePanelContainer.Size = new Size(784, 561);
            doublePanelContainer.SplitterDistance = 187;
            doublePanelContainer.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.Enabled = false;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(10, 102);
            button4.Name = "button4";
            button4.Size = new Size(175, 32);
            button4.TabIndex = 5;
            button4.Text = "Menù Principale";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.design_package_packet_bottles_box_icon_153191;
            pictureBox1.Location = new Point(35, 3);
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
            btnToModify.Location = new Point(10, 217);
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
            btnToCatalogue.Location = new Point(10, 177);
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
            btnToShelf.FlatStyle = FlatStyle.Popup;
            btnToShelf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToShelf.ForeColor = Color.Red;
            btnToShelf.Location = new Point(10, 137);
            btnToShelf.Name = "btnToShelf";
            btnToShelf.Size = new Size(175, 34);
            btnToShelf.TabIndex = 0;
            btnToShelf.Text = "Cantina";
            btnToShelf.TextAlign = ContentAlignment.MiddleRight;
            btnToShelf.UseMnemonic = false;
            btnToShelf.UseVisualStyleBackColor = true;
            btnToShelf.Click += btnToShelf_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Peru;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Red;
            btnCreate.Location = new Point(318, 494);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(252, 42);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Crea nuova Bottiglia";
            btnCreate.UseMnemonic = false;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Peru;
            btnSelect.FlatStyle = FlatStyle.Popup;
            btnSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.Red;
            btnSelect.Location = new Point(18, 494);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(252, 42);
            btnSelect.TabIndex = 14;
            btnSelect.Text = "Seleziona un'altra Bottiglia";
            btnSelect.UseMnemonic = false;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(168, 364);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(213, 25);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Prezzo Acquisto/Vendita";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStockPos
            // 
            lblStockPos.AutoSize = true;
            lblStockPos.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblStockPos.ForeColor = Color.Red;
            lblStockPos.Location = new Point(183, 330);
            lblStockPos.Name = "lblStockPos";
            lblStockPos.Size = new Size(182, 25);
            lblStockPos.TabIndex = 11;
            lblStockPos.Text = "Quantità e Posizione";
            lblStockPos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNote
            // 
            lblNote.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNote.ForeColor = Color.Red;
            lblNote.Location = new Point(61, 146);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(479, 174);
            lblNote.TabIndex = 10;
            lblNote.Text = "Note: Stile, ...";
            // 
            // lblVineyard
            // 
            lblVineyard.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblVineyard.ForeColor = Color.Red;
            lblVineyard.Location = new Point(124, 73);
            lblVineyard.Name = "lblVineyard";
            lblVineyard.Size = new Size(303, 32);
            lblVineyard.TabIndex = 9;
            lblVineyard.Text = "Vigneto";
            lblVineyard.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLocYear
            // 
            lblLocYear.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblLocYear.ForeColor = Color.Red;
            lblLocYear.Location = new Point(61, 96);
            lblLocYear.Name = "lblLocYear";
            lblLocYear.Size = new Size(421, 32);
            lblLocYear.TabIndex = 8;
            lblLocYear.Text = "Locazione geografica, anno ";
            lblLocYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modifyBottleBtn
            // 
            modifyBottleBtn.BackColor = Color.Peru;
            modifyBottleBtn.FlatStyle = FlatStyle.Popup;
            modifyBottleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            modifyBottleBtn.ForeColor = Color.Red;
            modifyBottleBtn.Location = new Point(18, 446);
            modifyBottleBtn.Name = "modifyBottleBtn";
            modifyBottleBtn.Size = new Size(252, 42);
            modifyBottleBtn.TabIndex = 7;
            modifyBottleBtn.Text = "Modifica Bottiglia Selezionata";
            modifyBottleBtn.UseMnemonic = false;
            modifyBottleBtn.UseVisualStyleBackColor = false;
            modifyBottleBtn.Click += modifyBottleBtn_Click;
            // 
            // addRemBottleBtn
            // 
            addRemBottleBtn.BackColor = Color.Peru;
            addRemBottleBtn.FlatStyle = FlatStyle.Popup;
            addRemBottleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addRemBottleBtn.ForeColor = Color.Red;
            addRemBottleBtn.Location = new Point(320, 446);
            addRemBottleBtn.Name = "addRemBottleBtn";
            addRemBottleBtn.Size = new Size(252, 42);
            addRemBottleBtn.TabIndex = 5;
            addRemBottleBtn.Text = "Aggiungi o Rimuovi Bottiglie";
            addRemBottleBtn.UseMnemonic = false;
            addRemBottleBtn.UseVisualStyleBackColor = false;
            addRemBottleBtn.Click += addRemBottleBtn_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(61, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(479, 45);
            lblName.TabIndex = 4;
            lblName.Text = "Bottiglia selezionata";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Menù principale";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(784, 561);
            Controls.Add(doublePanelContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menù principale";
            doublePanelContainer.Panel1.ResumeLayout(false);
            doublePanelContainer.Panel2.ResumeLayout(false);
            doublePanelContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).EndInit();
            doublePanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer doublePanelContainer;
        private Button btnToModify;
        private Button btnToCatalogue;
        private Button btnToShelf;
        private Label label1;
        private Button modifyBottleBtn;
        private Button addRemBottleBtn;
        private Label lblName;
        private Button btnToInfo;
        private PictureBox pictureBox1;
        private Button button4;
        private Label lblPrice;
        private Label lblStockPos;
        private Label lblNote;
        private Label lblVineyard;
        private Label lblLocYear;
        private Button btnSelect;
        private Button btnCreate;
    }
}