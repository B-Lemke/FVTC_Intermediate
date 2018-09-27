namespace BJL.TestScoreArrays.UI
{
    partial class frmArrays
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
            this.txtInputScore = new System.Windows.Forms.TextBox();
            this.btnAddArray1 = new System.Windows.Forms.Button();
            this.btnAddArray2 = new System.Windows.Forms.Button();
            this.btnAddArray3 = new System.Windows.Forms.Button();
            this.btnAddArray4 = new System.Windows.Forms.Button();
            this.btnDisplayArray = new System.Windows.Forms.Button();
            this.lstDisplayArray = new System.Windows.Forms.ListBox();
            this.lblAverageOfElements = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumOfElements = new System.Windows.Forms.Label();
            this.lblSumOfElements = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddArray5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputScore
            // 
            this.txtInputScore.Location = new System.Drawing.Point(8, 18);
            this.txtInputScore.Name = "txtInputScore";
            this.txtInputScore.Size = new System.Drawing.Size(100, 20);
            this.txtInputScore.TabIndex = 0;
            // 
            // btnAddArray1
            // 
            this.btnAddArray1.Location = new System.Drawing.Point(8, 46);
            this.btnAddArray1.Name = "btnAddArray1";
            this.btnAddArray1.Size = new System.Drawing.Size(100, 23);
            this.btnAddArray1.TabIndex = 1;
            this.btnAddArray1.Text = "Add to Array #1";
            this.btnAddArray1.UseVisualStyleBackColor = true;
            this.btnAddArray1.Click += new System.EventHandler(this.btnAddArray1_Click);
            // 
            // btnAddArray2
            // 
            this.btnAddArray2.Location = new System.Drawing.Point(8, 75);
            this.btnAddArray2.Name = "btnAddArray2";
            this.btnAddArray2.Size = new System.Drawing.Size(100, 23);
            this.btnAddArray2.TabIndex = 2;
            this.btnAddArray2.Text = "Add to Array #2";
            this.btnAddArray2.UseVisualStyleBackColor = true;
            this.btnAddArray2.Click += new System.EventHandler(this.btnAddArray2_Click);
            // 
            // btnAddArray3
            // 
            this.btnAddArray3.Location = new System.Drawing.Point(8, 104);
            this.btnAddArray3.Name = "btnAddArray3";
            this.btnAddArray3.Size = new System.Drawing.Size(100, 23);
            this.btnAddArray3.TabIndex = 3;
            this.btnAddArray3.Text = "Add to Array #3";
            this.btnAddArray3.UseVisualStyleBackColor = true;
            this.btnAddArray3.Click += new System.EventHandler(this.btnAddArray3_Click);
            // 
            // btnAddArray4
            // 
            this.btnAddArray4.Location = new System.Drawing.Point(8, 133);
            this.btnAddArray4.Name = "btnAddArray4";
            this.btnAddArray4.Size = new System.Drawing.Size(100, 23);
            this.btnAddArray4.TabIndex = 4;
            this.btnAddArray4.Text = "Add to Array #4";
            this.btnAddArray4.UseVisualStyleBackColor = true;
            this.btnAddArray4.Click += new System.EventHandler(this.btnAddArray4_Click);
            // 
            // btnDisplayArray
            // 
            this.btnDisplayArray.AutoSize = true;
            this.btnDisplayArray.Location = new System.Drawing.Point(313, 16);
            this.btnDisplayArray.Name = "btnDisplayArray";
            this.btnDisplayArray.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayArray.TabIndex = 5;
            this.btnDisplayArray.Text = "Display Array";
            this.btnDisplayArray.UseVisualStyleBackColor = true;
            this.btnDisplayArray.Click += new System.EventHandler(this.btnDisplayArray_Click);
            // 
            // lstDisplayArray
            // 
            this.lstDisplayArray.FormattingEnabled = true;
            this.lstDisplayArray.Location = new System.Drawing.Point(126, 18);
            this.lstDisplayArray.Name = "lstDisplayArray";
            this.lstDisplayArray.Size = new System.Drawing.Size(168, 134);
            this.lstDisplayArray.TabIndex = 6;
            // 
            // lblAverageOfElements
            // 
            this.lblAverageOfElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageOfElements.Location = new System.Drawing.Point(313, 175);
            this.lblAverageOfElements.Name = "lblAverageOfElements";
            this.lblAverageOfElements.Size = new System.Drawing.Size(100, 23);
            this.lblAverageOfElements.TabIndex = 7;
            this.lblAverageOfElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Average of Elements:";
            // 
            // lblNumOfElements
            // 
            this.lblNumOfElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumOfElements.Location = new System.Drawing.Point(313, 69);
            this.lblNumOfElements.Name = "lblNumOfElements";
            this.lblNumOfElements.Size = new System.Drawing.Size(100, 23);
            this.lblNumOfElements.TabIndex = 9;
            this.lblNumOfElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSumOfElements
            // 
            this.lblSumOfElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumOfElements.Location = new System.Drawing.Point(313, 120);
            this.lblSumOfElements.Name = "lblSumOfElements";
            this.lblSumOfElements.Size = new System.Drawing.Size(100, 23);
            this.lblSumOfElements.TabIndex = 10;
            this.lblSumOfElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sum of Elements:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "# of Elements:";
            // 
            // btnAddArray5
            // 
            this.btnAddArray5.Location = new System.Drawing.Point(8, 162);
            this.btnAddArray5.Name = "btnAddArray5";
            this.btnAddArray5.Size = new System.Drawing.Size(100, 23);
            this.btnAddArray5.TabIndex = 13;
            this.btnAddArray5.Text = "Add to Array #5";
            this.btnAddArray5.UseVisualStyleBackColor = true;
            this.btnAddArray5.Click += new System.EventHandler(this.btnAddArray5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 216);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(441, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 238);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddArray5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSumOfElements);
            this.Controls.Add(this.lblNumOfElements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAverageOfElements);
            this.Controls.Add(this.lstDisplayArray);
            this.Controls.Add(this.btnDisplayArray);
            this.Controls.Add(this.btnAddArray4);
            this.Controls.Add(this.btnAddArray3);
            this.Controls.Add(this.btnAddArray2);
            this.Controls.Add(this.btnAddArray1);
            this.Controls.Add(this.txtInputScore);
            this.Name = "frmArrays";
            this.Text = "Arrays";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputScore;
        private System.Windows.Forms.Button btnAddArray1;
        private System.Windows.Forms.Button btnAddArray2;
        private System.Windows.Forms.Button btnAddArray3;
        private System.Windows.Forms.Button btnAddArray4;
        private System.Windows.Forms.Button btnDisplayArray;
        private System.Windows.Forms.ListBox lstDisplayArray;
        private System.Windows.Forms.Label lblAverageOfElements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumOfElements;
        private System.Windows.Forms.Label lblSumOfElements;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddArray5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

