namespace PolyForms
{
	partial class Ledgers
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabInvoices = new System.Windows.Forms.TabPage();
			this.invoiceGrid1 = new PolyForms.InvoiceGrid();
			this.tabControl1.SuspendLayout();
			this.tabInvoices.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabInvoices);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(766, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(192, 74);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Weekly Payout";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabInvoices
			// 
			this.tabInvoices.Controls.Add(this.invoiceGrid1);
			this.tabInvoices.Location = new System.Drawing.Point(4, 22);
			this.tabInvoices.Name = "tabInvoices";
			this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
			this.tabInvoices.Size = new System.Drawing.Size(758, 400);
			this.tabInvoices.TabIndex = 1;
			this.tabInvoices.Text = "Invoices";
			this.tabInvoices.UseVisualStyleBackColor = true;
			// 
			// invoiceGrid1
			// 
			this.invoiceGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.invoiceGrid1.Location = new System.Drawing.Point(3, 3);
			this.invoiceGrid1.Name = "invoiceGrid1";
			this.invoiceGrid1.Size = new System.Drawing.Size(752, 394);
			this.invoiceGrid1.TabIndex = 0;
			// 
			// Ledgers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Ledgers";
			this.Text = "Ledgers";
			this.tabControl1.ResumeLayout(false);
			this.tabInvoices.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabInvoices;
		private InvoiceGrid invoiceGrid1;
	}
}