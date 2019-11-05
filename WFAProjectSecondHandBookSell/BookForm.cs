using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProjectSecondHandBookSell
{
    public partial class BookForm : Form
    {
        private AdminForm af { set; get; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public BookForm(AdminForm af)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.af = af;
        }
       

        public void PopulateGridView(string sql = "select * from books;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from books where name like '" + this.txtBoxSearch.Text + "%' or author like '" + this.txtBoxSearch.Text + "%' or category like '" + this.txtBoxSearch.Text + "%';";
             this.PopulateGridView(sql);

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from books where bookid ='" + this.txtBoxId.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update books
                set title = '" + this.txtBoxName.Text + @"',
                category = '" + this.txtBoxCategory.Text + @"',
                author = '" + this.txtBoxAuthor.Text + @"',
                price = '" + this.txtBoxPrice.Text + @"',
                stock = '" + this.txtBoxCategory.Text + @"'

                where bookid = '" + this.txtBoxId.Text + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                string a= "admin";
                sql = @"insert into books
                values ('" + this.txtBoxName.Text+"','" + this.txtBoxAuthor.Text + "','"+this.txtBoxCategory.Text+"',"+this.txtBoxPrice.Text+",'"+this.txtBoxCategory.Text+"','"+a.ToString()+"');";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.");
                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }

            txtBoxId.Clear();
            txtBoxName.Clear();
            txtBoxAuthor.Clear();
            txtBoxPrice.Clear();
           
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvBookInfo.CurrentRow.Cells["bookid"].Value.ToString();
            string sql = "delete from books where bookid = '" + id + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.txtBoxName.Text = this.dgvBookInfo.CurrentRow.Cells["title"].Value.ToString();
            this.txtBoxCategory.Text = this.dgvBookInfo.CurrentRow.Cells["category"].Value.ToString();
            this.txtBoxAuthor.Text = this.dgvBookInfo.CurrentRow.Cells["author"].Value.ToString();
            this.txtBoxId.Text = this.dgvBookInfo.CurrentRow.Cells["bookid"].Value.ToString();
            this.txtBoxPrice.Text = this.dgvBookInfo.CurrentRow.Cells["price"].Value.ToString();
            this.txtBoxCategory.Text = this.dgvBookInfo.CurrentRow.Cells["category"].Value.ToString();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            af.Visible = true;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeForm hf = new HomeForm();
            hf.Visible = true;
        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            txtBoxId.Visible = false;
            lblId.Visible = false;
        }

        

       

       
    }
}
