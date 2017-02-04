namespace _01.BGNtoEurConverter
{
    partial class FormConverter
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
            this.Convert = new System.Windows.Forms.Label();
            this.BGNtoEUR = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.AutoSize = true;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(53, 44);
            this.Convert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(81, 25);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            // 
            // BGNtoEUR
            // 
            this.BGNtoEUR.AutoSize = true;
            this.BGNtoEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGNtoEUR.Location = new System.Drawing.Point(374, 44);
            this.BGNtoEUR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BGNtoEUR.Name = "BGNtoEUR";
            this.BGNtoEUR.Size = new System.Drawing.Size(120, 25);
            this.BGNtoEUR.TabIndex = 1;
            this.BGNtoEUR.Text = "BGN to EUR";
            this.BGNtoEUR.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(157, 39);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(160, 30);
            this.numericUpDownAmount.TabIndex = 2;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmmount_ValueChanged);
            this.numericUpDownAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownAmount_KeyUp);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.PaleGreen;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(53, 144);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(441, 51);
            this.labelResult.TabIndex = 3;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.BGNtoEUR);
            this.Controls.Add(this.Convert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConverter";
            this.Text = "BGN to EUR";
            this.Load += new System.EventHandler(this.FormConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Convert;
        private System.Windows.Forms.Label BGNtoEUR;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelResult;
    }
}

