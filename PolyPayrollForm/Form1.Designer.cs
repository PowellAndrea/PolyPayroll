namespace PolyPayrollForm
{
	partial class Form1
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
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.FirstName = new System.Data.DataColumn();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataColumn6 = new System.Data.DataColumn();
			this.dataTable2 = new System.Data.DataTable();
			this.dataTable3 = new System.Data.DataTable();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "General Ledger";
			this.dataSet1.Namespace = "PolyPayroll-1";
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.FirstName,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
			this.dataTable1.TableName = "Salaried";
			// 
			// FirstName
			// 
			this.FirstName.Caption = "First Name";
			this.FirstName.ColumnName = "FirstName";
			// 
			// dataColumn1
			// 
			this.dataColumn1.Caption = "Last Name";
			this.dataColumn1.ColumnName = "LastName";
			// 
			// dataColumn2
			// 
			this.dataColumn2.Caption = "SSN";
			this.dataColumn2.ColumnName = "SSN";
			// 
			// dataColumn3
			// 
			this.dataColumn3.Caption = "Type";
			this.dataColumn3.ColumnName = "Type";
			// 
			// dataColumn4
			// 
			this.dataColumn4.Caption = "Salary";
			this.dataColumn4.ColumnName = "Salary";
			// 
			// dataColumn5
			// 
			this.dataColumn5.Caption = "Earned";
			this.dataColumn5.ColumnName = "Earned";
			this.dataColumn5.DataType = typeof(decimal);
			// 
			// dataColumn6
			// 
			this.dataColumn6.Caption = "Part Description";
			this.dataColumn6.ColumnName = "Column1";
			// 
			// dataTable2
			// 
			this.dataTable2.TableName = "Hourly";
			// 
			// dataTable3
			// 
			this.dataTable3.TableName = "Invoices";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn FirstName;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataTable dataTable2;
		private System.Data.DataTable dataTable3;
	}
}

