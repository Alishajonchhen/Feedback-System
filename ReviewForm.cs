using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void update()
        {
            ArrayList feedback = new ArrayList();
            feedback.Add("Excellent");
            feedback.Add("Very Good");
            feedback.Add("Good");
            feedback.Add("Average");
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

        //click event to submit form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSend.Text == "Send Feedback")
            {
                string path = "customerReviews.csv";
                string line = "";
                int count_row = CustomerGrid.RowCount;
                int count_cell = CustomerGrid.Rows[0].Cells.Count;

                string reviewername = txtName.Text;
                string reviewerphone = txtNumber.Text;
                string revieweremail = txtEmail.Text;
                string reviewersuggest = txtSuggest.Text;
                string timer = time.Text;
                line = line + reviewername + "," + reviewerphone + "," + revieweremail + "," + reviewersuggest + "," + timer + ",";

                for (int row_index = 0; row_index <= count_row - 1; row_index++)
                {
                    int counter = 0;
                    for (int cell_index = count_cell - 1; cell_index <= count_cell - 1; cell_index++)
                    {
                        string value1 = "";
                        try
                        {
                            if (CustomerGrid.Rows[row_index].Cells[counter].Value.ToString() == null)
                            {
                                MessageBox.Show("Empty");
                            }
                            else
                            {
                                value1 = CustomerGrid.Rows[row_index].Cells[counter].Value.ToString();
                                int stringValue = 0;
                                if (value1 == "Excellent")
                                {
                                    stringValue = 5;
                                }
                                else if (value1 == "Very Good")
                                {
                                    stringValue = 4;
                                }
                                else if (value1 == "Good")
                                {
                                    stringValue = 3;
                                }
                                else if (value1 == "Average")
                                {
                                    stringValue = 2;
                                }
                                else if (value1 == "Dissatisfied")
                                {
                                    stringValue = 1;
                                }
                               
                                txtresult.Text = txtresult.Text + stringValue.ToString();
                                counter++;
                                if (row_index < count_row - 1)
                                {
                                    txtresult.Text = txtresult.Text + ",";
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong.");
                        }

                    }

                }

                txtresult.Text = line + txtresult.Text;
                string result = txtresult.Text;
                File.AppendAllText(path: path,
                       result + Environment.NewLine);
                txtresult.Text = "";
            }
            Clear();
            string title = "Message";
            MessageBox.Show("Record Added Successfully.", title);


        }

        public void Clear()
        {
            //clearing the fields
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
            Clear();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
           
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
