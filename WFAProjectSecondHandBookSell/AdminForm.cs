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
    public partial class AdminForm : Form
    {
        HomeForm hf { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public AdminForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.PopulateGridView();
        }
        public AdminForm(HomeForm f1)
        {
            InitializeComponent();
            this.hf = f1;
        }

        public void PopulateGridView()
        {
            this.Da = new DataAccess();
            string sql1 = "select * from request";
            this.Ds = this.Da.ExecuteQuery(sql1);
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = this.Ds.Tables[0];
        }


        private void lblBookInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BookForm bf = new BookForm(this);
            bf.Visible = true;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //this.hf.Visible = true;
            HomeForm hf = new HomeForm();
            hf.Visible = true;
        }

        private void lblUserInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserInfoForm usi = new UserInfoForm( this);
            usi.Visible = true;
        }

        private void lblRequests_Click(object sender, EventArgs e)
        {
            this.dgvShow.Visible = true;
            this.dgvShowOrder.Visible = false;
            btnAprove.Visible = true;
            btnDone.Visible = false;
            this.PopulateGridView();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnDone.Visible = false;
            this.dgvShowOrder.Visible = false;
            btnAprove.Visible = false;
            btnSellereInfo.Visible = false;
        }

        private void btnAprove_Click(object sender, EventArgs e)
        {
            
            string sql = @"insert into books 
   values ( " + dgvShow.SelectedRows[0].Cells[0].Value + ",'" + dgvShow.SelectedRows[0].Cells[1].Value.ToString() + "', '" + dgvShow.SelectedRows[0].Cells[2].Value.ToString() + "','" + dgvShow.SelectedRows[0].Cells[3].Value.ToString() + "'," + dgvShow.SelectedRows[0].Cells[4].Value + ",'" + dgvShow.SelectedRows[0].Cells[5].Value.ToString() + "','" + dgvShow.SelectedRows[0].Cells[6].Value.ToString() + "');";

            this.Da.ExecuteUpdateQuery(sql);

            string s = @"insert into BookLog select * from books";
            this.Da.ExecuteUpdateQuery(s);

            string sql1 = "delete from request where bookid = '" + dgvShow.SelectedRows[0].Cells[0].Value.ToString() + "';";
            this.Da.ExecuteUpdateQuery(sql1);

            string sql11 = "select * from request";

            this.Ds = this.Da.ExecuteQuery(sql11);

            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = this.Ds.Tables[0];
            
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            btnViewOrders.Visible = true;
            btnSellereInfo.Visible = true;
            btnAprove.Visible = false;
            btnDone.Visible = true;
            this.dgvShowOrder.Visible = true;
            this.Da = new DataAccess();
            string sql1 = "select * from confirmedorders ;";
            this.Ds = this.Da.ExecuteQuery(sql1);

            this.dgvShowOrder.AutoGenerateColumns = false;
            this.dgvShowOrder.DataSource = this.Ds.Tables[0];

            
        }

        private void btnSellereInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SellerInfoForm sif = new SellerInfoForm(this, this.dgvShowOrder.SelectedRows[0].Cells[6].Value.ToString(), this.dgvShowOrder.SelectedRows[0].Cells[7].Value.ToString());
            sif.Visible = true;
        }

        private void dgvShowOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //string id = this.dgvShowOrder.CurrentRow.Cells["orderid"].Value.ToString();
            string s = "insert into SellLog select * from Confirmedorders";
            this.Da.ExecuteUpdateQuery(s);
            string sql = "delete from confirmedorders where orderid = '" + dgvShowOrder.SelectedRows[0].Cells[0].Value.ToString() + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Completed.");
               // this.PopulateGridView();
                string sql1 = "select * from confirmedorders";
                this.Ds = this.Da.ExecuteQuery(sql1);
                this.dgvShowOrder.AutoGenerateColumns = false;
                this.dgvShowOrder.DataSource = this.Ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
