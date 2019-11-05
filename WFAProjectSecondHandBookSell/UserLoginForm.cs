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
    public partial class UserLoginForm : Form
    {
        private HomeForm hf { get; set; }
        private string sellbuy { set; get; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }


        public UserLoginForm(HomeForm hf1,string sellbuy)
        {
            InitializeComponent();
            this.hf = hf1 ;
            this.sellbuy = sellbuy;
            this.Da = new DataAccess();
        }
        public UserLoginForm()
        {
            InitializeComponent();
            
        }
        
        private void lblUserSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            UserSignUpForm usf = new UserSignUpForm(this);
            usf.Visible = true;


        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            if (this.LoginConfirmation())
            {
                this.Visible = false;

                if (this.sellbuy.ToString() == "Buy A Book")
                {
                    BuyForm bf = new BuyForm(this, this.hf, this.txtBoxUserName.Text);
                    bf.Visible = true;

                    txtBoxUserName.Clear();
                    txtBoxUserPassword.Clear();
                }
                if (this.sellbuy.ToString() == "Sell A Book")
                {
                    SellForm bf = new SellForm(this, this.hf, this.txtBoxUserName.Text);
                    bf.Visible = true;

                    txtBoxUserName.Clear();
                    txtBoxUserPassword.Clear();
                }
                if (this.sellbuy.ToString() == "Login")
                {
                    ProfileForm pf = new ProfileForm(this, this.hf, this.txtBoxUserName.Text);
                    pf.Visible = true;

                    txtBoxUserName.Clear();
                    txtBoxUserPassword.Clear();
                }
                
                
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private bool LoginConfirmation()
        {
            string un = "select * from users where username = '"+this.txtBoxUserName.Text+"' and password = '"+this.txtBoxUserPassword.Text+"';";
            this.Ds = this.Da.ExecuteQuery(un);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                txtBoxUserPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxUserPassword.UseSystemPasswordChar = false;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.hf.Visible = true;
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
