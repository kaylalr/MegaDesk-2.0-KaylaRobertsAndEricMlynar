namespace MegaDesk_3_KaylaRoberts
{
    partial class SearchQuotes
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
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterialDropDown = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteBtn
            // 
            this.cancelQuoteBtn.Location = new System.Drawing.Point(534, 356);
            this.cancelQuoteBtn.Name = "cancelQuoteBtn";
            this.cancelQuoteBtn.Size = new System.Drawing.Size(225, 65);
            this.cancelQuoteBtn.TabIndex = 3;
            this.cancelQuoteBtn.Text = "Cancel";
            this.cancelQuoteBtn.UseVisualStyleBackColor = true;
            this.cancelQuoteBtn.Click += new System.EventHandler(this.cancelQuoteBtn_Click);
            // 
            // quotesGrid
            // 
            this.quotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTime,
            this.customerName,
            this.depth,
            this.width,
            this.numOfDrawers,
            this.surfaceMaterial,
            this.shipping,
            this.price});
            this.quotesGrid.Location = new System.Drawing.Point(10, 121);
            this.quotesGrid.Name = "quotesGrid";
            this.quotesGrid.RowHeadersVisible = false;
            this.quotesGrid.Size = new System.Drawing.Size(780, 209);
            this.quotesGrid.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Frozen = true;
            this.dateTime.HeaderText = "Date/Time";
            this.dateTime.Name = "dateTime";
            // 
            // customerName
            // 
            this.customerName.Frozen = true;
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            // 
            // depth
            // 
            this.depth.Frozen = true;
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            // 
            // width
            // 
            this.width.Frozen = true;
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.Frozen = true;
            this.numOfDrawers.HeaderText = "Number of Drawers";
            this.numOfDrawers.Name = "numOfDrawers";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.HeaderText = "Surface Material";
            this.surfaceMaterial.Name = "surfaceMaterial";
            // 
            // shipping
            // 
            this.shipping.HeaderText = "Shipping";
            this.shipping.Name = "shipping";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // surfaceMaterialDropDown
            // 
            this.surfaceMaterialDropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "Test",
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterialDropDown.FormattingEnabled = true;
            this.surfaceMaterialDropDown.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterialDropDown.Location = new System.Drawing.Point(229, 36);
            this.surfaceMaterialDropDown.Name = "surfaceMaterialDropDown";
            this.surfaceMaterialDropDown.Size = new System.Drawing.Size(201, 21);
            this.surfaceMaterialDropDown.TabIndex = 11;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(466, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.surfaceMaterialDropDown);
            this.Controls.Add(this.quotesGrid);
            this.Controls.Add(this.cancelQuoteBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteBtn;
        private System.Windows.Forms.DataGridView quotesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.ComboBox surfaceMaterialDropDown;
        private System.Windows.Forms.Button searchBtn;
    }
}