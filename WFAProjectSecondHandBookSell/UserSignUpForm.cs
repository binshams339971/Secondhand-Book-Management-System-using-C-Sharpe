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
    public partial class UserSignUpForm : Form
    {
        private UserLoginForm usf1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public UserSignUpForm()
        {
            InitializeComponent();
        }
        public UserSignUpForm(UserLoginForm f1)
        {
            InitializeComponent();
            this.usf1 = f1;
            this.Da = new DataAccess();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.usf1.Visible = true;  
        }

        private void UserSignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            txtBoxSignUpName.Text = "";
            txtBoxSignUpEmail.Text = "";
            txtBoxSignUpUserName.Text = "";
            txtBoxSignUpPassword.Text = "";
            txtBoxSignUpConfirmPassword.Text = "";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string sql = "select * from users where username ='"+this.txtBoxSignUpUserName.Text+"';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                try
                {

                    MessageBox.Show("This user name is already taken ! Please Chose another User Name");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }

            else if(this.txtBoxSignUpName.Text == "" )
                {
                    MessageBox.Show("You must provie a name..");
                }
            else if (this.txtBoxSignUpEmail.Text == "")
            {
                MessageBox.Show("You must provie an email..");
            }
            else if (this.txtBoxSignUpUserName.Text == "")
            {
                MessageBox.Show("You must provie an usernamename..");
            }
            else if (this.txtBoxSignUpPassword.Text == "")
            {
                MessageBox.Show("You must provie a password..");
            }

            else  if (txtBoxSignUpPassword.Text != txtBoxSignUpConfirmPassword.Text)
                {
                    MessageBox.Show("Password did not matched.");
                }

               else
                {
                    sql = @"insert into users
                values ('" + this.txtBoxSignUpName.Text + "','" + this.txtBoxSignUpEmail.Text + "','" + this.txtBoxSignUpUserName.Text + "','" + this.txtBoxPhoneNo.Text + "','" + this.txtBoxSignUpPassword.Text + "');";
                    try
                    {
                        this.Da.ExecuteUpdateQuery(sql);
                        MessageBox.Show("Sign Up Complete.");

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error: " + exc.Message);
                    }

                    txtBoxSignUpName.Clear();
                    txtBoxSignUpEmail.Clear();
                    txtBoxSignUpUserName.Clear();
                    txtBoxPhoneNo.Clear();
                    txtBoxSignUpPassword.Clear();
                    txtBoxSignUpConfirmPassword.Clear();

                    this.Visible = false;
                    this.usf1.Visible = true;
                }
            }
              
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtBoxSignUpPassword.UseSystemPasswordChar = false;
                txtBoxSignUpConfirmPassword.UseSystemPasswordChar = false;
                
            }
            else
            {
                
                txtBoxSignUpPassword.UseSystemPasswordChar = true;
                txtBoxSignUpConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        

       

       

       
    }
}
