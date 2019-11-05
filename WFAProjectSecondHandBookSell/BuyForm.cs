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
    public partial class BuyForm : Form
    {
        private HomeForm hf { set; get; }
        private ProfileForm pf { set; get; }
        private DataAccess Da { get; set; }
        private string name { set; get; }
        private DataSet Ds { get; set; }
        private UserLoginForm usf { set; get; }

        public BuyForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            
        }
        public BuyForm(ProfileForm pf,string name)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

            this.pf = pf;
            this.name = name;
            lblBackToProfile.Visible = true;

        }
        public BuyForm(UserLoginForm usf,HomeForm hf,string un)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.usf = usf;
            this.hf = hf;
            this.name = un;
            this.lblWelcome.Text = "Welcome, "+ un;


        }

       

        public void PopulateGridView(string sql = "select * from books;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = this.Ds.Tables[0];
        }

        private void browseQuick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string sql = "select * from books where name = '" + lbl.Text + "' or author = '" + lbl.Text + "'or category ='" + lbl.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from books where name like '" + this.txtBoxSearch.Text + "%' or author like '" + this.txtBoxSearch.Text + "%' or category like '" + this.txtBoxSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            lblGoToCart.Visible = true;
            lblBackToCart.Visible = false;
            lblBackToProfile.Visible = false;
            dgvShow.Visible = true;
            dgvCart.Visible = false;
            
            btnRemove.Visible = false;
            btnConfirm.Visible = false;
           // lblBackToCart.Visible = false;
            this.PopulateGridView();
            

        }

       

        private void lblGoToCart_Click(object sender, EventArgs e)
        {
            lblGoToCart.Visible = false;
            lblBackToCart.Visible = true;
            lblChildren.Visible= false;
            lblComicBook.Visible = false;
            lblMathematics.Visible = false;
            lblHumayunAhmed.Visible = false;
            lblSciFi.Visible = false;
            lblNovel.Visible = false;
            lblMystery.Visible = false;
            lblLiterature.Visible = false;
            btnAddToCart.Visible = false;
            lblEngineering.Visible = false;
            dgvShow.Visible = false;
            dgvCart.Visible=true;
            lblBrowse.Visible = false;
            btnRemove.Visible = true;
            btnConfirm.Visible = true;
            lblShowAll.Visible = false;
            string sql = "select * from orders";
           
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = this.Ds.Tables[0];

            

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string sql = "delete from orders where bookid = '" + dgvCart.SelectedRows[0].Cells[5].Value.ToString() + "';";
            this.Da.ExecuteUpdateQuery(sql);

            string sql1 = "select * from orders";

            this.Ds = this.Da.ExecuteQuery(sql1);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = this.Ds.Tables[0];
            

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string sql = "select * from orders where bookid ='" + dgvShow.SelectedRows[0].Cells[5].Value.ToString() + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Already Added To Cart");
               
            }
            else
            {
                string sql1 = @"insert into orders 
   values ( '" + dgvShow.SelectedRows[0].Cells[0].Value.ToString() + "','" + dgvShow.SelectedRows[0].Cells[1].Value.ToString() + "', '" + dgvShow.SelectedRows[0].Cells[2].Value.ToString() + "','" + dgvShow.SelectedRows[0].Cells[3].Value.ToString() + "','" + dgvShow.SelectedRows[0].Cells[4].Value + "','" + dgvShow.SelectedRows[0].Cells[5].Value.ToString() + "','" + this.name.ToString() + "');";

                this.Da.ExecuteUpdateQuery(sql1);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string sql = @"insert into confirmedorders select * from orders";
            this.Da.ExecuteUpdateQuery(sql);


            string sql3 = "delete from books where bookid = '" + dgvCart.SelectedRows[0].Cells[5].Value.ToString() + "';";
            this.Da.ExecuteUpdateQuery(sql3);

            string sql1 = "delete from orders ;";
            this.Da.ExecuteUpdateQuery(sql1);

            string sql2 = "select * from orders";

            this.Ds = this.Da.ExecuteQuery(sql2);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = this.Ds.Tables[0];


            lblGoToCart.Visible = true;
            lblBackToCart.Visible = false;
            lblChildren.Visible = true;
            lblComicBook.Visible = true;
            lblSciFi.Visible = true;
            lblHumayunAhmed.Visible = true;
            lblLiterature.Visible = true;
            lblNovel.Visible = true;
            lblMystery.Visible = true;
            lblMathematics.Visible = true;
            btnAddToCart.Visible = true;
            lblEngineering.Visible = true;
            dgvShow.Visible = true;
            dgvCart.Visible = false;
            lblBrowse.Visible = true;
            btnRemove.Visible = false;
            btnConfirm.Visible = false;
            lblShowAll.Visible = true;


            string sql4 = "select * from books;";
            this.PopulateGridView(sql4 );


        }

        private void txtBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "select * from books where name like '" + this.txtBoxSearch.Text + "%' or author like '" + this.txtBoxSearch.Text + "%' or category like '" + this.txtBoxSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            

            this.PopulateGridView();
            
        }

        private void lblYourOrders_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            ShowOrdersForm sof = new ShowOrdersForm(this,this.name);
            sof.Visible = true;

        }

       
        private void lblShowAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from books;";
            this.PopulateGridView(sql);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeForm hf = new HomeForm();
            hf.Visible = true;
            this.PopulateGridView();
        }

        private void lblBackToProfile_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.pf.Visible = true;
        }

        private void lblBackToCart_Click(object sender, EventArgs e)
        {
            lblGoToCart.Visible = true;
            lblBackToCart.Visible = false;
            lblChildren.Visible = true;
            lblComicBook.Visible = true;
            lblSciFi.Visible = true;
            lblHumayunAhmed.Visible = true;
            lblMathematics.Visible = true;
            lblNovel.Visible = true;
            lblMystery.Visible = true;
            lblLiterature.Visible = true;
            btnAddToCart.Visible = true;
            lblEngineering.Visible = true;
            dgvShow.Visible = true;
            dgvCart.Visible = false;
            lblBrowse.Visible = true;
            btnRemove.Visible = false;
            btnConfirm.Visible = false;
            lblShowAll.Visible = true;
        }

        private void BuyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
