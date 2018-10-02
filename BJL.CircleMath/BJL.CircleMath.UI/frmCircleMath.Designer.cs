namespace BJL.CircleMath.UI
{
    partial class frmCircleMath
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
            this.btnCircumference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputRadius = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCircumference
            // 
            this.btnCircumference.Location = new System.Drawing.Point(152, 45);
            this.btnCircumference.Name = "btnCircumference";
            this.btnCircumference.Size = new System.Drawing.Size(123, 23);
            this.btnCircumference.TabIndex = 0;
            this.btnCircumference.Text = "Find Circumference";
            this.btnCircumference.UseVisualStyleBackColor = true;
            this.btnCircumference.Click += new System.EventHandler(this.btnCircumference_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Circle Raidus:";
            // 
            // txtInputRadius
            // 
            this.txtInputRadius.Location = new System.Drawing.Point(169, 16);
            this.txtInputRadius.Name = "txtInputRadius";
            this.txtInputRadius.Size = new System.Drawing.Size(101, 20);
            this.txtInputRadius.TabIndex = 2;
            this.txtInputRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInputRadius.TextChanged += new System.EventHandler(this.txtInputRadius_TextChanged);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(23, 45);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(123, 23);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Find Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(25, 71);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(250, 36);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 118);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(298, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frmCircleMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 140);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtInputRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCircumference);
            this.Name = "frmCircleMath";
            this.Text = "Circle Math";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCircumference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputRadius;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

