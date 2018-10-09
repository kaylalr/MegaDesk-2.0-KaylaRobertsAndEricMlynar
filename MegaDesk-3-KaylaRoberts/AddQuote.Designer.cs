namespace MegaDesk_3_KaylaRoberts
{
    partial class AddQuote
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialDropDown = new System.Windows.Forms.ComboBox();
            this.shippingDropDown = new System.Windows.Forms.ComboBox();
            this.shippingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteBtn
            // 
            this.cancelQuoteBtn.Location = new System.Drawing.Point(12, 373);
            this.cancelQuoteBtn.Name = "cancelQuoteBtn";
            this.cancelQuoteBtn.Size = new System.Drawing.Size(225, 65);
            this.cancelQuoteBtn.TabIndex = 0;
            this.cancelQuoteBtn.Text = "Cancel";
            this.cancelQuoteBtn.UseVisualStyleBackColor = true;
            this.cancelQuoteBtn.Click += new System.EventHandler(this.cancelQuoteBtn_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(76, 74);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(54, 20);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width:";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(253, 73);
            this.widthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(120, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(253, 115);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(120, 20);
            this.depthInput.TabIndex = 4;
            this.depthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(76, 116);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(57, 20);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth:";
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(253, 162);
            this.drawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(120, 20);
            this.drawersInput.TabIndex = 6;
            this.drawersInput.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(76, 163);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(150, 20);
            this.drawersLabel.TabIndex = 5;
            this.drawersLabel.Text = "Number of Drawers:";
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(79, 203);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.surfaceMaterialLabel.TabIndex = 7;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            // 
            // surfaceMaterialDropDown
            // 
            this.surfaceMaterialDropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterialDropDown.FormattingEnabled = true;
            this.surfaceMaterialDropDown.Location = new System.Drawing.Point(253, 201);
            this.surfaceMaterialDropDown.Name = "surfaceMaterialDropDown";
            this.surfaceMaterialDropDown.Size = new System.Drawing.Size(121, 21);
            this.surfaceMaterialDropDown.TabIndex = 9;
            // 
            // shippingDropDown
            // 
            this.shippingDropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "Normal (14 days)",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.shippingDropDown.FormattingEnabled = true;
            this.shippingDropDown.Location = new System.Drawing.Point(253, 242);
            this.shippingDropDown.Name = "shippingDropDown";
            this.shippingDropDown.Size = new System.Drawing.Size(121, 21);
            this.shippingDropDown.TabIndex = 11;
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingLabel.Location = new System.Drawing.Point(79, 244);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(75, 20);
            this.shippingLabel.TabIndex = 10;
            this.shippingLabel.Text = "Shipping:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shippingDropDown);
            this.Controls.Add(this.shippingLabel);
            this.Controls.Add(this.surfaceMaterialDropDown);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.cancelQuoteBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteBtn;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.ComboBox surfaceMaterialDropDown;
        private System.Windows.Forms.ComboBox shippingDropDown;
        private System.Windows.Forms.Label shippingLabel;
    }
}