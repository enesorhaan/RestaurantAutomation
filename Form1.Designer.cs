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
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.btnCrispyEdge = new System.Windows.Forms.Button();
            this.btnDesert = new System.Windows.Forms.Button();
            this.btnSauce = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbMenuSelection = new System.Windows.Forms.GroupBox();
            this.gbSingular = new System.Windows.Forms.GroupBox();
            this.gbExtraBeverage = new System.Windows.Forms.GroupBox();
            this.gbOrderList = new System.Windows.Forms.GroupBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.pbVegetables = new System.Windows.Forms.PictureBox();
            this.pbSausage = new System.Windows.Forms.PictureBox();
            this.pbMix = new System.Windows.Forms.PictureBox();
            this.pbFlakedCheese = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQty)).BeginInit();
            this.gbExtras.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.gbMenuSelection.SuspendLayout();
            this.gbSingular.SuspendLayout();
            this.gbExtraBeverage.SuspendLayout();
            this.gbOrderList.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSausage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlakedCheese)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlakedCheese
            // 
            this.btnFlakedCheese.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFlakedCheese.Location = new System.Drawing.Point(19, 241);
            this.btnFlakedCheese.Name = "btnFlakedCheese";
            this.btnFlakedCheese.Size = new System.Drawing.Size(200, 41);
            this.btnFlakedCheese.TabIndex = 1;
            this.btnFlakedCheese.Tag = "0";
            this.btnFlakedCheese.Text = "Add Pita Bread";
            this.btnFlakedCheese.UseVisualStyleBackColor = false;
            this.btnFlakedCheese.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMix.Location = new System.Drawing.Point(289, 241);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(200, 41);
            this.btnMix.TabIndex = 1;
            this.btnMix.Tag = "1";
            this.btnMix.Text = "Add Pita Bread";
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // btnSausage
            // 
            this.btnSausage.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSausage.Location = new System.Drawing.Point(19, 506);
            this.btnSausage.Name = "btnSausage";
            this.btnSausage.Size = new System.Drawing.Size(200, 41);
            this.btnSausage.TabIndex = 1;
            this.btnSausage.Tag = "2";
            this.btnSausage.Text = "Add Pita Bread";
            this.btnSausage.UseVisualStyleBackColor = false;
            this.btnSausage.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // btnVegetables
            // 
            this.btnVegetables.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVegetables.Location = new System.Drawing.Point(289, 506);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(200, 41);
            this.btnVegetables.TabIndex = 1;
            this.btnVegetables.Tag = "3";
            this.btnVegetables.Text = "Add Pita Bread";
            this.btnVegetables.UseVisualStyleBackColor = false;
            this.btnVegetables.Click += new System.EventHandler(this.btnFlakedCheese_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(76, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 24);
            this.lblDate.TabIndex = 2;
            // 
            // lblFlakedPrice
            // 
            this.lblFlakedPrice.AutoSize = true;
            this.lblFlakedPrice.BackColor = System.Drawing.Color.LightBlue;
            this.lblFlakedPrice.Location = new System.Drawing.Point(165, 202);
            this.lblFlakedPrice.Name = "lblFlakedPrice";
            this.lblFlakedPrice.Size = new System.Drawing.Size(0, 24);
            this.lblFlakedPrice.TabIndex = 3;
            // 
            // lblMixPrice
            // 
            this.lblMixPrice.AutoSize = true;
            this.lblMixPrice.BackColor = System.Drawing.Color.LightBlue;
            this.lblMixPrice.Location = new System.Drawing.Point(435, 200);
            this.lblMixPrice.Name = "lblMixPrice";
            this.lblMixPrice.Size = new System.Drawing.Size(0, 24);
            this.lblMixPrice.TabIndex = 3;
            // 
            // lblSausagePrice
            // 
            this.lblSausagePrice.AutoSize = true;
            this.lblSausagePrice.BackColor = System.Drawing.Color.LightBlue;
            this.lblSausagePrice.Location = new System.Drawing.Point(165, 467);
            this.lblSausagePrice.Name = "lblSausagePrice";
            this.lblSausagePrice.Size = new System.Drawing.Size(0, 24);
            this.lblSausagePrice.TabIndex = 3;
            // 
            // lblVegetablesPrice
            // 
            this.lblVegetablesPrice.AutoSize = true;
            this.lblVegetablesPrice.BackColor = System.Drawing.Color.LightBlue;
            this.lblVegetablesPrice.Location = new System.Drawing.Point(435, 467);
            this.lblVegetablesPrice.Name = "lblVegetablesPrice";
            this.lblVegetablesPrice.Size = new System.Drawing.Size(0, 24);
            this.lblVegetablesPrice.TabIndex = 3;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(270, 15);
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
            this.radioButton2.Location = new System.Drawing.Point(706, 15);
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
            this.cbMenus.Location = new System.Drawing.Point(182, 25);
            this.cbMenus.Name = "cbMenus";
            this.cbMenus.Size = new System.Drawing.Size(194, 32);
            this.cbMenus.TabIndex = 5;
            this.cbMenus.SelectedIndexChanged += new System.EventHandler(this.cbMenus_SelectedIndexChanged);
            // 
            // lblMnuCont
            // 
            this.lblMnuCont.AutoSize = true;
            this.lblMnuCont.Location = new System.Drawing.Point(25, 60);
            this.lblMnuCont.Name = "lblMnuCont";
            this.lblMnuCont.Size = new System.Drawing.Size(148, 24);
            this.lblMnuCont.TabIndex = 6;
            this.lblMnuCont.Text = "Menu Contents: ";
            // 
            // lblMnuPrc
            // 
            this.lblMnuPrc.AutoSize = true;
            this.lblMnuPrc.Location = new System.Drawing.Point(110, 94);
            this.lblMnuPrc.Name = "lblMnuPrc";
            this.lblMnuPrc.Size = new System.Drawing.Size(63, 24);
            this.lblMnuPrc.TabIndex = 6;
            this.lblMnuPrc.Text = "Price: ";
            // 
            // lblMenuContents
            // 
            this.lblMenuContents.AutoSize = true;
            this.lblMenuContents.Location = new System.Drawing.Point(183, 60);
            this.lblMenuContents.Name = "lblMenuContents";
            this.lblMenuContents.Size = new System.Drawing.Size(0, 24);
            this.lblMenuContents.TabIndex = 6;
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Location = new System.Drawing.Point(183, 96);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(0, 24);
            this.lblMenuPrice.TabIndex = 6;
            // 
            // lblAnotherBeverage
            // 
            this.lblAnotherBeverage.AutoSize = true;
            this.lblAnotherBeverage.Location = new System.Drawing.Point(454, 33);
            this.lblAnotherBeverage.Name = "lblAnotherBeverage";
            this.lblAnotherBeverage.Size = new System.Drawing.Size(163, 24);
            this.lblAnotherBeverage.TabIndex = 7;
            this.lblAnotherBeverage.Text = "Another Beverage";
            // 
            // cbAnotherBeverage
            // 
            this.cbAnotherBeverage.FormattingEnabled = true;
            this.cbAnotherBeverage.Location = new System.Drawing.Point(458, 60);
            this.cbAnotherBeverage.Name = "cbAnotherBeverage";
            this.cbAnotherBeverage.Size = new System.Drawing.Size(159, 32);
            this.cbAnotherBeverage.TabIndex = 8;
            this.cbAnotherBeverage.SelectedIndexChanged += new System.EventHandler(this.cbAnotherBeverage_SelectedIndexChanged);
            // 
            // lblMnuNewPrc
            // 
            this.lblMnuNewPrc.AutoSize = true;
            this.lblMnuNewPrc.Enabled = false;
            this.lblMnuNewPrc.Location = new System.Drawing.Point(66, 127);
            this.lblMnuNewPrc.Name = "lblMnuNewPrc";
            this.lblMnuNewPrc.Size = new System.Drawing.Size(107, 24);
            this.lblMnuNewPrc.TabIndex = 6;
            this.lblMnuNewPrc.Text = "New Price: ";
            // 
            // lblMenuNewPrice
            // 
            this.lblMenuNewPrice.AutoSize = true;
            this.lblMenuNewPrice.Enabled = false;
            this.lblMenuNewPrice.Location = new System.Drawing.Point(183, 127);
            this.lblMenuNewPrice.Name = "lblMenuNewPrice";
            this.lblMenuNewPrice.Size = new System.Drawing.Size(0, 24);
            this.lblMenuNewPrice.TabIndex = 6;
            // 
            // lblExBvrg
            // 
            this.lblExBvrg.AutoSize = true;
            this.lblExBvrg.Location = new System.Drawing.Point(7, 31);
            this.lblExBvrg.Name = "lblExBvrg";
            this.lblExBvrg.Size = new System.Drawing.Size(149, 24);
            this.lblExBvrg.TabIndex = 6;
            this.lblExBvrg.Text = "Extra Beverage: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity: ";
            // 
            // cbExtraBeverages
            // 
            this.cbExtraBeverages.FormattingEnabled = true;
            this.cbExtraBeverages.Location = new System.Drawing.Point(170, 28);
            this.cbExtraBeverages.Name = "cbExtraBeverages";
            this.cbExtraBeverages.Size = new System.Drawing.Size(172, 32);
            this.cbExtraBeverages.TabIndex = 9;
            // 
            // nmrQty
            // 
            this.nmrQty.Location = new System.Drawing.Point(170, 66);
            this.nmrQty.Name = "nmrQty";
            this.nmrQty.Size = new System.Drawing.Size(67, 29);
            this.nmrQty.TabIndex = 10;
            // 
            // lbOrderContents
            // 
            this.lbOrderContents.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbOrderContents.FormattingEnabled = true;
            this.lbOrderContents.ItemHeight = 24;
            this.lbOrderContents.Location = new System.Drawing.Point(6, 24);
            this.lbOrderContents.Name = "lbOrderContents";
            this.lbOrderContents.Size = new System.Drawing.Size(263, 244);
            this.lbOrderContents.TabIndex = 11;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddMenu.Location = new System.Drawing.Point(182, 154);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(197, 43);
            this.btnAddMenu.TabIndex = 12;
            this.btnAddMenu.Text = "Add Menu";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnAddBeverage
            // 
            this.btnAddBeverage.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddBeverage.Location = new System.Drawing.Point(170, 113);
            this.btnAddBeverage.Name = "btnAddBeverage";
            this.btnAddBeverage.Size = new System.Drawing.Size(172, 33);
            this.btnAddBeverage.TabIndex = 12;
            this.btnAddBeverage.Text = "Add Beverage";
            this.btnAddBeverage.UseVisualStyleBackColor = false;
            this.btnAddBeverage.Click += new System.EventHandler(this.btnAddBeverage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(29, 283);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.Red;
            this.btnRemoveAll.Location = new System.Drawing.Point(29, 321);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(200, 34);
            this.btnRemoveAll.TabIndex = 1;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Silver;
            this.btnComplete.Location = new System.Drawing.Point(131, 50);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(216, 44);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Complete the Order";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.Location = new System.Drawing.Point(116, 25);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 24);
            this.lblTotalPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(29, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Flaked Cheese";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(29, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sausage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(299, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vegetables";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(299, 307);
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
            this.gbExtras.Size = new System.Drawing.Size(353, 95);
            this.gbExtras.TabIndex = 13;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras";
            // 
            // btnCrispyEdge
            // 
            this.btnCrispyEdge.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCrispyEdge.Location = new System.Drawing.Point(203, 60);
            this.btnCrispyEdge.Name = "btnCrispyEdge";
            this.btnCrispyEdge.Size = new System.Drawing.Size(139, 29);
            this.btnCrispyEdge.TabIndex = 14;
            this.btnCrispyEdge.Text = "CrispyEdge";
            this.btnCrispyEdge.UseVisualStyleBackColor = false;
            this.btnCrispyEdge.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnDesert
            // 
            this.btnDesert.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDesert.Location = new System.Drawing.Point(6, 28);
            this.btnDesert.Name = "btnDesert";
            this.btnDesert.Size = new System.Drawing.Size(139, 29);
            this.btnDesert.TabIndex = 14;
            this.btnDesert.Text = "Desert";
            this.btnDesert.UseVisualStyleBackColor = false;
            this.btnDesert.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnSauce
            // 
            this.btnSauce.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSauce.Location = new System.Drawing.Point(6, 60);
            this.btnSauce.Name = "btnSauce";
            this.btnSauce.Size = new System.Drawing.Size(139, 29);
            this.btnSauce.TabIndex = 14;
            this.btnSauce.Text = "Sauce";
            this.btnSauce.UseVisualStyleBackColor = false;
            this.btnSauce.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCheese.Location = new System.Drawing.Point(203, 28);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(139, 29);
            this.btnCheese.TabIndex = 14;
            this.btnCheese.Text = "Cheese";
            this.btnCheese.UseVisualStyleBackColor = false;
            this.btnCheese.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.gbMenu.Controls.Add(this.btnAddMenu);
            this.gbMenu.Controls.Add(this.cbMenus);
            this.gbMenu.Controls.Add(this.label9);
            this.gbMenu.Controls.Add(this.lblMnuCont);
            this.gbMenu.Controls.Add(this.lblMenuContents);
            this.gbMenu.Controls.Add(this.lblMnuPrc);
            this.gbMenu.Controls.Add(this.lblMnuNewPrc);
            this.gbMenu.Controls.Add(this.lblMenuNewPrice);
            this.gbMenu.Controls.Add(this.lblMenuPrice);
            this.gbMenu.Controls.Add(this.cbAnotherBeverage);
            this.gbMenu.Controls.Add(this.lblAnotherBeverage);
            this.gbMenu.Location = new System.Drawing.Point(532, 105);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(635, 197);
            this.gbMenu.TabIndex = 14;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menus";
            this.gbMenu.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Menu Name: ";
            // 
            // gbMenuSelection
            // 
            this.gbMenuSelection.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbMenuSelection.Controls.Add(this.rbSingle);
            this.gbMenuSelection.Controls.Add(this.radioButton2);
            this.gbMenuSelection.Location = new System.Drawing.Point(12, 50);
            this.gbMenuSelection.Name = "gbMenuSelection";
            this.gbMenuSelection.Size = new System.Drawing.Size(1155, 49);
            this.gbMenuSelection.TabIndex = 15;
            this.gbMenuSelection.TabStop = false;
            this.gbMenuSelection.Text = "Order Selection";
            // 
            // gbSingular
            // 
            this.gbSingular.BackColor = System.Drawing.Color.RosyBrown;
            this.gbSingular.Controls.Add(this.btnFlakedCheese);
            this.gbSingular.Controls.Add(this.btnMix);
            this.gbSingular.Controls.Add(this.btnSausage);
            this.gbSingular.Controls.Add(this.btnVegetables);
            this.gbSingular.Controls.Add(this.lblFlakedPrice);
            this.gbSingular.Controls.Add(this.lblMixPrice);
            this.gbSingular.Controls.Add(this.lblVegetablesPrice);
            this.gbSingular.Controls.Add(this.lblSausagePrice);
            this.gbSingular.Location = new System.Drawing.Point(12, 105);
            this.gbSingular.Name = "gbSingular";
            this.gbSingular.Size = new System.Drawing.Size(514, 564);
            this.gbSingular.TabIndex = 16;
            this.gbSingular.TabStop = false;
            this.gbSingular.Text = "Pita Names - Singular";
            this.gbSingular.Visible = false;
            // 
            // gbExtraBeverage
            // 
            this.gbExtraBeverage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbExtraBeverage.Controls.Add(this.cbExtraBeverages);
            this.gbExtraBeverage.Controls.Add(this.lblExBvrg);
            this.gbExtraBeverage.Controls.Add(this.label3);
            this.gbExtraBeverage.Controls.Add(this.nmrQty);
            this.gbExtraBeverage.Controls.Add(this.btnAddBeverage);
            this.gbExtraBeverage.Location = new System.Drawing.Point(814, 308);
            this.gbExtraBeverage.Name = "gbExtraBeverage";
            this.gbExtraBeverage.Size = new System.Drawing.Size(353, 152);
            this.gbExtraBeverage.TabIndex = 17;
            this.gbExtraBeverage.TabStop = false;
            this.gbExtraBeverage.Text = "Extra Beverage";
            // 
            // gbOrderList
            // 
            this.gbOrderList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbOrderList.Controls.Add(this.lbOrderContents);
            this.gbOrderList.Controls.Add(this.btnRemove);
            this.gbOrderList.Controls.Add(this.btnRemoveAll);
            this.gbOrderList.Location = new System.Drawing.Point(532, 308);
            this.gbOrderList.Name = "gbOrderList";
            this.gbOrderList.Size = new System.Drawing.Size(276, 361);
            this.gbOrderList.TabIndex = 18;
            this.gbOrderList.TabStop = false;
            this.gbOrderList.Text = "Order List";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.btnComplete);
            this.gbOrderSummary.Location = new System.Drawing.Point(814, 569);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(353, 100);
            this.gbOrderSummary.TabIndex = 19;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // pbVegetables
            // 
            this.pbVegetables.Location = new System.Drawing.Point(303, 403);
            this.pbVegetables.Name = "pbVegetables";
            this.pbVegetables.Size = new System.Drawing.Size(200, 150);
            this.pbVegetables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVegetables.TabIndex = 0;
            this.pbVegetables.TabStop = false;
            // 
            // pbSausage
            // 
            this.pbSausage.Location = new System.Drawing.Point(33, 403);
            this.pbSausage.Name = "pbSausage";
            this.pbSausage.Size = new System.Drawing.Size(200, 150);
            this.pbSausage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSausage.TabIndex = 0;
            this.pbSausage.TabStop = false;
            // 
            // pbMix
            // 
            this.pbMix.Location = new System.Drawing.Point(303, 138);
            this.pbMix.Name = "pbMix";
            this.pbMix.Size = new System.Drawing.Size(200, 150);
            this.pbMix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMix.TabIndex = 0;
            this.pbMix.TabStop = false;
            // 
            // pbFlakedCheese
            // 
            this.pbFlakedCheese.Location = new System.Drawing.Point(33, 138);
            this.pbFlakedCheese.Name = "pbFlakedCheese";
            this.pbFlakedCheese.Size = new System.Drawing.Size(200, 150);
            this.pbFlakedCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlakedCheese.TabIndex = 0;
            this.pbFlakedCheese.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbOrderList);
            this.Controls.Add(this.gbExtraBeverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbVegetables);
            this.Controls.Add(this.pbSausage);
            this.Controls.Add(this.pbMix);
            this.Controls.Add(this.pbFlakedCheese);
            this.Controls.Add(this.gbSingular);
            this.Controls.Add(this.gbMenuSelection);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQty)).EndInit();
            this.gbExtras.ResumeLayout(false);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.gbMenuSelection.ResumeLayout(false);
            this.gbMenuSelection.PerformLayout();
            this.gbSingular.ResumeLayout(false);
            this.gbSingular.PerformLayout();
            this.gbExtraBeverage.ResumeLayout(false);
            this.gbExtraBeverage.PerformLayout();
            this.gbOrderList.ResumeLayout(false);
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSausage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlakedCheese)).EndInit();
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
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbMenuSelection;
        private System.Windows.Forms.GroupBox gbSingular;
        private System.Windows.Forms.GroupBox gbExtraBeverage;
        private System.Windows.Forms.GroupBox gbOrderList;
        private System.Windows.Forms.GroupBox gbOrderSummary;
    }
}

