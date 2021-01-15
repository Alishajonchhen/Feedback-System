namespace CustomerReview
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridReview = new System.Windows.Forms.DataGridView();
            this.admin = new System.Windows.Forms.Label();
            this.criteria = new System.Windows.Forms.Label();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReview
            // 
            this.gridReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReview.Location = new System.Drawing.Point(297, 37);
            this.gridReview.Name = "gridReview";
            this.gridReview.Size = new System.Drawing.Size(721, 251);
            this.gridReview.TabIndex = 0;
            this.gridReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReview_CellContentClick);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(27, 37);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(133, 25);
            this.admin.TabIndex = 1;
            this.admin.Text = "Admin Panel";
            // 
            // criteria
            // 
            this.criteria.AutoSize = true;
            this.criteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteria.Location = new System.Drawing.Point(32, 88);
            this.criteria.Name = "criteria";
            this.criteria.Size = new System.Drawing.Size(59, 20);
            this.criteria.TabIndex = 2;
            this.criteria.Text = "Criteria";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(36, 130);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(207, 20);
            this.txtCriteria.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(36, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Criteria";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1064, 534);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.criteria);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.gridReview);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReview;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label criteria;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button btnAdd;
    }
}