namespace MegaDesk_3_KaylaRoberts
{
    partial class ViewAllQuotes
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
            this.cancelQuoteBtn = new System.Windows.Forms.Button();
            this.quotesGrid = new System.Windows.Forms.DataGridView();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteBtn
            // 
            this.cancelQuoteBtn.Location = new System.Drawing.Point(563, 373);
            this.cancelQuoteBtn.Name = "cancelQuoteBtn";
            this.cancelQuoteBtn.Size = new System.Drawing.Size(225, 65);
            this.cancelQuoteBtn.TabIndex = 1;
            this.cancelQuoteBtn.Text = "Cancel";
            this.cancelQuoteBtn.UseVisualStyleBackColor = true;
            this.cancelQuoteBtn.Click += new System.EventHandler(this.cancelQuoteBtn_Click);
            // 
            // quotesGrid
            // 
            this.quotesGrid.AllowUserToAddRows = false;
            this.quotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuoteDate,
            this.customerName,
            this.depth,
            this.width,
            this.numOfDrawers,
            this.surfaceMaterial,
            this.shipping,
            this.price});
            this.quotesGrid.Location = new System.Drawing.Point(8, 122);
            this.quotesGrid.Name = "quotesGrid";
            this.quotesGrid.RowHeadersVisible = false;
            this.quotesGrid.Size = new System.Drawing.Size(780, 209);
            this.quotesGrid.TabIndex = 2;
            // 
            // QuoteDate
            // 
            this.QuoteDate.DataPropertyName = "QuoteDate";
            this.QuoteDate.Frozen = true;
            this.QuoteDate.HeaderText = "Date/Time";
            this.QuoteDate.Name = "QuoteDate";
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "CustomerName";
            this.customerName.Frozen = true;
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            // 
            // depth
            // 
            this.depth.DataPropertyName = "Depth";
            this.depth.Frozen = true;
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            // 
            // width
            // 
            this.width.DataPropertyName = "Width";
            this.width.Frozen = true;
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.DataPropertyName = "NumOfDrawers";
            this.numOfDrawers.Frozen = true;
            this.numOfDrawers.HeaderText = "Number of Drawers";
            this.numOfDrawers.Name = "numOfDrawers";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.DataPropertyName = "DeskMaterial";
            this.surfaceMaterial.HeaderText = "Surface Material";
            this.surfaceMaterial.Name = "surfaceMaterial";
            // 
            // shipping
            // 
            this.shipping.DataPropertyName = "Shipping";
            this.shipping.HeaderText = "Shipping";
            this.shipping.Name = "shipping";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quotesGrid);
            this.Controls.Add(this.cancelQuoteBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteBtn;
        private System.Windows.Forms.DataGridView quotesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}