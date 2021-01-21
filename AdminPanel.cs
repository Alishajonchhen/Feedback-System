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
        }
        DataTable dataTable = new DataTable();
        private void gridReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*private void BindGrid()
        {
            Panel obj = new Panel();
            List<Panel> listReview = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listReview);
            gridReview.DataSource = dt;
            //BindChart(listReview);
        }
        */
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                if (dataGridView1.Rows[0].IsNewRow != true)
                    dataGridView1.Rows.RemoveAt(0);
            }
            string[] allLines = System.IO.File.ReadAllLines("customerReviews.csv");
            string[] headers = allLines[0].Split(',');
            if (allLines.Length > 0)
            {
                foreach (string headerword in headers)
                {
                    dataTable.Columns.Add(headerword);
                }
                for (int i = 1; i <= allLines.Length - 1; i++)
                {
                    string[] dataWord = allLines[i].Split(',');
                    DataRow row = dataTable.NewRow();
                    int column = 0;
                    foreach (string headerWord in headers)
                    {
                        row[headerWord] = dataWord[column++];
                    }
                    dataTable.Rows.Add(row);
                }
            }
            dataGridView1.DataSource = dataTable;
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
