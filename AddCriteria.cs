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
    public partial class AddCriteria : Form
    {
        public AddCriteria()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Requirements R = new Requirements();
            R.Criteria = txtCriteria.Text;

            string flag = R.Save(R);
            if (flag == "Success")
            {
                BindGrid();
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCriteria.Text = "";
        }
    }
}
