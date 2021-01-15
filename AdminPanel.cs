using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerReview
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            BindGrid();
        }

        private void gridReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGrid()
        {
            Panel obj = new Panel();
            List<Panel> listReview = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listReview);
            gridReview.DataSource = dt;
            //BindChart(listReview);
        }

        public static string SetValueForText1 = "";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Review add = new Review();
            SetValueForText1=txtCriteria.Text;
           
        }
    }
}
