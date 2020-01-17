namespace ROCKPAPERSCISSORS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnP1Rock = new System.Windows.Forms.Button();
            this.btnp2PAPER = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPLAYER1 = new System.Windows.Forms.Label();
            this.txtresults = new System.Windows.Forms.TextBox();
            this.butt = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.labelcpu = new System.Windows.Forms.Label();
            this.txtCPUResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnP1Rock
            // 
            this.btnP1Rock.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnP1Rock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnP1Rock.BackgroundImage")));
            this.btnP1Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnP1Rock.Location = new System.Drawing.Point(27, 94);
            this.btnP1Rock.Name = "btnP1Rock";
            this.btnP1Rock.Size = new System.Drawing.Size(75, 77);
            this.btnP1Rock.TabIndex = 0;
            this.btnP1Rock.Text = "&ROCK";
            this.btnP1Rock.UseVisualStyleBackColor = false;
            this.btnP1Rock.Click += new System.EventHandler(this.BtnP1Rock_Click);
            // 
            // btnp2PAPER
            // 
            this.btnp2PAPER.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnp2PAPER.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnp2PAPER.BackgroundImage")));
            this.btnp2PAPER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnp2PAPER.Location = new System.Drawing.Point(108, 94);
            this.btnp2PAPER.Name = "btnp2PAPER";
            this.btnp2PAPER.Size = new System.Drawing.Size(75, 77);
            this.btnp2PAPER.TabIndex = 1;
            this.btnp2PAPER.Text = "&PAPER";
            this.btnp2PAPER.UseVisualStyleBackColor = false;
            this.btnp2PAPER.Click += new System.EventHandler(this.Btnp2PAPER_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(189, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "&SCISSORS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // labelPLAYER1
            // 
            this.labelPLAYER1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPLAYER1.Location = new System.Drawing.Point(27, 43);
            this.labelPLAYER1.Name = "labelPLAYER1";
            this.labelPLAYER1.Size = new System.Drawing.Size(75, 20);
            this.labelPLAYER1.TabIndex = 6;
            this.labelPLAYER1.Text = "PLAYER1";
            this.labelPLAYER1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtresults
            // 
            this.txtresults.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtresults.Location = new System.Drawing.Point(27, 192);
            this.txtresults.Multiline = true;
            this.txtresults.Name = "txtresults";
            this.txtresults.ReadOnly = true;
            this.txtresults.Size = new System.Drawing.Size(503, 58);
            this.txtresults.TabIndex = 8;
            this.txtresults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butt
            // 
            this.butt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butt.Location = new System.Drawing.Point(27, 266);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(75, 23);
            this.butt.TabIndex = 9;
            this.butt.Text = "&PLAY";
            this.butt.UseVisualStyleBackColor = false;
            this.butt.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8.Location = new System.Drawing.Point(455, 266);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "E&XIT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // labelcpu
            // 
            this.labelcpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelcpu.Location = new System.Drawing.Point(350, 43);
            this.labelcpu.Name = "labelcpu";
            this.labelcpu.Size = new System.Drawing.Size(57, 20);
            this.labelcpu.TabIndex = 12;
            this.labelcpu.Text = "CPU";
            this.labelcpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPUResult
            // 
            this.txtCPUResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCPUResult.Location = new System.Drawing.Point(350, 112);
            this.txtCPUResult.Name = "txtCPUResult";
            this.txtCPUResult.Size = new System.Drawing.Size(87, 20);
            this.txtCPUResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 322);
            this.Controls.Add(this.txtCPUResult);
            this.Controls.Add(this.labelcpu);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.txtresults);
            this.Controls.Add(this.labelPLAYER1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnp2PAPER);
            this.Controls.Add(this.btnP1Rock);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "ROCPAPERSCISSORS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnP1Rock;
        private System.Windows.Forms.Button btnp2PAPER;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPLAYER1;
        private System.Windows.Forms.TextBox txtresults;
        private System.Windows.Forms.Button butt;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label labelcpu;
        private System.Windows.Forms.TextBox txtCPUResult;
    }
}

