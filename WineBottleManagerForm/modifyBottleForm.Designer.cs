namespace WineBottleManagerForm
{
    partial class modifyBottleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyBottleForm));
            btnAnotherBottle = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            doublePanelContainer = new SplitContainer();
            btnCreate = new Button();
            btnToMain = new Button();
            btnModify = new Button();
            btnAddRem = new Button();
            btnToModify = new Button();
            btnToShelf = new Button();
            btnToCatalogue = new Button();
            tastingTextBox = new TextBox();
            sellingTextBox = new TextBox();
            btnChangeBottle = new Button();
            buyingTextBox = new TextBox();
            cellarLocationTextBox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            stockTextBox = new TextBox();
            label3 = new Label();
            vineyardTextBox = new TextBox();
            label4 = new Label();
            locationTextBox = new TextBox();
            label5 = new Label();
            yearTextBox = new TextBox();
            label9 = new Label();
            styleTextBox = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label11 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).BeginInit();
            doublePanelContainer.Panel1.SuspendLayout();
            doublePanelContainer.Panel2.SuspendLayout();
            doublePanelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnotherBottle
            // 
            btnAnotherBottle.BackColor = Color.SandyBrown;
            btnAnotherBottle.FlatStyle = FlatStyle.Popup;
            btnAnotherBottle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnotherBottle.ForeColor = Color.Red;
            btnAnotherBottle.Location = new Point(380, 510);
            btnAnotherBottle.Name = "btnAnotherBottle";
            btnAnotherBottle.Size = new Size(201, 39);
            btnAnotherBottle.TabIndex = 22;
            btnAnotherBottle.Text = "Seleziona un'altra bottiglia";
            btnAnotherBottle.UseMnemonic = false;
            btnAnotherBottle.UseVisualStyleBackColor = false;
            btnAnotherBottle.Click += btnAnotherBottle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Modifica";
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
            doublePanelContainer.Panel2.Controls.Add(tastingTextBox);
            doublePanelContainer.Panel2.Controls.Add(sellingTextBox);
            doublePanelContainer.Panel2.Controls.Add(btnChangeBottle);
            doublePanelContainer.Panel2.Controls.Add(buyingTextBox);
            doublePanelContainer.Panel2.Controls.Add(btnAnotherBottle);
            doublePanelContainer.Panel2.Controls.Add(cellarLocationTextBox);
            doublePanelContainer.Panel2.Controls.Add(label1);
            doublePanelContainer.Panel2.Controls.Add(nameTextBox);
            doublePanelContainer.Panel2.Controls.Add(label2);
            doublePanelContainer.Panel2.Controls.Add(stockTextBox);
            doublePanelContainer.Panel2.Controls.Add(label3);
            doublePanelContainer.Panel2.Controls.Add(vineyardTextBox);
            doublePanelContainer.Panel2.Controls.Add(label4);
            doublePanelContainer.Panel2.Controls.Add(locationTextBox);
            doublePanelContainer.Panel2.Controls.Add(label5);
            doublePanelContainer.Panel2.Controls.Add(yearTextBox);
            doublePanelContainer.Panel2.Controls.Add(label9);
            doublePanelContainer.Panel2.Controls.Add(styleTextBox);
            doublePanelContainer.Panel2.Controls.Add(label8);
            doublePanelContainer.Panel2.Controls.Add(label10);
            doublePanelContainer.Panel2.Controls.Add(label7);
            doublePanelContainer.Panel2.Controls.Add(label11);
            doublePanelContainer.Panel2.Controls.Add(label6);
            doublePanelContainer.Size = new Size(784, 561);
            doublePanelContainer.SplitterDistance = 187;
            doublePanelContainer.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Orange;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Red;
            btnCreate.Location = new Point(39, 333);
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
            btnModify.BackColor = Color.Peru;
            btnModify.Enabled = false;
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
            // tastingTextBox
            // 
            tastingTextBox.BackColor = Color.AntiqueWhite;
            tastingTextBox.ForeColor = Color.IndianRed;
            tastingTextBox.Location = new Point(303, 394);
            tastingTextBox.Multiline = true;
            tastingTextBox.Name = "tastingTextBox";
            tastingTextBox.Size = new Size(278, 96);
            tastingTextBox.TabIndex = 39;
            // 
            // sellingTextBox
            // 
            sellingTextBox.BackColor = Color.AntiqueWhite;
            sellingTextBox.ForeColor = Color.IndianRed;
            sellingTextBox.Location = new Point(303, 357);
            sellingTextBox.Name = "sellingTextBox";
            sellingTextBox.Size = new Size(278, 23);
            sellingTextBox.TabIndex = 38;
            // 
            // btnChangeBottle
            // 
            btnChangeBottle.BackColor = Color.SandyBrown;
            btnChangeBottle.FlatStyle = FlatStyle.Popup;
            btnChangeBottle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeBottle.ForeColor = Color.Red;
            btnChangeBottle.Location = new Point(177, 510);
            btnChangeBottle.Name = "btnChangeBottle";
            btnChangeBottle.Size = new Size(197, 39);
            btnChangeBottle.TabIndex = 23;
            btnChangeBottle.Text = "Modifica bottiglia selezionata";
            btnChangeBottle.UseMnemonic = false;
            btnChangeBottle.UseVisualStyleBackColor = false;
            btnChangeBottle.Click += btnChangeBottle_Click;
            // 
            // buyingTextBox
            // 
            buyingTextBox.BackColor = Color.AntiqueWhite;
            buyingTextBox.ForeColor = Color.IndianRed;
            buyingTextBox.Location = new Point(303, 320);
            buyingTextBox.Name = "buyingTextBox";
            buyingTextBox.Size = new Size(278, 23);
            buyingTextBox.TabIndex = 37;
            // 
            // cellarLocationTextBox
            // 
            cellarLocationTextBox.BackColor = Color.AntiqueWhite;
            cellarLocationTextBox.ForeColor = Color.IndianRed;
            cellarLocationTextBox.Location = new Point(303, 283);
            cellarLocationTextBox.Name = "cellarLocationTextBox";
            cellarLocationTextBox.Size = new Size(278, 23);
            cellarLocationTextBox.TabIndex = 36;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.AntiqueWhite;
            nameTextBox.ForeColor = Color.IndianRed;
            nameTextBox.Location = new Point(303, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(278, 23);
            nameTextBox.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 20;
            label2.Text = "Nome in etichetta:";
            // 
            // stockTextBox
            // 
            stockTextBox.BackColor = Color.AntiqueWhite;
            stockTextBox.ForeColor = Color.IndianRed;
            stockTextBox.Location = new Point(303, 246);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(278, 23);
            stockTextBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(36, 96);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 21;
            label3.Text = "Vigneto di produzione:";
            // 
            // vineyardTextBox
            // 
            vineyardTextBox.BackColor = Color.AntiqueWhite;
            vineyardTextBox.ForeColor = Color.IndianRed;
            vineyardTextBox.Location = new Point(303, 98);
            vineyardTextBox.Name = "vineyardTextBox";
            vineyardTextBox.Size = new Size(278, 23);
            vineyardTextBox.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(36, 133);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 22;
            label4.Text = "Luogo di origine:";
            // 
            // locationTextBox
            // 
            locationTextBox.BackColor = Color.AntiqueWhite;
            locationTextBox.ForeColor = Color.IndianRed;
            locationTextBox.Location = new Point(303, 135);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(278, 23);
            locationTextBox.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(36, 170);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 23;
            label5.Text = "Anno di produzione:";
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.AntiqueWhite;
            yearTextBox.ForeColor = Color.IndianRed;
            yearTextBox.Location = new Point(303, 172);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(278, 23);
            yearTextBox.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(36, 207);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 24;
            label9.Text = "Stile:";
            // 
            // styleTextBox
            // 
            styleTextBox.BackColor = Color.AntiqueWhite;
            styleTextBox.ForeColor = Color.IndianRed;
            styleTextBox.Location = new Point(303, 209);
            styleTextBox.Name = "styleTextBox";
            styleTextBox.Size = new Size(278, 23);
            styleTextBox.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(36, 392);
            label8.Name = "label8";
            label8.Size = new Size(187, 21);
            label8.TabIndex = 25;
            label8.Text = "Note(Colore, sapore etc.): ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(36, 355);
            label10.Name = "label10";
            label10.Size = new Size(131, 21);
            label10.TabIndex = 29;
            label10.Text = "Prezzo di vendita:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(36, 244);
            label7.Name = "label7";
            label7.Size = new Size(173, 21);
            label7.TabIndex = 26;
            label7.Text = "Quantità in magazzino:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(36, 318);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 28;
            label11.Text = "Prezzo acquisto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(36, 281);
            label6.Name = "label6";
            label6.Size = new Size(173, 21);
            label6.TabIndex = 27;
            label6.Text = "Posizione in Magazzino:";
            // 
            // modifyBottleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(doublePanelContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "modifyBottleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifica Bottiglia";
            FormClosed += modifyBottleForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            doublePanelContainer.Panel1.ResumeLayout(false);
            doublePanelContainer.Panel2.ResumeLayout(false);
            doublePanelContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doublePanelContainer).EndInit();
            doublePanelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnotherBottle;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button7;
        private SplitContainer doublePanelContainer;
        private Button btnToMain;
        private Button btnModify;
        private Button btnAddRem;
        private Button btnToModify;
        private Button btnToShelf;
        private Button btnToCatalogue;
        private Button btnChangeBottle;
        private Button btnCreate;
        private TextBox tastingTextBox;
        private TextBox sellingTextBox;
        private TextBox buyingTextBox;
        private TextBox cellarLocationTextBox;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox stockTextBox;
        private Label label3;
        private TextBox vineyardTextBox;
        private Label label4;
        private TextBox locationTextBox;
        private Label label5;
        private TextBox yearTextBox;
        private Label label9;
        private TextBox styleTextBox;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label11;
        private Label label6;
    }
}