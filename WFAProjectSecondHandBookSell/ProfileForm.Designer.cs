namespace WFAProjectSecondHandBookSell
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYourAds = new System.Windows.Forms.Label();
            this.lblPendings = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblYourOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblAds = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.dgvShowOrder = new System.Windows.Forms.DataGridView();
            this.bookingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblsell = new System.Windows.Forms.Label();
            this.btnDltFromAds = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.lblYourAds);
            this.panel1.Controls.Add(this.lblPendings);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblYourOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 68);
            this.panel1.TabIndex = 37;
            // 
            // lblYourAds
            // 
            this.lblYourAds.AutoSize = true;
            this.lblYourAds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblYourAds.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAds.ForeColor = System.Drawing.Color.White;
            this.lblYourAds.Location = new System.Drawing.Point(866, 25);
            this.lblYourAds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourAds.Name = "lblYourAds";
            this.lblYourAds.Size = new System.Drawing.Size(98, 28);
            this.lblYourAds.TabIndex = 19;
            this.lblYourAds.Text = "Your Ads";
            this.lblYourAds.Click += new System.EventHandler(this.lblYourAds_Click_1);
            // 
            // lblPendings
            // 
            this.lblPendings.AutoSize = true;
            this.lblPendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPendings.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendings.ForeColor = System.Drawing.Color.White;
            this.lblPendings.Location = new System.Drawing.Point(975, 25);
            this.lblPendings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendings.Name = "lblPendings";
            this.lblPendings.Size = new System.Drawing.Size(92, 28);
            this.lblPendings.TabIndex = 18;
            this.lblPendings.Text = "Pendings";
            this.lblPendings.Click += new System.EventHandler(this.lblPendings_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblLogout.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(1082, 23);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(74, 28);
            this.lblLogout.TabIndex = 16;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblYourOrders
            // 
            this.lblYourOrders.AutoSize = true;
            this.lblYourOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblYourOrders.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOrders.ForeColor = System.Drawing.Color.White;
            this.lblYourOrders.Location = new System.Drawing.Point(720, 25);
            this.lblYourOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourOrders.Name = "lblYourOrders";
            this.lblYourOrders.Size = new System.Drawing.Size(131, 28);
            this.lblYourOrders.TabIndex = 15;
            this.lblYourOrders.Text = "Your Orders";
            this.lblYourOrders.Click += new System.EventHandler(this.lblYourOrders_Click);
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
            this.dgvBookInfo.Location = new System.Drawing.Point(4, 380);
            this.dgvBookInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            this.dgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookInfo.Size = new System.Drawing.Size(1155, 362);
            this.dgvBookInfo.TabIndex = 46;
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
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.Color.White;
            this.lblPending.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPending.Location = new System.Drawing.Point(6, 328);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(134, 33);
            this.lblPending.TabIndex = 53;
            this.lblPending.Text = "Pendings  :";
            // 
            // lblAds
            // 
            this.lblAds.AutoSize = true;
            this.lblAds.BackColor = System.Drawing.Color.White;
            this.lblAds.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAds.Location = new System.Drawing.Point(4, 326);
            this.lblAds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAds.Name = "lblAds";
            this.lblAds.Size = new System.Drawing.Size(138, 33);
            this.lblAds.TabIndex = 54;
            this.lblAds.Text = "Your Ads  :";
            this.lblAds.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1006, 334);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 34);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(609, 334);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(344, 26);
            this.txtBoxSearch.TabIndex = 56;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged_1);
            // 
            // dgvShowOrder
            // 
            this.dgvShowOrder.AllowUserToAddRows = false;
            this.dgvShowOrder.AllowUserToDeleteRows = false;
            this.dgvShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingid,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.quality,
            this.dataGridViewTextBoxColumn6});
            this.dgvShowOrder.Location = new System.Drawing.Point(4, 382);
            this.dgvShowOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvShowOrder.Name = "dgvShowOrder";
            this.dgvShowOrder.ReadOnly = true;
            this.dgvShowOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowOrder.Size = new System.Drawing.Size(1160, 362);
            this.dgvShowOrder.TabIndex = 57;
            this.dgvShowOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowOrder_CellContentClick);
            // 
            // bookingid
            // 
            this.bookingid.DataPropertyName = "orderid";
            this.bookingid.HeaderText = "Booking Id";
            this.bookingid.Name = "bookingid";
            this.bookingid.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bookname";
            this.dataGridViewTextBoxColumn2.DividerWidth = 1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "authorname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Author";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // quality
            // 
            this.quality.DataPropertyName = "quality";
            this.quality.HeaderText = "Quality";
            this.quality.Name = "quality";
            this.quality.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.White;
            this.lblOrders.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOrders.Location = new System.Drawing.Point(4, 326);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(175, 33);
            this.lblOrders.TabIndex = 58;
            this.lblOrders.Text = "Your Orders  :";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(18, 88);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 29);
            this.lblWelcome.TabIndex = 59;
            this.lblWelcome.Text = "Welcome ,";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblBuy.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.Color.White;
            this.lblBuy.Location = new System.Drawing.Point(1040, 89);
            this.lblBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(117, 28);
            this.lblBuy.TabIndex = 20;
            this.lblBuy.Text = "Buy A Book";
            this.lblBuy.Click += new System.EventHandler(this.lblBuy_Click);
            // 
            // lblsell
            // 
            this.lblsell.AutoSize = true;
            this.lblsell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblsell.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsell.ForeColor = System.Drawing.Color.White;
            this.lblsell.Location = new System.Drawing.Point(1040, 135);
            this.lblsell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsell.Name = "lblsell";
            this.lblsell.Size = new System.Drawing.Size(119, 28);
            this.lblsell.TabIndex = 20;
            this.lblsell.Text = "Sell A Book";
            this.lblsell.Click += new System.EventHandler(this.lblsell_Click);
            // 
            // btnDltFromAds
            // 
            this.btnDltFromAds.Location = new System.Drawing.Point(1006, 334);
            this.btnDltFromAds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDltFromAds.Name = "btnDltFromAds";
            this.btnDltFromAds.Size = new System.Drawing.Size(140, 34);
            this.btnDltFromAds.TabIndex = 60;
            this.btnDltFromAds.Text = "Delete";
            this.btnDltFromAds.UseVisualStyleBackColor = true;
            this.btnDltFromAds.Click += new System.EventHandler(this.btnDltFromAds_Click_1);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 737);
            this.Controls.Add(this.btnDltFromAds);
            this.Controls.Add(this.lblsell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.dgvShowOrder);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAds);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.dgvBookInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblYourOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYourAds;
        private System.Windows.Forms.Label lblPendings;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblAds;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.DataGridView dgvShowOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblsell;
        private System.Windows.Forms.Button btnDltFromAds;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}