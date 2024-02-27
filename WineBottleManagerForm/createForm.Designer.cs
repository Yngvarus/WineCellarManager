namespace WineBottleManagerForm
{
    partial class createForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createForm));
            btnToMain = new Button();
            btnModify = new Button();
            btnAddRem = new Button();
            btnToModify = new Button();
            btnToShelf = new Button();
            doublePanelContainer = new SplitContainer();
            btnCreate = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            btnToCatalogue = new Button();
            btnCreateBottle = new Button();
            tastingTextBox = new TextBox();
            sellingTextBox = new TextBox();
            buyingTextBox = new TextBox();
            cellarLocationTextBox = new TextBox();
            nameTextBox = new TextBox();
            stockTextBox = new TextBox();
            vineyardTextBox = new TextBox();
            locationTextBox = new TextBox();
            yearTextBox = new TextBox();
            styleTextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).BeginInit();
            doublePanelContainer.Panel1.SuspendLayout();
            doublePanelContainer.Panel2.SuspendLayout();
            doublePanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnToMain
            // 
            btnToMain.BackColor = Color.Wheat;
            btnToMain.FlatStyle = FlatStyle.Popup;
            btnToMain.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToMain.ForeColor = Color.Red;
            btnToMain.Location = new Point(8, 103);
            btnToMain.Name = "btnToMain";
            btnToMain.Size = new Size(175, 32);
            btnToMain.TabIndex = 13;
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
            btnModify.Location = new Point(39, 295);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(144, 32);
            btnModify.TabIndex = 12;
            btnModify.Text = "Modifica Bottiglie";
            btnModify.TextAlign = ContentAlignment.MiddleRight;
            btnModify.UseMnemonic = false;
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnAddRem
            // 
            btnAddRem.BackColor = Color.Orange;
            btnAddRem.FlatStyle = FlatStyle.Popup;
            btnAddRem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddRem.ForeColor = Color.Red;
            btnAddRem.Location = new Point(39, 257);
            btnAddRem.Name = "btnAddRem";
            btnAddRem.Size = new Size(144, 32);
            btnAddRem.TabIndex = 11;
            btnAddRem.Text = "Agg./Rimuov.";
            btnAddRem.TextAlign = ContentAlignment.MiddleRight;
            btnAddRem.UseMnemonic = false;
            btnAddRem.UseVisualStyleBackColor = false;
            btnAddRem.Click += btnAddRem_Click;
            // 
            // btnToModify
            // 
            btnToModify.BackColor = Color.Orange;
            btnToModify.Enabled = false;
            btnToModify.FlatStyle = FlatStyle.Popup;
            btnToModify.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToModify.ForeColor = Color.Red;
            btnToModify.Location = new Point(8, 219);
            btnToModify.Name = "btnToModify";
            btnToModify.Size = new Size(175, 32);
            btnToModify.TabIndex = 10;
            btnToModify.Text = "Menù Modifica";
            btnToModify.TextAlign = ContentAlignment.MiddleRight;
            btnToModify.UseMnemonic = false;
            btnToModify.UseVisualStyleBackColor = false;
            // 
            // btnToShelf
            // 
            btnToShelf.BackColor = Color.Wheat;
            btnToShelf.FlatStyle = FlatStyle.Popup;
            btnToShelf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToShelf.ForeColor = Color.Red;
            btnToShelf.Location = new Point(8, 139);
            btnToShelf.Name = "btnToShelf";
            btnToShelf.Size = new Size(175, 34);
            btnToShelf.TabIndex = 8;
            btnToShelf.Text = "Cantina";
            btnToShelf.TextAlign = ContentAlignment.MiddleRight;
            btnToShelf.UseMnemonic = false;
            btnToShelf.UseVisualStyleBackColor = false;
            btnToShelf.Click += btnToShelf_Click;
            // 
            // doublePanelContainer
            // 
            doublePanelContainer.Dock = DockStyle.Fill;
            doublePanelContainer.FixedPanel = FixedPanel.Panel1;
            doublePanelContainer.Location = new Point(0, 0);
            doublePanelContainer.Name = "doublePanelContainer";
            // 
            // doublePanelContainer.Panel1
            // 
            doublePanelContainer.Panel1.BackColor = Color.Wheat;
            doublePanelContainer.Panel1.Controls.Add(btnCreate);
            doublePanelContainer.Panel1.Controls.Add(btnToMain);
            doublePanelContainer.Panel1.Controls.Add(btnModify);
            doublePanelContainer.Panel1.Controls.Add(pictureBox1);
            doublePanelContainer.Panel1.Controls.Add(btnAddRem);
            doublePanelContainer.Panel1.Controls.Add(button7);
            doublePanelContainer.Panel1.Controls.Add(btnToModify);
            doublePanelContainer.Panel1.Controls.Add(btnToShelf);
            doublePanelContainer.Panel1.Controls.Add(btnToCatalogue);
            // 
            // doublePanelContainer.Panel2
            // 
            doublePanelContainer.Panel2.BackColor = Color.Peru;
            doublePanelContainer.Panel2.Controls.Add(btnCreateBottle);
            doublePanelContainer.Panel2.Controls.Add(tastingTextBox);
            doublePanelContainer.Panel2.Controls.Add(sellingTextBox);
            doublePanelContainer.Panel2.Controls.Add(buyingTextBox);
            doublePanelContainer.Panel2.Controls.Add(cellarLocationTextBox);
            doublePanelContainer.Panel2.Controls.Add(nameTextBox);
            doublePanelContainer.Panel2.Controls.Add(stockTextBox);
            doublePanelContainer.Panel2.Controls.Add(vineyardTextBox);
            doublePanelContainer.Panel2.Controls.Add(locationTextBox);
            doublePanelContainer.Panel2.Controls.Add(yearTextBox);
            doublePanelContainer.Panel2.Controls.Add(styleTextBox);
            doublePanelContainer.Panel2.Controls.Add(label10);
            doublePanelContainer.Panel2.Controls.Add(label11);
            doublePanelContainer.Panel2.Controls.Add(label6);
            doublePanelContainer.Panel2.Controls.Add(label7);
            doublePanelContainer.Panel2.Controls.Add(label8);
            doublePanelContainer.Panel2.Controls.Add(label9);
            doublePanelContainer.Panel2.Controls.Add(label5);
            doublePanelContainer.Panel2.Controls.Add(label4);
            doublePanelContainer.Panel2.Controls.Add(label3);
            doublePanelContainer.Panel2.Controls.Add(label2);
            doublePanelContainer.Panel2.Controls.Add(label1);
            doublePanelContainer.Size = new Size(784, 561);
            doublePanelContainer.SplitterDistance = 186;
            doublePanelContainer.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Peru;
            btnCreate.Enabled = false;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Red;
            btnCreate.Location = new Point(39, 333);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 32);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Crea Bottiglie";
            btnCreate.TextAlign = ContentAlignment.MiddleRight;
            btnCreate.UseMnemonic = false;
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.design_package_packet_bottles_box_icon_153191;
            pictureBox1.Location = new Point(39, 4);
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
            // btnToCatalogue
            // 
            btnToCatalogue.BackColor = Color.Wheat;
            btnToCatalogue.FlatStyle = FlatStyle.Popup;
            btnToCatalogue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnToCatalogue.ForeColor = Color.Red;
            btnToCatalogue.Location = new Point(8, 179);
            btnToCatalogue.Name = "btnToCatalogue";
            btnToCatalogue.Size = new Size(175, 34);
            btnToCatalogue.TabIndex = 9;
            btnToCatalogue.Text = "Catalogo";
            btnToCatalogue.TextAlign = ContentAlignment.MiddleRight;
            btnToCatalogue.UseMnemonic = false;
            btnToCatalogue.UseVisualStyleBackColor = false;
            btnToCatalogue.Click += btnToCatalogue_Click;
            // 
            // btnCreateBottle
            // 
            btnCreateBottle.BackColor = Color.SandyBrown;
            btnCreateBottle.FlatStyle = FlatStyle.Popup;
            btnCreateBottle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateBottle.ForeColor = Color.Red;
            btnCreateBottle.Location = new Point(385, 510);
            btnCreateBottle.Name = "btnCreateBottle";
            btnCreateBottle.Size = new Size(197, 39);
            btnCreateBottle.TabIndex = 20;
            btnCreateBottle.Text = "Crea nuova bottiglia";
            btnCreateBottle.UseMnemonic = false;
            btnCreateBottle.UseVisualStyleBackColor = false;
            btnCreateBottle.Click += btnCreateBottle_Click;
            // 
            // tastingTextBox
            // 
            tastingTextBox.BackColor = Color.AntiqueWhite;
            tastingTextBox.ForeColor = Color.IndianRed;
            tastingTextBox.Location = new Point(304, 401);
            tastingTextBox.Multiline = true;
            tastingTextBox.Name = "tastingTextBox";
            tastingTextBox.Size = new Size(278, 96);
            tastingTextBox.TabIndex = 19;
            // 
            // sellingTextBox
            // 
            sellingTextBox.BackColor = Color.AntiqueWhite;
            sellingTextBox.ForeColor = Color.IndianRed;
            sellingTextBox.Location = new Point(304, 364);
            sellingTextBox.Name = "sellingTextBox";
            sellingTextBox.Size = new Size(278, 23);
            sellingTextBox.TabIndex = 18;
            // 
            // buyingTextBox
            // 
            buyingTextBox.BackColor = Color.AntiqueWhite;
            buyingTextBox.ForeColor = Color.IndianRed;
            buyingTextBox.Location = new Point(304, 327);
            buyingTextBox.Name = "buyingTextBox";
            buyingTextBox.Size = new Size(278, 23);
            buyingTextBox.TabIndex = 17;
            // 
            // cellarLocationTextBox
            // 
            cellarLocationTextBox.BackColor = Color.AntiqueWhite;
            cellarLocationTextBox.ForeColor = Color.IndianRed;
            cellarLocationTextBox.Location = new Point(304, 290);
            cellarLocationTextBox.Name = "cellarLocationTextBox";
            cellarLocationTextBox.Size = new Size(278, 23);
            cellarLocationTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.AntiqueWhite;
            nameTextBox.ForeColor = Color.IndianRed;
            nameTextBox.Location = new Point(304, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(278, 23);
            nameTextBox.TabIndex = 15;
            // 
            // stockTextBox
            // 
            stockTextBox.BackColor = Color.AntiqueWhite;
            stockTextBox.ForeColor = Color.IndianRed;
            stockTextBox.Location = new Point(304, 253);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(278, 23);
            stockTextBox.TabIndex = 15;
            // 
            // vineyardTextBox
            // 
            vineyardTextBox.BackColor = Color.AntiqueWhite;
            vineyardTextBox.ForeColor = Color.IndianRed;
            vineyardTextBox.Location = new Point(304, 105);
            vineyardTextBox.Name = "vineyardTextBox";
            vineyardTextBox.Size = new Size(278, 23);
            vineyardTextBox.TabIndex = 14;
            // 
            // locationTextBox
            // 
            locationTextBox.BackColor = Color.AntiqueWhite;
            locationTextBox.ForeColor = Color.IndianRed;
            locationTextBox.Location = new Point(304, 142);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(278, 23);
            locationTextBox.TabIndex = 13;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.AntiqueWhite;
            yearTextBox.ForeColor = Color.IndianRed;
            yearTextBox.Location = new Point(304, 179);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(278, 23);
            yearTextBox.TabIndex = 12;
            // 
            // styleTextBox
            // 
            styleTextBox.BackColor = Color.AntiqueWhite;
            styleTextBox.ForeColor = Color.IndianRed;
            styleTextBox.Location = new Point(304, 216);
            styleTextBox.Name = "styleTextBox";
            styleTextBox.Size = new Size(278, 23);
            styleTextBox.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(38, 362);
            label10.Name = "label10";
            label10.Size = new Size(131, 21);
            label10.TabIndex = 10;
            label10.Text = "Prezzo di vendita:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(38, 325);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 9;
            label11.Text = "Prezzo acquisto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(38, 288);
            label6.Name = "label6";
            label6.Size = new Size(173, 21);
            label6.TabIndex = 8;
            label6.Text = "Posizione in Magazzino:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(38, 251);
            label7.Name = "label7";
            label7.Size = new Size(173, 21);
            label7.TabIndex = 7;
            label7.Text = "Quantità in magazzino:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(38, 399);
            label8.Name = "label8";
            label8.Size = new Size(187, 21);
            label8.TabIndex = 6;
            label8.Text = "Note(Colore, sapore etc.): ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(38, 214);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 5;
            label9.Text = "Stile:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(38, 177);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 4;
            label5.Text = "Anno di produzione:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(38, 140);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 3;
            label4.Text = "Luogo di origine:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(38, 103);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 2;
            label3.Text = "Vigneto di produzione:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(38, 66);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome in etichetta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 0;
            label1.Text = "Crea nuova bottiglia";
            // 
            // createForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(doublePanelContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "createForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crea Nuova Bottiglia";
            FormClosing += createForm_FormClosing;
            doublePanelContainer.Panel1.ResumeLayout(false);
            doublePanelContainer.Panel2.ResumeLayout(false);
            doublePanelContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).EndInit();
            doublePanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnToMain;
        private Button btnModify;
        private Button btnAddRem;
        private Button btnToModify;
        private Button btnToShelf;
        private SplitContainer doublePanelContainer;
        private Button btnCreate;
        private PictureBox pictureBox1;
        private Button button7;
        private Button btnToCatalogue;
        private Button btnCreateBottle;
        private TextBox tastingTextBox;
        private TextBox sellingTextBox;
        private TextBox buyingTextBox;
        private TextBox cellarLocationTextBox;
        private TextBox nameTextBox;
        private TextBox stockTextBox;
        private TextBox vineyardTextBox;
        private TextBox locationTextBox;
        private TextBox yearTextBox;
        private TextBox styleTextBox;
        private Label label10;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}