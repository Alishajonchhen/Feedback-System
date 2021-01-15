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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        //click event to submit form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           if(btnSend.Text=="Send Feedback")
            {
                if (cmbFood.SelectedItem != null)
                {
                    if (cmbStaff.SelectedItem != null)
                    {
                        if (cmbClean.SelectedItem != null)
                        {
                            if (cmbAccuracy.SelectedItem != null)
                            {
                                if (cmbAmbiance.SelectedItem != null)
                                {
                                    if (cmbMoney.SelectedItem != null)
                                    {
                                        Panel r = new Panel(); // creating object for class Panel
                                        r.CustomerName = txtName.Text;
                                        r.CustomerNumber = txtNumber.Text;
                                        r.CustomerEmail = txtEmail.Text;
                                        r.FoodQuality = (string)cmbFood.SelectedItem;
                                        r.StaffFriendliness = (string)cmbStaff.SelectedItem;
                                        r.Cleanliness = (string)cmbClean.SelectedItem;
                                        r.OrderAccuracy = (string)cmbAccuracy.SelectedItem;
                                        r.RestAmbiance = (string)cmbAmbiance.SelectedItem;
                                        r.ValueMoney = (string)cmbMoney.SelectedItem;

                                        string flag = r.Save(r);

                                        ClearForm();

                                        string title = "Message";
                                        MessageBox.Show("Record added successfully.", title);
                                    }
                                    else
                                    {
                                        string title = "Alert";
                                        MessageBox.Show("Value of Money field cannot be empty!", title);
                                    }
                                }
                                else
                                {
                                    string title = "Alert";
                                    MessageBox.Show("Restuarant Ambiance field cannot be empty!", title);
                                }
                            }
                            else
                            {
                                string title = "Alert";                           
                                MessageBox.Show("Order Accuracy field cannot be empty!", title);
                            }
                        }
                        else 
                        {
                            string title = "Alert";
                            MessageBox.Show("Cleanliness field cannot be empty!", title);
                        }
                    }
                    else
                    {
                        string title = "Alert";
                        MessageBox.Show("Staff Friendliness field cannot be empty!", title);
                    }
                }
                else
                {
                    string title = "Alert";
                    MessageBox.Show("Food Quality field cannot be empty!", title);
                }
           }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
            cmbFood.SelectedIndex = -1;
            cmbStaff.SelectedIndex = -1;
            cmbClean.SelectedIndex = -1;
            cmbAccuracy.SelectedIndex = -1;
            cmbAmbiance.SelectedIndex = -1;
            cmbMoney.SelectedIndex = -1;
        }


        private void AdminLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            label10.Text = AdminPanel.SetValueForText1;
        }
    }
}
