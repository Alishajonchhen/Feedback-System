using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerReview
{
    public partial class AddCriteria : Form
    {
        public AddCriteria()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                Requirements R = new Requirements();
                R.Criteria = txtCriteria.Text;

                string flag = R.Save(R);
                if (flag == "Success")
                {
                    BindGrid();

                    string line = "Customer Name,Customer Number,Customer Email,Suggestions,Timer,";
                    writeCustomerReviewCsv(line);
                }
                string title = "Message";
                MessageBox.Show("Record Added Successfully.", title);
            }
        }
        public void writeCustomerReviewCsv(string line)
        {
            string newLineField = "";
            int count_row = criteriaGrid.RowCount;
            for (int i = 0; i < count_row - 1; i++)
            {
                newLineField = newLineField + criteriaGrid.Rows[i].Cells[0].Value.ToString() + ",";
            }
            newLineField = line + newLineField + txtCriteria.Text + "\n";
            File.WriteAllText("customerReviews.csv", newLineField);


        }
        public void BindGrid()
        {
            Requirements obj = new Requirements();
            List<Requirements> criteria = obj.List();
            DataTable dt = Utility.ConvertToDataTable(criteria);
            criteriaGrid.DataSource = dt;
        }

        private void AddCriteria_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void Clear()
        {
            txtCriteria.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = criteriaGrid.CurrentCell.RowIndex;
            criteriaGrid.Rows.RemoveAt(rowIndex);
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Requirements obj = new Requirements();
            List<Requirements> listofcstm = obj.List();
            if (cmbSort.SelectedItem.ToString() == "Criteria")
            {
                List<Requirements> list = obj.SortingByCriteria(listofcstm);
                DataTable dt = Utility.ConvertToDataTable(list);
                criteriaGrid.DataSource = dt;

            }
        }
    }
}
