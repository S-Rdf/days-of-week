namespace Days.of.Week
{
    partial class frmMain
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
            this.btnShowDay = new System.Windows.Forms.Button();
            this.txbDayNO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowDay
            // 
            this.btnShowDay.Location = new System.Drawing.Point(100, 113);
            this.btnShowDay.Name = "btnShowDay";
            this.btnShowDay.Size = new System.Drawing.Size(75, 23);
            this.btnShowDay.TabIndex = 0;
            this.btnShowDay.Text = "نمایش روز هفته";
            this.btnShowDay.UseVisualStyleBackColor = true;
            this.btnShowDay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbDayNO
            // 
            this.txbDayNO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbDayNO.Location = new System.Drawing.Point(65, 77);
            this.txbDayNO.Name = "txbDayNO";
            this.txbDayNO.Size = new System.Drawing.Size(160, 20);
            this.txbDayNO.TabIndex = 1;
            this.txbDayNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbDayNO);
            this.Controls.Add(this.btnShowDay);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDay;
        private System.Windows.Forms.TextBox txbDayNO;
    }
}