﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnReview_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminPanel());
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            openChildForm(new Graph());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCriteria());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
