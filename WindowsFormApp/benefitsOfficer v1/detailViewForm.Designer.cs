namespace benefitsOfficer_v1
{
    partial class detailViewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recordGrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availmentClaimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coveredBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myhealthDbDataSet = new benefitsOfficer_v1.myhealthDbDataSet();
            this.recordsTableAdapter = new benefitsOfficer_v1.myhealthDbDataSetTableAdapters.recordsTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhealthDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // recordGrid
            // 
            this.recordGrid.AllowUserToAddRows = false;
            this.recordGrid.AllowUserToDeleteRows = false;
            this.recordGrid.AllowUserToResizeRows = false;
            this.recordGrid.AutoGenerateColumns = false;
            this.recordGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.recordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.availmentClaimDataGridViewTextBoxColumn,
            this.hospitalDataGridViewTextBoxColumn,
            this.coveredBillDataGridViewTextBoxColumn,
            this.healthCardDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.recordGrid.DataSource = this.recordsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordGrid.EnableHeadersVisualStyles = false;
            this.recordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.recordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recordGrid.Location = new System.Drawing.Point(23, 63);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.ReadOnly = true;
            this.recordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.recordGrid.RowHeadersVisible = false;
            this.recordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordGrid.Size = new System.Drawing.Size(560, 285);
            this.recordGrid.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Employee ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // availmentClaimDataGridViewTextBoxColumn
            // 
            this.availmentClaimDataGridViewTextBoxColumn.DataPropertyName = "Availment/Claim";
            this.availmentClaimDataGridViewTextBoxColumn.HeaderText = "Availment/Claim";
            this.availmentClaimDataGridViewTextBoxColumn.Name = "availmentClaimDataGridViewTextBoxColumn";
            this.availmentClaimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hospitalDataGridViewTextBoxColumn
            // 
            this.hospitalDataGridViewTextBoxColumn.DataPropertyName = "Hospital";
            this.hospitalDataGridViewTextBoxColumn.HeaderText = "Hospital";
            this.hospitalDataGridViewTextBoxColumn.Name = "hospitalDataGridViewTextBoxColumn";
            this.hospitalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coveredBillDataGridViewTextBoxColumn
            // 
            this.coveredBillDataGridViewTextBoxColumn.DataPropertyName = "Covered Bill";
            this.coveredBillDataGridViewTextBoxColumn.HeaderText = "Covered Bill";
            this.coveredBillDataGridViewTextBoxColumn.Name = "coveredBillDataGridViewTextBoxColumn";
            this.coveredBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // healthCardDataGridViewTextBoxColumn
            // 
            this.healthCardDataGridViewTextBoxColumn.DataPropertyName = "Health Card";
            this.healthCardDataGridViewTextBoxColumn.HeaderText = "Health Card";
            this.healthCardDataGridViewTextBoxColumn.Name = "healthCardDataGridViewTextBoxColumn";
            this.healthCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "records";
            this.recordsBindingSource.DataSource = this.myhealthDbDataSet;
            // 
            // myhealthDbDataSet
            // 
            this.myhealthDbDataSet.DataSetName = "myhealthDbDataSet";
            this.myhealthDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(399, 34);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Export ";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(491, 35);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Print";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 354);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(528, 10);
            this.metroProgressBar1.TabIndex = 3;
            // 
            // detailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 371);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.recordGrid);
            this.Name = "detailViewForm";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.detailViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhealthDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid recordGrid;
        private myhealthDbDataSet myhealthDbDataSet;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private myhealthDbDataSetTableAdapters.recordsTableAdapter recordsTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn availmentClaimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coveredBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}