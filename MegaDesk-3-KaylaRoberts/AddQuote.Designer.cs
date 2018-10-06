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
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
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
            this.widthInput.Location = new System.Drawing.Point(155, 73);
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
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            this.widthInput.Validated += new System.EventHandler(this.widthInput_Validated);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.cancelQuoteBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteBtn;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthInput;
    }
}