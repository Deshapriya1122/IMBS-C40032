namespace Withdrawapp
{
    partial class withdrawApp
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
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.balanceTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // amountTxt
            // 
            this.amountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTxt.Location = new System.Drawing.Point(155, 135);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(362, 38);
            this.amountTxt.TabIndex = 0;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(155, 190);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(362, 40);
            this.withdrawBtn.TabIndex = 1;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // balanceTxt
            // 
            this.balanceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTxt.Location = new System.Drawing.Point(155, 250);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(362, 26);
            this.balanceTxt.TabIndex = 0;
            // 
            // withdrawApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 475);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.balanceTxt);
            this.Controls.Add(this.amountTxt);
            this.Name = "withdrawApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.TextBox balanceTxt;
    }
}

