namespace BMICal
{
    partial class bmiCal
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
            this.lblHight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWwight = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHight
            // 
            this.lblHight.AutoSize = true;
            this.lblHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHight.Location = new System.Drawing.Point(165, 120);
            this.lblHight.Name = "lblHight";
            this.lblHight.Size = new System.Drawing.Size(74, 25);
            this.lblHight.TabIndex = 0;
            this.lblHight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(165, 169);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(79, 25);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight";
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.Location = new System.Drawing.Point(165, 218);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(49, 25);
            this.lblBmi.TabIndex = 0;
            this.lblBmi.Text = "BMI";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(301, 117);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(243, 31);
            this.txtHeight.TabIndex = 1;
            // 
            // txtWwight
            // 
            this.txtWwight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWwight.Location = new System.Drawing.Point(301, 166);
            this.txtWwight.Name = "txtWwight";
            this.txtWwight.Size = new System.Drawing.Size(243, 31);
            this.txtWwight.TabIndex = 1;
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(301, 215);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(243, 31);
            this.txtBMI.TabIndex = 1;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(573, 117);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(156, 198);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Claculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(170, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(374, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // bmiCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 498);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtWwight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHight);
            this.Name = "bmiCal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWwight;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
    }
}

