namespace OldMcDonaldsFarm.UI
{
    partial class frmInstruments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearCats = new System.Windows.Forms.Button();
            this.btnFillCats = new System.Windows.Forms.Button();
            this.btnSaveCats = new System.Windows.Forms.Button();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.btnLoadCats = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearCats);
            this.groupBox1.Controls.Add(this.btnFillCats);
            this.groupBox1.Controls.Add(this.btnSaveCats);
            this.groupBox1.Controls.Add(this.dgvCat);
            this.groupBox1.Controls.Add(this.btnLoadCats);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animals";
            // 
            // btnClearCats
            // 
            this.btnClearCats.Location = new System.Drawing.Point(6, 78);
            this.btnClearCats.Name = "btnClearCats";
            this.btnClearCats.Size = new System.Drawing.Size(75, 23);
            this.btnClearCats.TabIndex = 8;
            this.btnClearCats.Text = "Clear";
            this.btnClearCats.UseVisualStyleBackColor = true;
            this.btnClearCats.Click += new System.EventHandler(this.btnClearCats_Click);
            // 
            // btnFillCats
            // 
            this.btnFillCats.Location = new System.Drawing.Point(6, 20);
            this.btnFillCats.Name = "btnFillCats";
            this.btnFillCats.Size = new System.Drawing.Size(75, 23);
            this.btnFillCats.TabIndex = 7;
            this.btnFillCats.Text = "Fill";
            this.btnFillCats.UseVisualStyleBackColor = true;
            this.btnFillCats.Click += new System.EventHandler(this.btnFillCat_Click);
            // 
            // btnSaveCats
            // 
            this.btnSaveCats.Location = new System.Drawing.Point(6, 49);
            this.btnSaveCats.Name = "btnSaveCats";
            this.btnSaveCats.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCats.TabIndex = 6;
            this.btnSaveCats.Text = "Save";
            this.btnSaveCats.UseVisualStyleBackColor = true;
            this.btnSaveCats.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // dgvCat
            // 
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Location = new System.Drawing.Point(105, 20);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.Size = new System.Drawing.Size(700, 150);
            this.dgvCat.TabIndex = 5;
            // 
            // btnLoadCats
            // 
            this.btnLoadCats.Location = new System.Drawing.Point(6, 107);
            this.btnLoadCats.Name = "btnLoadCats";
            this.btnLoadCats.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCats.TabIndex = 4;
            this.btnLoadCats.Text = "Load";
            this.btnLoadCats.UseVisualStyleBackColor = true;
            this.btnLoadCats.Click += new System.EventHandler(this.btnLoadCat_Click);
            // 
            // frmInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 437);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInstruments";
            this.Text = "Instruments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFillCats;
        private System.Windows.Forms.Button btnSaveCats;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Button btnLoadCats;
        private System.Windows.Forms.Button btnClearCats;

    }
}

