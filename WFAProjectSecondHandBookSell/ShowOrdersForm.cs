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
    public partial class ShowOrdersForm : Form
    {
        private BuyForm bf { set; get; }
        private string name { set; get; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public ShowOrdersForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public ShowOrdersForm(BuyForm bf,string name)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.name = name;
            this.bf = bf;
            this.PopulateGridView();
            
            

        }

        public void PopulateGridView()
        {
            string sql1 = "select * from confirmedorders where buyername = '"+this.name+"';";
            this.Ds = this.Da.ExecuteQuery(sql1);

            this.dgvShowOrder.AutoGenerateColumns = false;
            this.dgvShowOrder.DataSource = this.Ds.Tables[0];
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.bf.Visible = true;
           

        }

        private void ShowOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
