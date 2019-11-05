namespace WFAProjectSecondHandBookSell
{
    partial class SellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblYourAds = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblPendings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYourOrders = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDltFromAds = new System.Windows.Forms.Button();
            this.txtBoxQuality = new System.Windows.Forms.ComboBox();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.txtBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.lblYourAds);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblPendings);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 68);
            this.panel1.TabIndex = 37;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblBack.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(1094, 2);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 28);
            this.lblBack.TabIndex = 21;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblYourAds
            // 
            this.lblYourAds.AutoSize = true;
            this.lblYourAds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblYourAds.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAds.ForeColor = System.Drawing.Color.White;
            this.lblYourAds.Location = new System.Drawing.Point(858, 15);
            this.lblYourAds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourAds.Name = "lblYourAds";
            this.lblYourAds.Size = new System.Drawing.Size(98, 28);
            this.lblYourAds.TabIndex = 17;
            this.lblYourAds.Text = "Your Ads";
            this.lblYourAds.Click += new System.EventHandler(this.lblYourAds_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblLogout.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(1082, 29);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(74, 28);
            this.lblLogout.TabIndex = 16;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblPendings
            // 
            this.lblPendings.AutoSize = true;
            this.lblPendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPendings.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendings.ForeColor = System.Drawing.Color.White;
            this.lblPendings.Location = new System.Drawing.Point(976, 15);
            this.lblPendings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendings.Name = "lblPendings";
            this.lblPendings.Size = new System.Drawing.Size(92, 28);
            this.lblPendings.TabIndex = 14;
            this.lblPendings.Text = "Pendings";
            this.lblPendings.Click += new System.EventHandler(this.lblPendings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(75, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblYourOrders
            // 
            this.lblYourOrders.AutoSize = true;
            this.lblYourOrders.BackColor = System.Drawing.Color.White;
            this.lblYourOrders.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblYourOrders.Location = new System.Drawing.Point(6, 203);
            this.lblYourOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourOrders.Name = "lblYourOrders";
            this.lblYourOrders.Size = new System.Drawing.Size(138, 33);
            this.lblYourOrders.TabIndex = 15;
            this.lblYourOrders.Text = "Your Ads  :";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnDltFromAds);
            this.pnlMain.Controls.Add(this.txtBoxQuality);
            this.pnlMain.Controls.Add(this.lblPending);
            this.pnlMain.Controls.Add(this.lblId);
            this.pnlMain.Controls.Add(this.lblYourOrders);
            this.pnlMain.Controls.Add(this.txtBoxId);
            this.pnlMain.Controls.Add(this.lblStock);
            this.pnlMain.Controls.Add(this.dgvBookInfo);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.txtBoxAuthor);
            this.pnlMain.Controls.Add(this.txtBoxCategory);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnSell);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.txtBoxPrice);
            this.pnlMain.Controls.Add(this.txtBoxName);
            this.pnlMain.Controls.Add(this.txtBoxSearch);
            this.pnlMain.Location = new System.Drawing.Point(27, 126);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1126, 612);
            this.pnlMain.TabIndex = 38;
            // 
            // btnDltFromAds
            // 
            this.btnDltFromAds.Location = new System.Drawing.Point(962, 211);
            this.btnDltFromAds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDltFromAds.Name = "btnDltFromAds";
            this.btnDltFromAds.Size = new System.Drawing.Size(140, 34);
            this.btnDltFromAds.TabIndex = 54;
            this.btnDltFromAds.Text = "Delete";
            this.btnDltFromAds.UseVisualStyleBackColor = true;
            this.btnDltFromAds.Click += new System.EventHandler(this.btnDltFromAds_Click);
            // 
            // txtBoxQuality
            // 
            this.txtBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxQuality.FormattingEnabled = true;
            this.txtBoxQuality.Items.AddRange(new object[] {
            "New",
            "Good",
            "Medium",
            "Old"});
            this.txtBoxQuality.Location = new System.Drawing.Point(566, 11);
            this.txtBoxQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxQuality.Name = "txtBoxQuality";
            this.txtBoxQuality.Size = new System.Drawing.Size(217, 28);
            this.txtBoxQuality.TabIndex = 53;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.Color.White;
            this.lblPending.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPending.Location = new System.Drawing.Point(9, 203);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(134, 33);
            this.lblPending.TabIndex = 52;
            this.lblPending.Text = "Pendings  :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Maroon;
            this.lblId.Location = new System.Drawing.Point(810, 12);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 21);
            this.lblId.TabIndex = 51;
            this.lblId.Text = "Id";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(882, 12);
            this.txtBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(217, 26);
            this.txtBoxId.TabIndex = 50;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Maroon;
            this.lblStock.Location = new System.Drawing.Point(462, 12);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(72, 21);
            this.lblStock.TabIndex = 47;
            this.lblStock.Text = "Quality";
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToAddRows = false;
            this.dgvBookInfo.AllowUserToDeleteRows = false;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookid,
            this.title,
            this.author,
            this.category,
            this.price,
            this.stock});
            this.dgvBookInfo.Location = new System.Drawing.Point(0, 243);
            this.dgvBookInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            this.dgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookInfo.Size = new System.Drawing.Size(1126, 362);
            this.dgvBookInfo.TabIndex = 45;
            this.dgvBookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellContentClick);
            // 
            // bookid
            // 
            this.bookid.DataPropertyName = "bookid";
            this.bookid.HeaderText = "Book Id";
            this.bookid.Name = "bookid";
            this.bookid.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "name";
            this.title.DividerWidth = 1;
            this.title.HeaderText = "Book Name";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "quality";
            this.stock.HeaderText = "Quality";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(10, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = "Author :";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAuthor.Location = new System.Drawing.Point(171, 54);
            this.txtBoxAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(216, 28);
            this.txtBoxAuthor.TabIndex = 41;
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxCategory.FormattingEnabled = true;
            this.txtBoxCategory.Items.AddRange(new object[] {
            "Comic Book",
            "Children",
            "Engineering",
            "Literature",
            "Mathematics",
            "Mystery",
            "Novel",
            "Science Fiction"});
            this.txtBoxCategory.Location = new System.Drawing.Point(171, 95);
            this.txtBoxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.Size = new System.Drawing.Size(217, 28);
            this.txtBoxCategory.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(962, 208);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 34);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.White;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSell.Location = new System.Drawing.Point(441, 145);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(202, 49);
            this.btnSell.TabIndex = 34;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(465, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(9, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Title :";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(566, 69);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(217, 26);
            this.txtBoxPrice.TabIndex = 25;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(170, 8);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(217, 28);
            this.txtBoxName.TabIndex = 23;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(566, 211);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(344, 26);
            this.txtBoxSearch.TabIndex = 20;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sell A Book :";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(927, 82);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 29);
            this.lblWelcome.TabIndex = 56;
            this.lblWelcome.Text = "Welcome ,";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 737);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellForm_FormClosed);
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblYourOrders;
        private System.Windows.Forms.Label lblPendings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.ComboBox txtBoxCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblYourAds;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox txtBoxQuality;
        private System.Windows.Forms.Button btnDltFromAds;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}