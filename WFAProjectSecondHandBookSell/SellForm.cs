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
    public partial class SellForm : Form
    {
        private HomeForm hf { set; get; }
        private bool check { set; get; }
        private ProfileForm pf { set; get; }
        private DataAccess Da { get; set; }
        private string name { set; get; }
        private DataSet Ds { get; set; }
        private UserLoginForm usf { set; get; }
        private Repository rp { get; set; }

        public SellForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.rp = new Repository(pf, name, this.dgvBookInfo);
        }
        public SellForm(ProfileForm pf,string name)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.pf = pf;
            this.name = name;
            this.check = false;
            this.rp = new Repository(pf, name, this.dgvBookInfo);
        }
        public SellForm(UserLoginForm usf, HomeForm hf, string un)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.check = true;
            this.usf = usf;
            this.hf = hf;
            this.name = un;
            this.lblWelcome.Text = "Welcome, " + un;
            this.PopulateGridView();
            this.rp = new Repository(pf, name, this.dgvBookInfo);
        }

        public void PopulateGridView()
        {
            string sql = "select * from books where sellername = '"+this.name+"';";
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from books where name like '" + this.txtBoxSearch.Text + "%' or author like '" + this.txtBoxSearch.Text + "%' or category like '" + this.txtBoxSearch.Text + "%';";
            this.Ds = this.Da.ExecuteQuery(sql);
            //rp.AutoSearch(this.txtBoxSearch.Text);
            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            rp.SaveButton(this.txtBoxName.Text, this.txtBoxAuthor.Text, this.txtBoxCategory.Text, this.txtBoxPrice.Text, this.txtBoxQuality.Text, this.txtBoxId.Text);
            /*string sql = "select * from books where bookid ='" + this.txtBoxId.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update books
                set name = '" + this.txtBoxName.Text + @"',
                author = '" + this.txtBoxAuthor.Text + @"',
                category = '" + this.txtBoxCategory.Text + @"',
                
                price = '" + this.txtBoxPrice.Text + @"',
                quality = '" + this.txtBoxQuality.Text + @"'

                where bookid = '" + this.txtBoxId.Text + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Requested.");
                    //this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                sql = @"insert into request
                values ('" + this.txtBoxName.Text + "','" + this.txtBoxAuthor.Text + "','" + this.txtBoxCategory.Text + "'," + this.txtBoxPrice.Text + ",'" + this.txtBoxQuality.Text + "','"+this.name.ToString()+"');";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Requested.");
                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            */
            txtBoxId.Clear();
            txtBoxName.Clear();
            txtBoxAuthor.Clear();
            txtBoxPrice.Clear();
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvBookInfo.SelectedRows[0].Cells[0].Value.ToString();
            rp.DeleteButton(id);
            /*
            string sql = "delete from request where bookid = '" + id + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deleted.");
                string sql1 = "select * from request where sellername = '" + this.name + "';";
                this.Ds = this.Da.ExecuteQuery(sql1);

                this.dgvBookInfo.AutoGenerateColumns = false;
                this.dgvBookInfo.DataSource = this.Ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            */
        }

        

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.hf.Visible = true;
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            btnDltFromAds.Visible = true;
            btnDelete.Visible = false;
            lblPending.Visible = false;
            txtBoxId.Visible = false;
            lblId.Visible = false;
        }

        private void lblPendings_Click(object sender, EventArgs e)
        {
            btnDltFromAds.Visible = false;
            btnDelete.Visible = true;
            lblYourOrders.Visible = false;
            lblPending.Visible = true;

            string sql = "select * from request where sellername = '" + this.name + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void lblYourAds_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnDltFromAds.Visible = true;
            lblPending.Visible = false;
            lblYourOrders.Visible = true;
            this.PopulateGridView();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (this.check == true)
            {
                this.hf.Visible = true;
            }
            if(this.check==false)
            {
                this.pf.Visible = true;
            }
        }

        private void btnDltFromAds_Click(object sender, EventArgs e)
        {
            
            string id = this.dgvBookInfo.SelectedRows[0].Cells[0].Value.ToString();
            rp.DeleteButton(id);
            /*
            string sql = "delete from books where bookid = '" + id + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deleted.");
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            */
        }

        private void dgvBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            rp.AutoSearch(this.txtBoxSearch.Text);
            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void SellForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
