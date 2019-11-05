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
    public partial class ProfileForm : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string name {set; get;}

        private HomeForm hf { set; get; }
        private UserLoginForm usf { set; get; }

        public ProfileForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

         public ProfileForm(UserLoginForm usf,HomeForm hf,string un)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.usf = usf;
            this.hf = hf;
            this.name = un;
            this.lblWelcome.Text = "Welcome, "+ un;

        }
        public void PopulateGridView()
        {
            string sql = "select * from books where sellername = '"+this.name+"';";
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void lblPendings_Click(object sender, EventArgs e)
        {
            btnDltFromAds.Visible = false;
            btnDelete.Visible = true;
            this.dgvBookInfo.Visible = false;
            this.dgvShowOrder.Visible = true;
            lblOrders.Visible = false;
            lblPending.Visible = true;
            lblAds.Visible = false;

            string sql = "select * from request where sellername = '" + this.name + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
        }

        private void lblYourAds_Click(object sender, EventArgs e)
        {
            this.dgvBookInfo.Visible = true;
            this.dgvShowOrder.Visible = false;
            lblPending.Visible = false;
            lblYourOrders.Visible = true;
            this.PopulateGridView();
        }

        private void lblYourOrders_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnDltFromAds.Visible = false;
            lblPending.Visible = false;
            lblOrders.Visible = true;
            lblAds.Visible = false;
            this.dgvBookInfo.Visible = false;
            this.dgvShowOrder.Visible = true;

            string sql1 = "select * from confirmedorders where buyername = '"+this.name+"';";
            this.Ds = this.Da.ExecuteQuery(sql1);

            this.dgvShowOrder.AutoGenerateColumns = false;
            this.dgvShowOrder.DataSource = this.Ds.Tables[0];
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.hf.Visible = true;
            this.PopulateGridView();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvBookInfo.CurrentRow.Cells["bookid"].Value.ToString();
            string sql = "delete from request where bookid = '" + id + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deleted.");
                //this.PopulateGridView();
                string sql1 = "select * from request where sellername = '"+this.name+"';";
                this.Ds = this.Da.ExecuteQuery(sql1);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            this.dgvBookInfo.Visible = true;
            this.dgvShowOrder.Visible = false;
            string sql = "select * from books where name like '" + this.txtBoxSearch.Text + "%' or author like '" + this.txtBoxSearch.Text + "%' or category like '" + this.txtBoxSearch.Text + "%';";
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvBookInfo.AutoGenerateColumns = false;
            this.dgvBookInfo.DataSource = this.Ds.Tables[0];


        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblAds.Visible = true;
            lblOrders.Visible = false;
            lblPending.Visible = false;
            this.dgvShowOrder.Visible = false;
            this.dgvBookInfo.Visible = true;
            this.PopulateGridView();
        }

        private void dgvShowOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblYourAds_Click_1(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnDltFromAds.Visible = true;
            lblPending.Visible = false;
            lblOrders.Visible = false;
            lblAds.Visible = true;
            this.dgvBookInfo.Visible = true;
            this.dgvShowOrder.Visible = false;
            this.PopulateGridView();
        }

        private void lblBuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BuyForm bf = new BuyForm(this,this.name);
            bf.Visible = true;

        }

       

        private void lblsell_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SellForm sf = new SellForm(this,this.name);
            sf.Visible = true;
        }

        private void btnDltFromAds_Click_1(object sender, EventArgs e)
        {
            string id = this.dgvBookInfo.SelectedRows[0].Cells[0].Value.ToString();
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
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }

