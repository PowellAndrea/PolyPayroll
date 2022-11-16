namespace PolyForms
{
	partial class InvoiceGrid
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice,
            this.PartNumber,
            this.PartDescription,
            this.Price});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(343, 204);
			this.dataGridView1.TabIndex = 0;
			// 
			// Invoice
			// 
			this.Invoice.HeaderText = "Invoice";
			this.Invoice.Name = "Invoice";
			this.Invoice.ReadOnly = true;
			this.Invoice.Width = 67;
			// 
			// PartNumber
			// 
			this.PartNumber.HeaderText = "Part Number";
			this.PartNumber.Name = "PartNumber";
			this.PartNumber.Width = 91;
			// 
			// PartDescription
			// 
			this.PartDescription.HeaderText = "Description";
			this.PartDescription.Name = "PartDescription";
			this.PartDescription.Width = 85;
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.Width = 56;
			// 
			// InvoiceGrid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Name = "InvoiceGrid";
			this.Size = new System.Drawing.Size(343, 204);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
		private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn PartDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
	}
}
