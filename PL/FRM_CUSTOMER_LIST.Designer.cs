namespace WarehouseManagementSystem1.PL
{
    partial class FRM_CUSTOMER_LIST
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
            this.DGVCUSTOMER = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCUSTOMER)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCUSTOMER
            // 
            this.DGVCUSTOMER.AllowUserToAddRows = false;
            this.DGVCUSTOMER.AllowUserToDeleteRows = false;
            this.DGVCUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCUSTOMER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.DGVCUSTOMER.Name = "DGVCUSTOMER";
            this.DGVCUSTOMER.ReadOnly = true;
            this.DGVCUSTOMER.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVCUSTOMER.Size = new System.Drawing.Size(842, 444);
            this.DGVCUSTOMER.TabIndex = 0;
            this.DGVCUSTOMER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCUSTOMER_CellContentClick);
            this.DGVCUSTOMER.DoubleClick += new System.EventHandler(this.DGVCUSTOMER_DoubleClick);
            // 
            // FRM_CUSTOMER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 444);
            this.Controls.Add(this.DGVCUSTOMER);
            this.Name = "FRM_CUSTOMER_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحه جميع العملاء";
            this.Load += new System.EventHandler(this.FRM_CUSTOMER_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCUSTOMER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVCUSTOMER;

    }
}