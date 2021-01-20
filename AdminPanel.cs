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
        public static string Criteria { get; set; }
        
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

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel obj = new Panel();
            List<Panel> listofcstm = obj.List();
            if (comboBox1.SelectedItem.ToString() == "Customer Name")
            {
                List<Panel> list = obj.SortingByName(listofcstm);
                DataTable dt = Utility.ConvertToDataTable(list);
                gridReview.DataSource = dt;

            }
        }
    }
}
