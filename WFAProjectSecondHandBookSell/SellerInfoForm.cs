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
    public partial class SellerInfoForm : Form
    {
        private string bid { set; get; }
        private string buyername { set; get; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private AdminForm af { set; get; }

        public SellerInfoForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public SellerInfoForm(AdminForm af, string bid,string buyername)
        {
            InitializeComponent();
            this.af = af;
            txtBOxBookId.Text = bid;
            this.bid = bid;
            this.buyername = buyername;
            this.PopulateGridView();
         

           
        }

        public void PopulateGridView()
        {
           // this.Da = new DataAccess();

            this.Da = new DataAccess();
            string sql = "select * from BookLog where bookid = '"+this.bid.ToString()+"'";
            this.Ds = this.Da.ExecuteQuery(sql);
            this.BookInformation.AutoGenerateColumns = false;
            this.BookInformation.DataSource = this.Ds.Tables[0];
           
        }

       
        private void SellerInfoForm_Load(object sender, EventArgs e)
        {
            this.BookInformation.Visible = false;

            string sql2 = "select * from users where username = '" + this.buyername + "'";
            this.Ds = this.Da.ExecuteQuery(sql2);
            this.dgvBuyerInfo.AutoGenerateColumns = false;
            this.dgvBuyerInfo.DataSource = this.Ds.Tables[0];

            string sql1 = "select * from users where username = '" + this.BookInformation.SelectedRows[0].Cells[6].Value.ToString() + "'";
            this.Ds = this.Da.ExecuteQuery(sql1);
            this.dgvSellerInfo.AutoGenerateColumns = false;
            this.dgvSellerInfo.DataSource = this.Ds.Tables[0];
          
            
        }

        

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.af.Visible = true;
            
        }

        private void SellerInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
