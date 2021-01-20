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
            this.Sort = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.llbSort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReview
            // 
            this.gridReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReview.Location = new System.Drawing.Point(18, 61);
            this.gridReview.Name = "gridReview";
            this.gridReview.Size = new System.Drawing.Size(536, 269);
            this.gridReview.TabIndex = 0;
            this.gridReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReview_CellContentClick);
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.Location = new System.Drawing.Point(799, 56);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(65, 20);
            this.Sort.TabIndex = 5;
            this.Sort.Text = "Sort By:";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Customer Name"});
            this.cmbSort.Location = new System.Drawing.Point(870, 54);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(580, 21);
            this.cmbSort.TabIndex = 6;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // llbSort
            // 
            this.llbSort.AutoSize = true;
            this.llbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSort.Location = new System.Drawing.Point(352, 33);
            this.llbSort.Name = "llbSort";
            this.llbSort.Size = new System.Drawing.Size(61, 18);
            this.llbSort.TabIndex = 7;
            this.llbSort.Text = "Sort By:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer Name"});
            this.comboBox1.Location = new System.Drawing.Point(419, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(708, 360);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.llbSort);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.gridReview);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReview;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label llbSort;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}