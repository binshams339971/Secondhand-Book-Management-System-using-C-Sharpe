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
    public partial class UserInfoForm : Form
    {
        private AdminForm af { set; get; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public UserInfoForm()
        {
            InitializeComponent();
            this.PopulateGridView();
        }
        public UserInfoForm(AdminForm af)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.af = af;
        }

        public void PopulateGridView(string sql = "select * from users;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.DataSource = this.Ds.Tables[0];
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from users where username ='" + this.txtBoxUserName.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update users
                set name = '" + this.txtBoxName.Text + @"',
                email ='" + this.txtBoxEmail.Text + @"',
                username ='" + this.txtBoxUserName.Text + @"',
                phoneno ='" + this.txtBoxPhoneNo.Text + @"',
                password ='" + this.txtBoxPassword.Text + @"'
                where username= '" + this.txtBoxUserName.Text + "';";

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
                sql = @"insert into users
                values ('" + this.txtBoxName.Text + "','" + this.txtBoxEmail.Text + "','" + this.txtBoxUserName.Text + "','" + this.txtBoxPhoneNo.Text + "','" + this.txtBoxPassword.Text + "');";
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

            txtBoxName.Clear();
            txtBoxEmail.Clear();
            txtBoxUserName.Clear();
            txtBoxPhoneNo.Clear();
            txtBoxPassword.Clear();
        }
        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtBoxName.Text = this.dgvMain.CurrentRow.Cells["name"].Value.ToString();
            this.txtBoxEmail.Text = this.dgvMain.CurrentRow.Cells["email"].Value.ToString();
            this.txtBoxUserName.Text = this.dgvMain.CurrentRow.Cells["username"].Value.ToString();
            this.txtBoxPhoneNo.Text = this.dgvMain.CurrentRow.Cells["phoneno"].Value.ToString();
            this.txtBoxPassword.Text = this.dgvMain.CurrentRow.Cells["password"].Value.ToString();

        }

        private void lblBack_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            af.Visible = true;
        }

        private void lblLogOut_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            HomeForm hf = new HomeForm();
            hf.Visible = true;
        }


        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from users where name like '" + this.txtSearchBOx.Text + "%' or username like '" + this.txtSearchBOx.Text + "%' or email like '" + this.txtSearchBOx.Text + "%'or phoneno like '" + this.txtSearchBOx.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void UserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string username = this.dgvMain.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from users where username = '" + username + "';";
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
    }
}
