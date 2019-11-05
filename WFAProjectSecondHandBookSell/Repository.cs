using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WFAProjectSecondHandBookSell
{
    public class Repository
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string name { set; get; }
        private ProfileForm pf { set; get; }
        private DataGridView DGb { get; set; }


        public Repository(ProfileForm pf, string name, DataGridView dgb)
        {
            this.Da = new DataAccess();
            this.pf = pf;
            this.name = name;
            this.DGb = dgb;
        }

        public void SaveButton(string name, string author, string category, string price, string quality, string bookid)
        {
            string sql = "select * from books where bookid ='" + bookid + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update books
                set name = '" + name + @"',
                author = '" + author + @"',
                category = '" + category + @"',
                
                price = '" + price + @"',
                quality = '" + quality + @"'

                where bookid = '" + bookid + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Requested.");
                    //this.PopulateGridView();
                }
                catch (System.Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                sql = @"insert into request
                values ('" + name + "','" + author + "','" + category + "'," + price + ",'" + quality + "','" + this.name.ToString() + "');";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Requested.");

                }
                catch (System.Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }


        }
        public void DeleteButton(string str)
        {
            //string id = this.dgvBookInfo.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "delete from request where bookid = '" + str + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deleted.");
                string sql1 = "select * from request where sellername = '" + this.name + "';";
                this.Ds = this.Da.ExecuteQuery(sql1);

                DGb.AutoGenerateColumns = false;
                DGb.DataSource = this.Ds.Tables[0];
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        public void AutoSearch(string str)
        {
            string sql = "select * from books where name like '" + str + "%' or author like '" + str + "%' or category like '" + str + "%';";
            this.Ds = this.Da.ExecuteQuery(sql);


        }



    }
}
