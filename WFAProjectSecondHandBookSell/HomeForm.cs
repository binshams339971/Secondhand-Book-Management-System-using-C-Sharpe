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
    public partial class HomeForm : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public HomeForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void lblBuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string buy = lblBuy.Text;
            UserLoginForm usf = new UserLoginForm(this,buy);
            usf.Visible = true;

            HomeForm hf = new HomeForm();
           

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
            string sql = "select * from books where name = '"+lbl.Text+"' or author = '"+lbl.Text+"'or category ='"+lbl.Text+"';";
            this.PopulateGridView(sql);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
                string sql1 = "select * from books where name like '" + this.txtBoxSearch.Text + "%' or author like '" + this.txtBoxSearch.Text + "%' or category like '" + this.txtBoxSearch.Text + "%';";
                this.PopulateGridView(sql1);
     
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //AdminForm af = new AdminForm(this);
            //af.Visible = true;
            AdminLoginForm afl = new AdminLoginForm(this);
            afl.Visible = true;
        }


        private void lblShowAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from books;";
            this.PopulateGridView(sql);
        }

        private void lblsell_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string sell = lblsell.Text;
            UserLoginForm usf = new UserLoginForm(this, sell);
            usf.Visible = true;

            HomeForm hf = new HomeForm();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string login = lblLogIn.Text;
            UserLoginForm uf = new UserLoginForm(this,login);
            uf.Visible = true;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
