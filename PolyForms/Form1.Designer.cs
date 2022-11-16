namespace PolyForms
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
			this.InvoiceDataGrid = new System.Windows.Forms.DataGridView();
			this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qauntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// InvoiceDataGrid
			// 
			this.InvoiceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.InvoiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InvoiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice,
            this.Qauntity,
            this.PartDescription,
            this.Price});
			this.InvoiceDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InvoiceDataGrid.Location = new System.Drawing.Point(0, 0);
			this.InvoiceDataGrid.Name = "InvoiceDataGrid";
			this.InvoiceDataGrid.Size = new System.Drawing.Size(800, 450);
			this.InvoiceDataGrid.TabIndex = 0;
			this.InvoiceDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Invoice
			// 
			this.Invoice.HeaderText = "Invoice";
			this.Invoice.Name = "Invoice";
			this.Invoice.Width = 67;
			// 
			// Qauntity
			// 
			this.Qauntity.HeaderText = "Quantity";
			this.Qauntity.Name = "Qauntity";
			this.Qauntity.Width = 71;
			// 
			// PartDescription
			// 
			this.PartDescription.HeaderText = "Part Description";
			this.PartDescription.Name = "PartDescription";
			this.PartDescription.Width = 98;
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.Width = 56;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.InvoiceDataGrid);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView InvoiceDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qauntity;
		private System.Windows.Forms.DataGridViewTextBoxColumn PartDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
	}
}

