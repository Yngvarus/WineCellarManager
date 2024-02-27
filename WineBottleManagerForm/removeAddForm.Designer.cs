namespace WineBottleManagerForm
{
    partial class removeAddForm
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
            doublePanelContainer = new SplitContainer();
            btnCreate = new Button();
            btnToMain = new Button();
            btnModify = new Button();
            btnAddRem = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            btnToModify = new Button();
            btnToCatalogue = new Button();
            btnToShelf = new Button();
            lblQuantity = new TextBox();
            stockText = new TextBox();
            label3 = new Label();
            cellarLocationTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnRemoveBottle = new Button();
            btnAddBottle = new Button();
            label6 = new Label();
            btnToAnother = new Button();
            nameTextBox = new TextBox();
            yearTextBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
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
            doublePanelContainer.Dock = DockStyle.Fill;
            doublePanelContainer.Location = new Point(0, 0);
            doublePanelContainer.Name = "doublePanelContainer";
            // 
            // doublePanelContainer.Panel1
            // 
            doublePanelContainer.Panel1.BackColor = Color.Wheat;
            doublePanelContainer.Panel1.Controls.Add(btnCreate);
            doublePanelContainer.Panel1.Controls.Add(btnToMain);
            doublePanelContainer.Panel1.Controls.Add(btnModify);
            doublePanelContainer.Panel1.Controls.Add(btnAddRem);
            doublePanelContainer.Panel1.Controls.Add(pictureBox1);
            doublePanelContainer.Panel1.Controls.Add(button7);
            doublePanelContainer.Panel1.Controls.Add(btnToModify);
            doublePanelContainer.Panel1.Controls.Add(btnToCatalogue);
            doublePanelContainer.Panel1.Controls.Add(btnToShelf);
            // 
            // doublePanelContainer.Panel2
            // 
            doublePanelContainer.Panel2.BackColor = Color.Peru;
            doublePanelContainer.Panel2.Controls.Add(lblQuantity);
            doublePanelContainer.Panel2.Controls.Add(stockText);
            doublePanelContainer.Panel2.Controls.Add(label3);
            doublePanelContainer.Panel2.Controls.Add(cellarLocationTextBox);
            doublePanelContainer.Panel2.Controls.Add(label7);
            doublePanelContainer.Panel2.Controls.Add(label8);
            doublePanelContainer.Panel2.Controls.Add(btnRemoveBottle);
            doublePanelContainer.Panel2.Controls.Add(btnAddBottle);
            doublePanelContainer.Panel2.Controls.Add(label6);
            doublePanelContainer.Panel2.Controls.Add(btnToAnother);
            doublePanelContainer.Panel2.Controls.Add(nameTextBox);
            doublePanelContainer.Panel2.Controls.Add(yearTextBox);
            doublePanelContainer.Panel2.Controls.Add(label5);
            doublePanelContainer.Panel2.Controls.Add(label2);
            doublePanelContainer.Panel2.Controls.Add(label1);
            doublePanelContainer.Size = new Size(784, 561);
            doublePanelContainer.SplitterDistance = 187;
            doublePanelContainer.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Orange;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Red;
            btnCreate.Location = new Point(43, 332);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 32);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Crea Bottiglie";
            btnCreate.TextAlign = ContentAlignment.MiddleRight;
            btnCreate.UseMnemonic = false;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
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
            // btnModify
            // 
            btnModify.BackColor = Color.Orange;
            btnModify.FlatStyle = FlatStyle.Popup;
            btnModify.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnModify.ForeColor = Color.Red;
            btnModify.Location = new Point(41, 294);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(144, 32);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modifica Bottiglie";
            btnModify.TextAlign = ContentAlignment.MiddleRight;
            btnModify.UseMnemonic = false;
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnAddRem
            // 
            btnAddRem.BackColor = Color.Peru;
            btnAddRem.Enabled = false;
            btnAddRem.FlatStyle = FlatStyle.Popup;
            btnAddRem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddRem.ForeColor = Color.Red;
            btnAddRem.Location = new Point(41, 256);
            btnAddRem.Name = "btnAddRem";
            btnAddRem.Size = new Size(144, 32);
            btnAddRem.TabIndex = 5;
            btnAddRem.Text = "Agg./Rimuov.";
            btnAddRem.TextAlign = ContentAlignment.MiddleRight;
            btnAddRem.UseMnemonic = false;
            btnAddRem.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.design_package_packet_bottles_box_icon_153191;
            pictureBox1.Location = new Point(41, 3);
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
            btnToModify.BackColor = Color.Orange;
            btnToModify.Enabled = false;
            btnToModify.FlatStyle = FlatStyle.Popup;
            btnToModify.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToModify.ForeColor = Color.Red;
            btnToModify.Location = new Point(10, 218);
            btnToModify.Name = "btnToModify";
            btnToModify.Size = new Size(175, 32);
            btnToModify.TabIndex = 2;
            btnToModify.Text = "Menù Modifica";
            btnToModify.TextAlign = ContentAlignment.MiddleRight;
            btnToModify.UseMnemonic = false;
            btnToModify.UseVisualStyleBackColor = false;
            // 
            // btnToCatalogue
            // 
            btnToCatalogue.BackColor = Color.Wheat;
            btnToCatalogue.FlatStyle = FlatStyle.Popup;
            btnToCatalogue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToCatalogue.ForeColor = Color.Red;
            btnToCatalogue.Location = new Point(10, 178);
            btnToCatalogue.Name = "btnToCatalogue";
            btnToCatalogue.Size = new Size(175, 34);
            btnToCatalogue.TabIndex = 1;
            btnToCatalogue.Text = "Catalogo";
            btnToCatalogue.TextAlign = ContentAlignment.MiddleRight;
            btnToCatalogue.UseMnemonic = false;
            btnToCatalogue.UseVisualStyleBackColor = false;
            btnToCatalogue.Click += btnToCatalogue_Click;
            // 
            // btnToShelf
            // 
            btnToShelf.BackColor = Color.Wheat;
            btnToShelf.FlatStyle = FlatStyle.Popup;
            btnToShelf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToShelf.ForeColor = Color.Red;
            btnToShelf.Location = new Point(10, 138);
            btnToShelf.Name = "btnToShelf";
            btnToShelf.Size = new Size(175, 34);
            btnToShelf.TabIndex = 0;
            btnToShelf.Text = "Cantina";
            btnToShelf.TextAlign = ContentAlignment.MiddleRight;
            btnToShelf.UseMnemonic = false;
            btnToShelf.UseVisualStyleBackColor = false;
            btnToShelf.Click += btnToShelf_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.AntiqueWhite;
            lblQuantity.ForeColor = Color.IndianRed;
            lblQuantity.Location = new Point(503, 276);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(45, 23);
            lblQuantity.TabIndex = 47;
            // 
            // stockText
            // 
            stockText.BackColor = Color.AntiqueWhite;
            stockText.ForeColor = Color.IndianRed;
            stockText.Location = new Point(271, 280);
            stockText.Name = "stockText";
            stockText.ReadOnly = true;
            stockText.Size = new Size(45, 23);
            stockText.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(82, 278);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 45;
            label3.Text = "Quantità in magazzino:";
            // 
            // cellarLocationTextBox
            // 
            cellarLocationTextBox.BackColor = Color.AntiqueWhite;
            cellarLocationTextBox.ForeColor = Color.IndianRed;
            cellarLocationTextBox.Location = new Point(271, 333);
            cellarLocationTextBox.Name = "cellarLocationTextBox";
            cellarLocationTextBox.ReadOnly = true;
            cellarLocationTextBox.Size = new Size(278, 23);
            cellarLocationTextBox.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(82, 331);
            label7.Name = "label7";
            label7.Size = new Size(173, 21);
            label7.TabIndex = 38;
            label7.Text = "Posizione in Magazzino:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(322, 278);
            label8.Name = "label8";
            label8.Size = new Size(175, 21);
            label8.TabIndex = 37;
            label8.Text = "Quantità da modificare:";
            // 
            // btnRemoveBottle
            // 
            btnRemoveBottle.BackColor = Color.SandyBrown;
            btnRemoveBottle.FlatStyle = FlatStyle.Popup;
            btnRemoveBottle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveBottle.ForeColor = Color.Red;
            btnRemoveBottle.Location = new Point(322, 406);
            btnRemoveBottle.Name = "btnRemoveBottle";
            btnRemoveBottle.Size = new Size(197, 39);
            btnRemoveBottle.TabIndex = 34;
            btnRemoveBottle.Text = "Rimuovi quantità selezionata";
            btnRemoveBottle.UseMnemonic = false;
            btnRemoveBottle.UseVisualStyleBackColor = false;
            btnRemoveBottle.Click += btnRemoveBottle_Click;
            // 
            // btnAddBottle
            // 
            btnAddBottle.BackColor = Color.SandyBrown;
            btnAddBottle.FlatStyle = FlatStyle.Popup;
            btnAddBottle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBottle.ForeColor = Color.Red;
            btnAddBottle.Location = new Point(108, 406);
            btnAddBottle.Name = "btnAddBottle";
            btnAddBottle.Size = new Size(197, 39);
            btnAddBottle.TabIndex = 33;
            btnAddBottle.Text = "Aggiungi quantità selezionata\r\n";
            btnAddBottle.UseMnemonic = false;
            btnAddBottle.UseVisualStyleBackColor = false;
            btnAddBottle.Click += btnAddBottle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(86, 121);
            label6.Name = "label6";
            label6.Size = new Size(165, 21);
            label6.TabIndex = 32;
            label6.Text = "Bottiglia selezionata:";
            // 
            // btnToAnother
            // 
            btnToAnother.BackColor = Color.SandyBrown;
            btnToAnother.FlatStyle = FlatStyle.Popup;
            btnToAnother.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnToAnother.ForeColor = Color.Red;
            btnToAnother.Location = new Point(384, 510);
            btnToAnother.Name = "btnToAnother";
            btnToAnother.Size = new Size(197, 39);
            btnToAnother.TabIndex = 31;
            btnToAnother.Text = "Seleziona un'altra bottiglia";
            btnToAnother.UseMnemonic = false;
            btnToAnother.UseVisualStyleBackColor = false;
            btnToAnother.Click += btnToAnother_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.AntiqueWhite;
            nameTextBox.ForeColor = Color.IndianRed;
            nameTextBox.Location = new Point(271, 174);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(278, 23);
            nameTextBox.TabIndex = 30;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.AntiqueWhite;
            yearTextBox.ForeColor = Color.IndianRed;
            yearTextBox.Location = new Point(271, 227);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.ReadOnly = true;
            yearTextBox.Size = new Size(278, 23);
            yearTextBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(82, 225);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 26;
            label5.Text = "Anno di produzione:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(82, 172);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 23;
            label2.Text = "Nome in etichetta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Aggiungi o Rimuovi ";
            // 
            // removeAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(doublePanelContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "removeAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += removeAddForm_FormClosing;
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
        private PictureBox pictureBox1;
        private Button button7;
        private Button btnToModify;
        private Button btnToCatalogue;
        private Button btnToShelf;
        private Label label1;
        private Button btnModify;
        private Button btnAddRem;
        private Button btnAddBottle;
        private Label label6;
        private Button btnToAnother;
        private TextBox nameTextBox;
        private TextBox yearTextBox;
        private Label label5;
        private Label label2;
        private Button btnRemoveBottle;
        private TextBox cellarLocationTextBox;
        private Label label7;
        private Label label8;
        private Button btnToMain;
        private Label label3;
        private TextBox stockText;
        private Button btnCreate;
        private TextBox lblQuantity;
    }
}