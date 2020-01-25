namespace Chapter09ProgramClassDessign
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblLeapYearResult = new System.Windows.Forms.Label();
            this.lblEasterResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // l
            // 
            this.l.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l.Location = new System.Drawing.Point(24, 37);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(146, 23);
            this.l.TabIndex = 2;
            this.l.Text = "Enter Year";
            this.l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(193, 40);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 3;
            // 
            // lblLeapYearResult
            // 
            this.lblLeapYearResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeapYearResult.Location = new System.Drawing.Point(24, 161);
            this.lblLeapYearResult.Name = "lblLeapYearResult";
            this.lblLeapYearResult.Size = new System.Drawing.Size(269, 23);
            this.lblLeapYearResult.TabIndex = 4;
            // 
            // lblEasterResult
            // 
            this.lblEasterResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEasterResult.Location = new System.Drawing.Point(24, 214);
            this.lblEasterResult.Name = "lblEasterResult";
            this.lblEasterResult.Size = new System.Drawing.Size(269, 23);
            this.lblEasterResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 272);
            this.Controls.Add(this.lblEasterResult);
            this.Controls.Add(this.lblLeapYearResult);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.l);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblLeapYearResult;
        private System.Windows.Forms.Label lblEasterResult;
    }
}

