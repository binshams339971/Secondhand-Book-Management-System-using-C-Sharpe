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
    public partial class AdminLoginForm : Form
    {
        private HomeForm hf { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public AdminLoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public AdminLoginForm(HomeForm hf)
        {
            InitializeComponent();
            this.hf = hf;
            this.Da = new DataAccess();
        }
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            
        }

        private bool LoginConfirmation()
        {
            string un = "select * from admintable where adminname = '" + this.txtBoxAdminName.Text + "' and adminpassword = '" + this.txtBoxAdminPassword.Text + "';";
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

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (this.LoginConfirmation())
            {
                this.Visible = false;
                AdminForm af = new AdminForm();
                af.Visible = true;

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.hf.Visible = true;
        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                txtBoxAdminPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxAdminPassword.UseSystemPasswordChar = false;
            }
        }

        private void AdminLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
