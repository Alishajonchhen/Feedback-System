using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CustomerReview
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
            timer1.Start();
            //Update data grid view
            update();
        }

        //click event to submit form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSend.Text == "Send Feedback")
            {
                Panel r = new Panel(); // creating object for class Panel
                r.CustomerName = txtName.Text;
                r.CustomerNumber = txtNumber.Text;
                r.CustomerEmail = txtEmail.Text;
                r.Suggestion = txtSuggest.Text;
                r.Timer = time.Text;
                
                string flag = r.Save(r);

                ClearForm();

                string title = "Message";
                MessageBox.Show("Record added successfully.", title);


            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
            txtSuggest.Text = "";

            
        }


        private void AdminLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //navigating to another login window
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing the fields
            ClearForm();
            
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
           
        }

        public void update()
        {
            ArrayList feedback = new ArrayList();
            feedback.Add("Excellent");
            feedback.Add(" Very Good");
            feedback.Add("Good");
            feedback.Add("Satisfied");
            feedback.Add("Dissatisfied");

            Requirements obj = new Requirements();
            List<Requirements> criteria = obj.List();
            DataTable dt = Utility.ConvertToDataTable(criteria);

            CustomerGrid.DataSource = dt;
            
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Ratings";
            cmb.Name = "Ratings";
            cmb.Items.AddRange(feedback.ToArray());
            CustomerGrid.Columns.Add(cmb);

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time.Text = dateTime.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}
