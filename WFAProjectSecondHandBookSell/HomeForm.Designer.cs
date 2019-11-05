namespace WFAProjectSecondHandBookSell
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblsell = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCrime = new System.Windows.Forms.Label();
            this.lblBestOf = new System.Windows.Forms.Label();
            this.lblChildrens = new System.Windows.Forms.Label();
            this.lblNovel = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblHorror = new System.Windows.Forms.Label();
            this.lblComicBook = new System.Windows.Forms.Label();
            this.lblThriller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qauality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.lblMystery = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.lblLogIn);
            this.panel1.Controls.Add(this.lblsell);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblBuy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 44);
            this.panel1.TabIndex = 23;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblLogIn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.White;
            this.lblLogIn.Location = new System.Drawing.Point(722, 17);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(42, 19);
            this.lblLogIn.TabIndex = 17;
            this.lblLogIn.Text = "Login";
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // lblsell
            // 
            this.lblsell.AutoSize = true;
            this.lblsell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblsell.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsell.ForeColor = System.Drawing.Color.White;
            this.lblsell.Location = new System.Drawing.Point(633, 17);
            this.lblsell.Name = "lblsell";
            this.lblsell.Size = new System.Drawing.Size(83, 19);
            this.lblsell.TabIndex = 16;
            this.lblsell.Text = "Sell A Book";
            this.lblsell.Click += new System.EventHandler(this.lblsell_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblAdmin.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(158, 22);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(48, 19);
            this.lblAdmin.TabIndex = 14;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblBuy.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.Color.White;
            this.lblBuy.Location = new System.Drawing.Point(547, 17);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(80, 19);
            this.lblBuy.TabIndex = 13;
            this.lblBuy.Text = "Buy A Book";
            this.lblBuy.Click += new System.EventHandler(this.lblBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(50, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblCrime
            // 
            this.lblCrime.AutoSize = true;
            this.lblCrime.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCrime.Location = new System.Drawing.Point(142, 114);
            this.lblCrime.Name = "lblCrime";
            this.lblCrime.Size = new System.Drawing.Size(93, 19);
            this.lblCrime.TabIndex = 35;
            this.lblCrime.Text = "Mathematics";
            this.lblCrime.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblBestOf
            // 
            this.lblBestOf.AutoSize = true;
            this.lblBestOf.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestOf.ForeColor = System.Drawing.Color.Green;
            this.lblBestOf.Location = new System.Drawing.Point(69, 175);
            this.lblBestOf.Name = "lblBestOf";
            this.lblBestOf.Size = new System.Drawing.Size(113, 19);
            this.lblBestOf.TabIndex = 34;
            this.lblBestOf.Text = "Humayun Ahmed";
            this.lblBestOf.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblChildrens
            // 
            this.lblChildrens.AutoSize = true;
            this.lblChildrens.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblChildrens.Location = new System.Drawing.Point(31, 146);
            this.lblChildrens.Name = "lblChildrens";
            this.lblChildrens.Size = new System.Drawing.Size(62, 19);
            this.lblChildrens.TabIndex = 33;
            this.lblChildrens.Text = "Children";
            this.lblChildrens.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblNovel
            // 
            this.lblNovel.AutoSize = true;
            this.lblNovel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNovel.Location = new System.Drawing.Point(118, 146);
            this.lblNovel.Name = "lblNovel";
            this.lblNovel.Size = new System.Drawing.Size(46, 19);
            this.lblNovel.TabIndex = 32;
            this.lblNovel.Text = "Novel";
            this.lblNovel.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Teal;
            this.lblAction.Location = new System.Drawing.Point(40, 114);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(79, 19);
            this.lblAction.TabIndex = 31;
            this.lblAction.Text = "Literature";
            this.lblAction.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblHorror
            // 
            this.lblHorror.AutoSize = true;
            this.lblHorror.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHorror.Location = new System.Drawing.Point(182, 146);
            this.lblHorror.Name = "lblHorror";
            this.lblHorror.Size = new System.Drawing.Size(109, 19);
            this.lblHorror.TabIndex = 30;
            this.lblHorror.Text = "Science Fiction";
            this.lblHorror.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblComicBook
            // 
            this.lblComicBook.AutoSize = true;
            this.lblComicBook.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComicBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblComicBook.Location = new System.Drawing.Point(182, 81);
            this.lblComicBook.Name = "lblComicBook";
            this.lblComicBook.Size = new System.Drawing.Size(84, 19);
            this.lblComicBook.TabIndex = 29;
            this.lblComicBook.Text = "Comic book ";
            this.lblComicBook.Click += new System.EventHandler(this.browseQuick);
            // 
            // lblThriller
            // 
            this.lblThriller.AutoSize = true;
            this.lblThriller.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThriller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblThriller.Location = new System.Drawing.Point(17, 81);
            this.lblThriller.Name = "lblThriller";
            this.lblThriller.Size = new System.Drawing.Size(84, 19);
            this.lblThriller.TabIndex = 27;
            this.lblThriller.Text = "Engineering";
            this.lblThriller.Click += new System.EventHandler(this.browseQuick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Browse Quickly";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(486, 212);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(278, 20);
            this.txtBoxSearch.TabIndex = 25;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.author,
            this.category,
            this.price,
            this.qauality,
            this.bookid});
            this.dgvShow.Location = new System.Drawing.Point(3, 238);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.Size = new System.Drawing.Size(773, 235);
            this.dgvShow.TabIndex = 24;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.DividerWidth = 1;
            this.name.HeaderText = "Book Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
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
            // qauality
            // 
            this.qauality.DataPropertyName = "quality";
            this.qauality.HeaderText = "Quality";
            this.qauality.Name = "qauality";
            this.qauality.ReadOnly = true;
            // 
            // bookid
            // 
            this.bookid.DataPropertyName = "bookid";
            this.bookid.HeaderText = "Book Id";
            this.bookid.Name = "bookid";
            this.bookid.ReadOnly = true;
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblShowAll.Location = new System.Drawing.Point(17, 203);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(64, 19);
            this.lblShowAll.TabIndex = 36;
            this.lblShowAll.Text = "Show All";
            this.lblShowAll.Click += new System.EventHandler(this.lblShowAll_Click);
            // 
            // lblMystery
            // 
            this.lblMystery.AutoSize = true;
            this.lblMystery.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMystery.ForeColor = System.Drawing.Color.Maroon;
            this.lblMystery.Location = new System.Drawing.Point(118, 81);
            this.lblMystery.Name = "lblMystery";
            this.lblMystery.Size = new System.Drawing.Size(64, 19);
            this.lblMystery.TabIndex = 28;
            this.lblMystery.Text = "Mystery";
            this.lblMystery.Click += new System.EventHandler(this.browseQuick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 479);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCrime);
            this.Controls.Add(this.lblBestOf);
            this.Controls.Add(this.lblChildrens);
            this.Controls.Add(this.lblNovel);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblHorror);
            this.Controls.Add(this.lblComicBook);
            this.Controls.Add(this.lblMystery);
            this.Controls.Add(this.lblThriller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.dgvShow);
            this.Name = "HomeForm";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCrime;
        private System.Windows.Forms.Label lblBestOf;
        private System.Windows.Forms.Label lblChildrens;
        private System.Windows.Forms.Label lblNovel;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblHorror;
        private System.Windows.Forms.Label lblComicBook;
        private System.Windows.Forms.Label lblThriller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qauality;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.Label lblsell;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblMystery;
    }
}