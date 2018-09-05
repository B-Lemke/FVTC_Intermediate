namespace BJL.LunchOrder.UserInterface
{
    partial class FrmLunchOrder
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
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotalDisp = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblTaxDisp = new System.Windows.Forms.Label();
            this.lblOrderTotalDisp = new System.Windows.Forms.Label();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.chkThirdAddOn = new System.Windows.Forms.CheckBox();
            this.chkSecondAddOn = new System.Windows.Forms.CheckBox();
            this.chkFirstAddOn = new System.Windows.Forms.CheckBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.grpOrderTotal.SuspendLayout();
            this.grpMainCourse.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Checked = true;
            this.rdoHamburger.Location = new System.Drawing.Point(19, 28);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 1;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(56, 42);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(39, 72);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblSubTotalDisp
            // 
            this.lblSubTotalDisp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSubTotalDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotalDisp.Location = new System.Drawing.Point(128, 36);
            this.lblSubTotalDisp.Name = "lblSubTotalDisp";
            this.lblSubTotalDisp.Size = new System.Drawing.Size(100, 23);
            this.lblSubTotalDisp.TabIndex = 7;
            this.lblSubTotalDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(46, 107);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(59, 13);
            this.lblOrderTotal.TabIndex = 8;
            this.lblOrderTotal.Text = "Order total:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(289, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(289, 178);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 13;
            this.btnPlaceOrder.Text = "&Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblTaxDisp
            // 
            this.lblTaxDisp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTaxDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxDisp.Location = new System.Drawing.Point(128, 72);
            this.lblTaxDisp.Name = "lblTaxDisp";
            this.lblTaxDisp.Size = new System.Drawing.Size(100, 23);
            this.lblTaxDisp.TabIndex = 14;
            this.lblTaxDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderTotalDisp
            // 
            this.lblOrderTotalDisp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOrderTotalDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotalDisp.Location = new System.Drawing.Point(128, 107);
            this.lblOrderTotalDisp.Name = "lblOrderTotalDisp";
            this.lblOrderTotalDisp.Size = new System.Drawing.Size(100, 23);
            this.lblOrderTotalDisp.TabIndex = 15;
            this.lblOrderTotalDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.lblOrderTotalDisp);
            this.grpOrderTotal.Controls.Add(this.lblTax);
            this.grpOrderTotal.Controls.Add(this.lblTaxDisp);
            this.grpOrderTotal.Controls.Add(this.lblSubTotal);
            this.grpOrderTotal.Controls.Add(this.lblSubTotalDisp);
            this.grpOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpOrderTotal.Location = new System.Drawing.Point(12, 171);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(249, 151);
            this.grpOrderTotal.TabIndex = 17;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order total";
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.rdoSalad);
            this.grpMainCourse.Controls.Add(this.rdoPizza);
            this.grpMainCourse.Controls.Add(this.rdoHamburger);
            this.grpMainCourse.Location = new System.Drawing.Point(12, 24);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Size = new System.Drawing.Size(154, 132);
            this.grpMainCourse.TabIndex = 18;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(19, 95);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 3;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(19, 61);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 2;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.chkThirdAddOn);
            this.grpAddOn.Controls.Add(this.chkSecondAddOn);
            this.grpAddOn.Controls.Add(this.chkFirstAddOn);
            this.grpAddOn.Location = new System.Drawing.Point(188, 24);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(199, 132);
            this.grpAddOn.TabIndex = 19;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-on items ($.75/each)";
            // 
            // chkThirdAddOn
            // 
            this.chkThirdAddOn.AutoSize = true;
            this.chkThirdAddOn.Location = new System.Drawing.Point(15, 95);
            this.chkThirdAddOn.Name = "chkThirdAddOn";
            this.chkThirdAddOn.Size = new System.Drawing.Size(81, 17);
            this.chkThirdAddOn.TabIndex = 3;
            this.chkThirdAddOn.Text = "French fries";
            this.chkThirdAddOn.UseVisualStyleBackColor = true;
            this.chkThirdAddOn.CheckedChanged += new System.EventHandler(this.chkThirdAddOn_CheckedChanged);
            // 
            // chkSecondAddOn
            // 
            this.chkSecondAddOn.AutoSize = true;
            this.chkSecondAddOn.Location = new System.Drawing.Point(15, 61);
            this.chkSecondAddOn.Name = "chkSecondAddOn";
            this.chkSecondAddOn.Size = new System.Drawing.Size(161, 17);
            this.chkSecondAddOn.TabIndex = 2;
            this.chkSecondAddOn.Text = "Ketchup, mustard, and mayo";
            this.chkSecondAddOn.UseVisualStyleBackColor = true;
            this.chkSecondAddOn.CheckedChanged += new System.EventHandler(this.chkSecondAddOn_CheckedChanged);
            // 
            // chkFirstAddOn
            // 
            this.chkFirstAddOn.AutoSize = true;
            this.chkFirstAddOn.Location = new System.Drawing.Point(15, 29);
            this.chkFirstAddOn.Name = "chkFirstAddOn";
            this.chkFirstAddOn.Size = new System.Drawing.Size(158, 17);
            this.chkFirstAddOn.TabIndex = 1;
            this.chkFirstAddOn.Text = "Lettuce, tomato, and onions";
            this.chkFirstAddOn.UseVisualStyleBackColor = true;
            this.chkFirstAddOn.CheckedChanged += new System.EventHandler(this.chkFirstAddOn_CheckedChanged);
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(277, 207);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(100, 84);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFood.TabIndex = 20;
            this.picFood.TabStop = false;
            // 
            // FrmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(399, 334);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "FrmLunchOrder";
            this.Text = "Lunch Order";
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotalDisp;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblTaxDisp;
        private System.Windows.Forms.Label lblOrderTotalDisp;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox chkThirdAddOn;
        private System.Windows.Forms.CheckBox chkSecondAddOn;
        private System.Windows.Forms.CheckBox chkFirstAddOn;
        private System.Windows.Forms.PictureBox picFood;
    }
}

