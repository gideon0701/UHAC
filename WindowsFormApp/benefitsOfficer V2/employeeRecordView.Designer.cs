namespace benefitsOfficer_V2
{
    partial class employeeRecordView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.recordDataGrid = new MetroFramework.Controls.MetroGrid();
            this.myhealthDbDataSet = new benefitsOfficer_V2.myhealthDbDataSet();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsTableAdapter = new benefitsOfficer_V2.myhealthDbDataSetTableAdapters.RecordsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availmentClaimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coveredBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhealthDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.printBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 52);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // recordDataGrid
            // 
            this.recordDataGrid.AllowUserToAddRows = false;
            this.recordDataGrid.AllowUserToDeleteRows = false;
            this.recordDataGrid.AllowUserToResizeRows = false;
            this.recordDataGrid.AutoGenerateColumns = false;
            this.recordDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.recordDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.recordDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recordDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.availmentClaimDataGridViewTextBoxColumn,
            this.healthCardDataGridViewTextBoxColumn,
            this.hospitalDataGridViewTextBoxColumn,
            this.coveredBillDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.recordDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.recordDataGrid.DataSource = this.recordsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.recordDataGrid.EnableHeadersVisualStyles = false;
            this.recordDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.recordDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recordDataGrid.Location = new System.Drawing.Point(0, 52);
            this.recordDataGrid.Name = "recordDataGrid";
            this.recordDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.recordDataGrid.RowHeadersVisible = false;
            this.recordDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.recordDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recordDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordDataGrid.Size = new System.Drawing.Size(600, 393);
            this.recordDataGrid.TabIndex = 1;
            this.recordDataGrid.UseCustomBackColor = true;
            this.recordDataGrid.UseCustomForeColor = true;
            this.recordDataGrid.UseStyleColors = true;
            // 
            // myhealthDbDataSet
            // 
            this.myhealthDbDataSet.DataSetName = "myhealthDbDataSet";
            this.myhealthDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "Records";
            this.recordsBindingSource.DataSource = this.myhealthDbDataSet;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // availmentClaimDataGridViewTextBoxColumn
            // 
            this.availmentClaimDataGridViewTextBoxColumn.DataPropertyName = "Availment/Claim";
            this.availmentClaimDataGridViewTextBoxColumn.HeaderText = "Availment/Claim";
            this.availmentClaimDataGridViewTextBoxColumn.Name = "availmentClaimDataGridViewTextBoxColumn";
            // 
            // healthCardDataGridViewTextBoxColumn
            // 
            this.healthCardDataGridViewTextBoxColumn.DataPropertyName = "Health Card";
            this.healthCardDataGridViewTextBoxColumn.HeaderText = "Health Card";
            this.healthCardDataGridViewTextBoxColumn.Name = "healthCardDataGridViewTextBoxColumn";
            // 
            // hospitalDataGridViewTextBoxColumn
            // 
            this.hospitalDataGridViewTextBoxColumn.DataPropertyName = "Hospital";
            this.hospitalDataGridViewTextBoxColumn.HeaderText = "Hospital";
            this.hospitalDataGridViewTextBoxColumn.Name = "hospitalDataGridViewTextBoxColumn";
            // 
            // coveredBillDataGridViewTextBoxColumn
            // 
            this.coveredBillDataGridViewTextBoxColumn.DataPropertyName = "Covered Bill";
            this.coveredBillDataGridViewTextBoxColumn.HeaderText = "Covered Bill";
            this.coveredBillDataGridViewTextBoxColumn.Name = "coveredBillDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Location = new System.Drawing.Point(22, 23);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 0;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // employeeRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 445);
            this.ControlBox = false;
            this.Controls.Add(this.recordDataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeRecordView";
            this.Text = "employeeRecordView";
            this.Load += new System.EventHandler(this.employeeRecordView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhealthDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid recordDataGrid;
        private myhealthDbDataSet myhealthDbDataSet;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private myhealthDbDataSetTableAdapters.RecordsTableAdapter recordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availmentClaimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coveredBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button printBtn;
    }
}