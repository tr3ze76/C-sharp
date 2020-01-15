namespace Chapter05Stringmeyhod
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.lblToLower = new System.Windows.Forms.Label();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.lblSearchChar = new System.Windows.Forms.Label();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.lblLastChar = new System.Windows.Forms.Label();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.lblStartIndex = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.lblIndetxtRemoveResultxOf = new System.Windows.Forms.Label();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.lblEndIndex = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtSubStringResult = new System.Windows.Forms.TextBox();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.lblReplaceChars = new System.Windows.Forms.Label();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.lblReplaceResult = new System.Windows.Forms.Label();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(222, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(569, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.SystemColors.Control;
            this.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInput.Location = new System.Drawing.Point(38, 27);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(160, 20);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "String to test";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.SystemColors.Control;
            this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLength.Location = new System.Drawing.Point(38, 61);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(160, 20);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "String Length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(222, 61);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(40, 20);
            this.txtLength.TabIndex = 4;
            // 
            // lblToUpper
            // 
            this.lblToUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToUpper.Location = new System.Drawing.Point(38, 95);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(160, 20);
            this.lblToUpper.TabIndex = 5;
            this.lblToUpper.Text = "String.To.Upper();";
            this.lblToUpper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(222, 96);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(569, 20);
            this.txtToUpper.TabIndex = 6;
            // 
            // lblToLower
            // 
            this.lblToLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToLower.Location = new System.Drawing.Point(38, 133);
            this.lblToLower.Name = "lblToLower";
            this.lblToLower.Size = new System.Drawing.Size(160, 20);
            this.lblToLower.TabIndex = 7;
            this.lblToLower.Text = "String.ToLower();";
            this.lblToLower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(222, 134);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(569, 20);
            this.txtToLower.TabIndex = 8;
            // 
            // lblSearchChar
            // 
            this.lblSearchChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearchChar.Location = new System.Drawing.Point(38, 163);
            this.lblSearchChar.Name = "lblSearchChar";
            this.lblSearchChar.Size = new System.Drawing.Size(160, 20);
            this.lblSearchChar.TabIndex = 9;
            this.lblSearchChar.Text = "Search for character";
            this.lblSearchChar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(222, 164);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(31, 20);
            this.txtSearchChar.TabIndex = 10;
            // 
            // lblLastChar
            // 
            this.lblLastChar.BackColor = System.Drawing.SystemColors.Control;
            this.lblLastChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastChar.Location = new System.Drawing.Point(38, 197);
            this.lblLastChar.Name = "lblLastChar";
            this.lblLastChar.Size = new System.Drawing.Size(160, 20);
            this.lblLastChar.TabIndex = 11;
            this.lblLastChar.Text = "Search for the last character";
            this.lblLastChar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(222, 198);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(31, 20);
            this.txtLastChar.TabIndex = 12;
            // 
            // lblStartIndex
            // 
            this.lblStartIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartIndex.Location = new System.Drawing.Point(38, 230);
            this.lblStartIndex.Name = "lblStartIndex";
            this.lblStartIndex.Size = new System.Drawing.Size(160, 20);
            this.lblStartIndex.TabIndex = 13;
            this.lblStartIndex.Text = "Extract Substring from index";
            this.lblStartIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemove
            // 
            this.lblRemove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemove.Location = new System.Drawing.Point(38, 263);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(160, 20);
            this.lblRemove.TabIndex = 14;
            this.lblRemove.Text = "txtInput Remove()=";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(222, 231);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(40, 20);
            this.txtStartIndex.TabIndex = 15;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(222, 263);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(127, 20);
            this.txtRemove.TabIndex = 16;
            // 
            // lblIndetxtRemoveResultxOf
            // 
            this.lblIndetxtRemoveResultxOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndetxtRemoveResultxOf.Location = new System.Drawing.Point(288, 167);
            this.lblIndetxtRemoveResultxOf.Name = "lblIndetxtRemoveResultxOf";
            this.lblIndetxtRemoveResultxOf.Size = new System.Drawing.Size(300, 20);
            this.lblIndetxtRemoveResultxOf.TabIndex = 17;
            this.lblIndetxtRemoveResultxOf.Text = "txtInput.Text.TextIndexOf(\"v\".0)=";
            this.lblIndetxtRemoveResultxOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(617, 164);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(35, 20);
            this.txtSearchIndex.TabIndex = 18;
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.Location = new System.Drawing.Point(288, 198);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(300, 20);
            this.lblLastIndexOf.TabIndex = 19;
            this.lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"s\")=";
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(617, 198);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(35, 20);
            this.txtLastIndexOf.TabIndex = 20;
            // 
            // lblEndIndex
            // 
            this.lblEndIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndIndex.Location = new System.Drawing.Point(288, 230);
            this.lblEndIndex.Name = "lblEndIndex";
            this.lblEndIndex.Size = new System.Drawing.Size(150, 20);
            this.lblEndIndex.TabIndex = 21;
            this.lblEndIndex.Text = "for this many characters";
            this.lblEndIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(459, 230);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(28, 20);
            this.txtEndIndex.TabIndex = 22;
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.Location = new System.Drawing.Point(503, 234);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(150, 20);
            this.lblSubstring.TabIndex = 23;
            this.lblSubstring.Text = "txtInput.Textsubstring(18, 70) =";
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubStringResult
            // 
            this.txtSubStringResult.Location = new System.Drawing.Point(669, 230);
            this.txtSubStringResult.Name = "txtSubStringResult";
            this.txtSubStringResult.Size = new System.Drawing.Size(122, 20);
            this.txtSubStringResult.TabIndex = 24;
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(365, 263);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(426, 20);
            this.txtRemoveResult.TabIndex = 25;
            // 
            // lblReplaceChars
            // 
            this.lblReplaceChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReplaceChars.Location = new System.Drawing.Point(38, 302);
            this.lblReplaceChars.Name = "lblReplaceChars";
            this.lblReplaceChars.Size = new System.Drawing.Size(160, 20);
            this.lblReplaceChars.TabIndex = 26;
            this.lblReplaceChars.Text = "Find";
            this.lblReplaceChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(222, 302);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(127, 20);
            this.txtReplaceChars.TabIndex = 27;
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReplaceWith.Location = new System.Drawing.Point(375, 303);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(98, 20);
            this.lblReplaceWith.TabIndex = 28;
            this.lblReplaceWith.Text = "Replace with";
            this.lblReplaceWith.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(503, 303);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceWith.TabIndex = 29;
            // 
            // lblReplaceResult
            // 
            this.lblReplaceResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReplaceResult.Location = new System.Drawing.Point(38, 342);
            this.lblReplaceResult.Name = "lblReplaceResult";
            this.lblReplaceResult.Size = new System.Drawing.Size(160, 20);
            this.lblReplaceResult.TabIndex = 30;
            this.lblReplaceResult.Text = "txtInput.Replace";
            this.lblReplaceResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(222, 342);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(569, 20);
            this.txtReplaceResult.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 20);
            this.button1.TabIndex = 32;
            this.button1.Text = "&Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 20);
            this.button2.TabIndex = 33;
            this.button2.Text = "C&lose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.lblReplaceResult);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.lblReplaceWith);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.lblReplaceChars);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.txtSubStringResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.lblEndIndex);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.lblIndetxtRemoveResultxOf);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblStartIndex);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.lblLastChar);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.lblSearchChar);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.lblToLower);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "String Tester";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblToUpper;
        private System.Windows.Forms.TextBox txtToUpper;
        private System.Windows.Forms.Label lblToLower;
        private System.Windows.Forms.TextBox txtToLower;
        private System.Windows.Forms.Label lblSearchChar;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.Label lblLastChar;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.Label lblStartIndex;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label lblIndetxtRemoveResultxOf;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.Label lblLastIndexOf;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.Label lblEndIndex;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.TextBox txtSubStringResult;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.Label lblReplaceChars;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.Label lblReplaceWith;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label lblReplaceResult;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

