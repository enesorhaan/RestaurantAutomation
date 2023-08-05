namespace RestaurantAutomation
{
    partial class Form1
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
            this.pbFlakedCheese = new System.Windows.Forms.PictureBox();
            this.pbMix = new System.Windows.Forms.PictureBox();
            this.pbSausage = new System.Windows.Forms.PictureBox();
            this.pbVegetables = new System.Windows.Forms.PictureBox();
            this.btnFlakedCheese = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnSausage = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFlakedPrice = new System.Windows.Forms.Label();
            this.lblMixPrice = new System.Windows.Forms.Label();
            this.lblSausagePrice = new System.Windows.Forms.Label();
            this.lblVegetablesPrice = new System.Windows.Forms.Label();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbMenus = new System.Windows.Forms.ComboBox();
            this.lblMnuCont = new System.Windows.Forms.Label();
            this.lblMnuPrc = new System.Windows.Forms.Label();
            this.lblMenuContents = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.lblAnotherBeverage = new System.Windows.Forms.Label();
            this.cbAnotherBeverage = new System.Windows.Forms.ComboBox();
            this.lblMnuNewPrc = new System.Windows.Forms.Label();
            this.lblMenuNewPrice = new System.Windows.Forms.Label();
            this.lblExBvrg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExtraBeverages = new System.Windows.Forms.ComboBox();
            this.nmrQty = new System.Windows.Forms.NumericUpDown();
            this.lbOrderContents = new System.Windows.Forms.ListBox();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnAddBeverage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.btnDesert = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.btnSauce = new System.Windows.Forms.Button();
            this.btnCrispyEdge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlakedCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSausage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQty)).BeginInit();
            this.gbExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFlakedCheese
            // 
            this.pbFlakedCheese.Location = new System.Drawing.Point(56, 132);
            this.pbFlakedCheese.Name = "pbFlakedCheese";
            this.pbFlakedCheese.Size = new System.Drawing.Size(200, 150);
            this.pbFlakedCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlakedCheese.TabIndex = 0;
            this.pbFlakedCheese.TabStop = false;
            // 
            // pbMix
            // 
            this.pbMix.Location = new System.Drawing.Point(326, 132);
            this.pbMix.Name = "pbMix";
            this.pbMix.Size = new System.Drawing.Size(200, 150);
            this.pbMix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMix.TabIndex = 0;
            this.pbMix.TabStop = false;
            // 
            // pbSausage
            // 
            this.pbSausage.Location = new System.Drawing.Point(56, 397);
            this.pbSausage.Name = "pbSausage";
            this.pbSausage.Size = new System.Drawing.Size(200, 150);
            this.pbSausage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSausage.TabIndex = 0;
            this.pbSausage.TabStop = false;
            // 
            // pbVegetables
            // 
            this.pbVegetables.Location = new System.Drawing.Point(326, 397);
            this.pbVegetables.Name = "pbVegetables";
            this.pbVegetables.Size = new System.Drawing.Size(200, 150);
            this.pbVegetables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVegetables.TabIndex = 0;
            this.pbVegetables.TabStop = false;
            // 
            // btnFlakedCheese
            // 
            this.btnFlakedCheese.Location = new System.Drawing.Point(56, 326);
            this.btnFlakedCheese.Name = "btnFlakedCheese";
            this.btnFlakedCheese.Size = new System.Drawing.Size(200, 41);
            this.btnFlakedCheese.TabIndex = 1;
            this.btnFlakedCheese.Tag = "0";
            this.btnFlakedCheese.Text = "Add Pita Bread";
            this.btnFlakedCheese.UseVisualStyleBackColor = true;
            this.btnFlakedCheese.Visible = false;
            this.btnFlakedCheese.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(326, 326);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(200, 41);
            this.btnMix.TabIndex = 1;
            this.btnMix.Tag = "1";
            this.btnMix.Text = "Add Pita Bread";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Visible = false;
            this.btnMix.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // btnSausage
            // 
            this.btnSausage.Location = new System.Drawing.Point(56, 591);
            this.btnSausage.Name = "btnSausage";
            this.btnSausage.Size = new System.Drawing.Size(200, 41);
            this.btnSausage.TabIndex = 1;
            this.btnSausage.Tag = "2";
            this.btnSausage.Text = "Add Pita Bread";
            this.btnSausage.UseVisualStyleBackColor = true;
            this.btnSausage.Visible = false;
            this.btnSausage.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // btnVegetables
            // 
            this.btnVegetables.Location = new System.Drawing.Point(326, 591);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(200, 41);
            this.btnVegetables.TabIndex = 1;
            this.btnVegetables.Tag = "3";
            this.btnVegetables.Text = "Add Pita Bread";
            this.btnVegetables.UseVisualStyleBackColor = true;
            this.btnVegetables.Visible = false;
            this.btnVegetables.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(120, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 24);
            this.lblDate.TabIndex = 2;
            // 
            // lblFlakedPrice
            // 
            this.lblFlakedPrice.AutoSize = true;
            this.lblFlakedPrice.Location = new System.Drawing.Point(202, 287);
            this.lblFlakedPrice.Name = "lblFlakedPrice";
            this.lblFlakedPrice.Size = new System.Drawing.Size(0, 24);
            this.lblFlakedPrice.TabIndex = 3;
            // 
            // lblMixPrice
            // 
            this.lblMixPrice.AutoSize = true;
            this.lblMixPrice.Location = new System.Drawing.Point(472, 285);
            this.lblMixPrice.Name = "lblMixPrice";
            this.lblMixPrice.Size = new System.Drawing.Size(0, 24);
            this.lblMixPrice.TabIndex = 3;
            // 
            // lblSausagePrice
            // 
            this.lblSausagePrice.AutoSize = true;
            this.lblSausagePrice.Location = new System.Drawing.Point(202, 552);
            this.lblSausagePrice.Name = "lblSausagePrice";
            this.lblSausagePrice.Size = new System.Drawing.Size(0, 24);
            this.lblSausagePrice.TabIndex = 3;
            // 
            // lblVegetablesPrice
            // 
            this.lblVegetablesPrice.AutoSize = true;
            this.lblVegetablesPrice.Location = new System.Drawing.Point(472, 552);
            this.lblVegetablesPrice.Name = "lblVegetablesPrice";
            this.lblVegetablesPrice.Size = new System.Drawing.Size(0, 24);
            this.lblVegetablesPrice.TabIndex = 3;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(292, 71);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(180, 28);
            this.rbSingle.TabIndex = 4;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Singular Selection";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.Click += new System.EventHandler(this.rbSingle_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(728, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 28);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Menus";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbMenus
            // 
            this.cbMenus.Enabled = false;
            this.cbMenus.FormattingEnabled = true;
            this.cbMenus.Location = new System.Drawing.Point(689, 105);
            this.cbMenus.Name = "cbMenus";
            this.cbMenus.Size = new System.Drawing.Size(194, 32);
            this.cbMenus.TabIndex = 5;
            this.cbMenus.SelectedIndexChanged += new System.EventHandler(this.cbMenus_SelectedIndexChanged);
            // 
            // lblMnuCont
            // 
            this.lblMnuCont.AutoSize = true;
            this.lblMnuCont.Location = new System.Drawing.Point(532, 174);
            this.lblMnuCont.Name = "lblMnuCont";
            this.lblMnuCont.Size = new System.Drawing.Size(148, 24);
            this.lblMnuCont.TabIndex = 6;
            this.lblMnuCont.Text = "Menu Contents: ";
            this.lblMnuCont.Visible = false;
            // 
            // lblMnuPrc
            // 
            this.lblMnuPrc.AutoSize = true;
            this.lblMnuPrc.Location = new System.Drawing.Point(617, 208);
            this.lblMnuPrc.Name = "lblMnuPrc";
            this.lblMnuPrc.Size = new System.Drawing.Size(63, 24);
            this.lblMnuPrc.TabIndex = 6;
            this.lblMnuPrc.Text = "Price: ";
            this.lblMnuPrc.Visible = false;
            // 
            // lblMenuContents
            // 
            this.lblMenuContents.AutoSize = true;
            this.lblMenuContents.Location = new System.Drawing.Point(690, 174);
            this.lblMenuContents.Name = "lblMenuContents";
            this.lblMenuContents.Size = new System.Drawing.Size(0, 24);
            this.lblMenuContents.TabIndex = 6;
            this.lblMenuContents.Visible = false;
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Location = new System.Drawing.Point(690, 210);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(0, 24);
            this.lblMenuPrice.TabIndex = 6;
            this.lblMenuPrice.Visible = false;
            // 
            // lblAnotherBeverage
            // 
            this.lblAnotherBeverage.AutoSize = true;
            this.lblAnotherBeverage.Location = new System.Drawing.Point(961, 147);
            this.lblAnotherBeverage.Name = "lblAnotherBeverage";
            this.lblAnotherBeverage.Size = new System.Drawing.Size(163, 24);
            this.lblAnotherBeverage.TabIndex = 7;
            this.lblAnotherBeverage.Text = "Another Beverage";
            this.lblAnotherBeverage.Visible = false;
            // 
            // cbAnotherBeverage
            // 
            this.cbAnotherBeverage.FormattingEnabled = true;
            this.cbAnotherBeverage.Location = new System.Drawing.Point(965, 174);
            this.cbAnotherBeverage.Name = "cbAnotherBeverage";
            this.cbAnotherBeverage.Size = new System.Drawing.Size(159, 32);
            this.cbAnotherBeverage.TabIndex = 8;
            this.cbAnotherBeverage.Visible = false;
            this.cbAnotherBeverage.SelectedIndexChanged += new System.EventHandler(this.cbAnotherBeverage_SelectedIndexChanged);
            // 
            // lblMnuNewPrc
            // 
            this.lblMnuNewPrc.AutoSize = true;
            this.lblMnuNewPrc.Enabled = false;
            this.lblMnuNewPrc.Location = new System.Drawing.Point(573, 241);
            this.lblMnuNewPrc.Name = "lblMnuNewPrc";
            this.lblMnuNewPrc.Size = new System.Drawing.Size(107, 24);
            this.lblMnuNewPrc.TabIndex = 6;
            this.lblMnuNewPrc.Text = "New Price: ";
            this.lblMnuNewPrc.Visible = false;
            // 
            // lblMenuNewPrice
            // 
            this.lblMenuNewPrice.AutoSize = true;
            this.lblMenuNewPrice.Enabled = false;
            this.lblMenuNewPrice.Location = new System.Drawing.Point(690, 241);
            this.lblMenuNewPrice.Name = "lblMenuNewPrice";
            this.lblMenuNewPrice.Size = new System.Drawing.Size(0, 24);
            this.lblMenuNewPrice.TabIndex = 6;
            this.lblMenuNewPrice.Visible = false;
            // 
            // lblExBvrg
            // 
            this.lblExBvrg.AutoSize = true;
            this.lblExBvrg.Location = new System.Drawing.Point(810, 329);
            this.lblExBvrg.Name = "lblExBvrg";
            this.lblExBvrg.Size = new System.Drawing.Size(149, 24);
            this.lblExBvrg.TabIndex = 6;
            this.lblExBvrg.Text = "Extra Beverage: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity: ";
            // 
            // cbExtraBeverages
            // 
            this.cbExtraBeverages.FormattingEnabled = true;
            this.cbExtraBeverages.Location = new System.Drawing.Point(973, 326);
            this.cbExtraBeverages.Name = "cbExtraBeverages";
            this.cbExtraBeverages.Size = new System.Drawing.Size(194, 32);
            this.cbExtraBeverages.TabIndex = 9;
            // 
            // nmrQty
            // 
            this.nmrQty.Location = new System.Drawing.Point(973, 364);
            this.nmrQty.Name = "nmrQty";
            this.nmrQty.Size = new System.Drawing.Size(67, 29);
            this.nmrQty.TabIndex = 10;
            // 
            // lbOrderContents
            // 
            this.lbOrderContents.FormattingEnabled = true;
            this.lbOrderContents.ItemHeight = 24;
            this.lbOrderContents.Location = new System.Drawing.Point(541, 332);
            this.lbOrderContents.Name = "lbOrderContents";
            this.lbOrderContents.Size = new System.Drawing.Size(263, 244);
            this.lbOrderContents.TabIndex = 11;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(689, 268);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(197, 43);
            this.btnAddMenu.TabIndex = 12;
            this.btnAddMenu.Text = "Add Menu";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Visible = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnAddBeverage
            // 
            this.btnAddBeverage.Location = new System.Drawing.Point(975, 413);
            this.btnAddBeverage.Name = "btnAddBeverage";
            this.btnAddBeverage.Size = new System.Drawing.Size(197, 43);
            this.btnAddBeverage.TabIndex = 12;
            this.btnAddBeverage.Text = "Add Beverage";
            this.btnAddBeverage.UseVisualStyleBackColor = true;
            this.btnAddBeverage.Click += new System.EventHandler(this.btnAddBeverage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(577, 591);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 41);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(577, 638);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(200, 41);
            this.btnRemoveAll.TabIndex = 1;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(975, 591);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(197, 88);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Complete the Order";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(871, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(986, 564);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 24);
            this.lblTotalPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Flaked Cheese";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sausage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vegetables";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mix";
            // 
            // gbExtras
            // 
            this.gbExtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbExtras.Controls.Add(this.btnCrispyEdge);
            this.gbExtras.Controls.Add(this.btnDesert);
            this.gbExtras.Controls.Add(this.btnSauce);
            this.gbExtras.Controls.Add(this.btnCheese);
            this.gbExtras.Location = new System.Drawing.Point(814, 466);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(358, 95);
            this.gbExtras.TabIndex = 13;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras";
            // 
            // btnDesert
            // 
            this.btnDesert.Location = new System.Drawing.Point(6, 28);
            this.btnDesert.Name = "btnDesert";
            this.btnDesert.Size = new System.Drawing.Size(139, 29);
            this.btnDesert.TabIndex = 14;
            this.btnDesert.Text = "Desert";
            this.btnDesert.UseVisualStyleBackColor = true;
            this.btnDesert.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.Location = new System.Drawing.Point(203, 28);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(139, 29);
            this.btnCheese.TabIndex = 14;
            this.btnCheese.Text = "Cheese";
            this.btnCheese.UseVisualStyleBackColor = true;
            this.btnCheese.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnSauce
            // 
            this.btnSauce.Location = new System.Drawing.Point(6, 60);
            this.btnSauce.Name = "btnSauce";
            this.btnSauce.Size = new System.Drawing.Size(139, 29);
            this.btnSauce.TabIndex = 14;
            this.btnSauce.Text = "Sauce";
            this.btnSauce.UseVisualStyleBackColor = true;
            this.btnSauce.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnCrispyEdge
            // 
            this.btnCrispyEdge.Location = new System.Drawing.Point(203, 60);
            this.btnCrispyEdge.Name = "btnCrispyEdge";
            this.btnCrispyEdge.Size = new System.Drawing.Size(139, 29);
            this.btnCrispyEdge.TabIndex = 14;
            this.btnCrispyEdge.Text = "CrispyEdge";
            this.btnCrispyEdge.UseVisualStyleBackColor = true;
            this.btnCrispyEdge.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAddBeverage);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.lbOrderContents);
            this.Controls.Add(this.nmrQty);
            this.Controls.Add(this.cbExtraBeverages);
            this.Controls.Add(this.cbAnotherBeverage);
            this.Controls.Add(this.lblAnotherBeverage);
            this.Controls.Add(this.lblMenuPrice);
            this.Controls.Add(this.lblMenuNewPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExBvrg);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMnuNewPrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMnuPrc);
            this.Controls.Add(this.lblMenuContents);
            this.Controls.Add(this.lblMnuCont);
            this.Controls.Add(this.cbMenus);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbSingle);
            this.Controls.Add(this.lblVegetablesPrice);
            this.Controls.Add(this.lblSausagePrice);
            this.Controls.Add(this.lblMixPrice);
            this.Controls.Add(this.lblFlakedPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnVegetables);
            this.Controls.Add(this.btnSausage);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.btnFlakedCheese);
            this.Controls.Add(this.pbVegetables);
            this.Controls.Add(this.pbSausage);
            this.Controls.Add(this.pbMix);
            this.Controls.Add(this.pbFlakedCheese);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlakedCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSausage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQty)).EndInit();
            this.gbExtras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlakedCheese;
        private System.Windows.Forms.PictureBox pbMix;
        private System.Windows.Forms.PictureBox pbSausage;
        private System.Windows.Forms.PictureBox pbVegetables;
        private System.Windows.Forms.Button btnFlakedCheese;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnSausage;
        private System.Windows.Forms.Button btnVegetables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFlakedPrice;
        private System.Windows.Forms.Label lblMixPrice;
        private System.Windows.Forms.Label lblSausagePrice;
        private System.Windows.Forms.Label lblVegetablesPrice;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbMenus;
        private System.Windows.Forms.Label lblMnuCont;
        private System.Windows.Forms.Label lblMnuPrc;
        private System.Windows.Forms.Label lblMenuContents;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.Label lblAnotherBeverage;
        private System.Windows.Forms.ComboBox cbAnotherBeverage;
        private System.Windows.Forms.Label lblMnuNewPrc;
        private System.Windows.Forms.Label lblMenuNewPrice;
        private System.Windows.Forms.Label lblExBvrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbExtraBeverages;
        private System.Windows.Forms.NumericUpDown nmrQty;
        private System.Windows.Forms.ListBox lbOrderContents;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnAddBeverage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.Button btnCrispyEdge;
        private System.Windows.Forms.Button btnDesert;
        private System.Windows.Forms.Button btnSauce;
        private System.Windows.Forms.Button btnCheese;
    }
}

