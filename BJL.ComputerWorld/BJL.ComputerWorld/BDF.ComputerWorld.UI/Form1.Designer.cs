﻿namespace BDF.ComputerWorld.UI
{
    partial class frmComputerWorld
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvComputers = new System.Windows.Forms.DataGridView();
            this.btnLoadComputers = new System.Windows.Forms.Button();
            this.btnMakeComputer = new System.Windows.Forms.Button();
            this.btnTestData = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            this.btnWriteTypes = new System.Windows.Forms.Button();
            this.btnGetTypes = new System.Windows.Forms.Button();
            this.btnSaveComputersXML = new System.Windows.Forms.Button();
            this.btnLoadComputersXML = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHardDriveSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEquipmentType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxSoftware = new System.Windows.Forms.ListBox();
            this.btnLoadCompDb = new System.Windows.Forms.Button();
            this.btnInsertComputerDB = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.btnDeleteComputerDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComputers
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvComputers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputers.Location = new System.Drawing.Point(144, 12);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputers.Size = new System.Drawing.Size(675, 408);
            this.dgvComputers.TabIndex = 0;
            this.dgvComputers.SelectionChanged += new System.EventHandler(this.dgvComputers_SelectionChanged);
            // 
            // btnLoadComputers
            // 
            this.btnLoadComputers.Location = new System.Drawing.Point(12, 12);
            this.btnLoadComputers.Name = "btnLoadComputers";
            this.btnLoadComputers.Size = new System.Drawing.Size(126, 23);
            this.btnLoadComputers.TabIndex = 3;
            this.btnLoadComputers.Text = "&Load Computers";
            this.btnLoadComputers.UseVisualStyleBackColor = true;
            this.btnLoadComputers.Click += new System.EventHandler(this.btnLoadComputers_Click);
            // 
            // btnMakeComputer
            // 
            this.btnMakeComputer.Location = new System.Drawing.Point(12, 43);
            this.btnMakeComputer.Name = "btnMakeComputer";
            this.btnMakeComputer.Size = new System.Drawing.Size(126, 23);
            this.btnMakeComputer.TabIndex = 4;
            this.btnMakeComputer.Text = "Make Computer";
            this.btnMakeComputer.UseVisualStyleBackColor = true;
            this.btnMakeComputer.Click += new System.EventHandler(this.btnMakeComputer_Click);
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(12, 74);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(126, 23);
            this.btnTestData.TabIndex = 5;
            this.btnTestData.Text = "Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 105);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(126, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Location = new System.Drawing.Point(12, 198);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteObject.TabIndex = 9;
            this.btnDeleteObject.Text = "Delete Object";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            this.btnDeleteObject.Click += new System.EventHandler(this.btnDeleteObject_Click);
            // 
            // btnWriteTypes
            // 
            this.btnWriteTypes.Location = new System.Drawing.Point(12, 229);
            this.btnWriteTypes.Name = "btnWriteTypes";
            this.btnWriteTypes.Size = new System.Drawing.Size(126, 23);
            this.btnWriteTypes.TabIndex = 10;
            this.btnWriteTypes.Text = "Write Types";
            this.btnWriteTypes.UseVisualStyleBackColor = true;
            this.btnWriteTypes.Click += new System.EventHandler(this.btnWriteTypes_Click);
            // 
            // btnGetTypes
            // 
            this.btnGetTypes.Location = new System.Drawing.Point(12, 260);
            this.btnGetTypes.Name = "btnGetTypes";
            this.btnGetTypes.Size = new System.Drawing.Size(126, 23);
            this.btnGetTypes.TabIndex = 11;
            this.btnGetTypes.Text = "Get Types";
            this.btnGetTypes.UseVisualStyleBackColor = true;
            this.btnGetTypes.Click += new System.EventHandler(this.btnGetTypes_Click);
            // 
            // btnSaveComputersXML
            // 
            this.btnSaveComputersXML.Location = new System.Drawing.Point(12, 291);
            this.btnSaveComputersXML.Name = "btnSaveComputersXML";
            this.btnSaveComputersXML.Size = new System.Drawing.Size(126, 23);
            this.btnSaveComputersXML.TabIndex = 12;
            this.btnSaveComputersXML.Text = "Save Computers XML";
            this.btnSaveComputersXML.UseVisualStyleBackColor = true;
            this.btnSaveComputersXML.Click += new System.EventHandler(this.btnSaveComputersXML_Click);
            // 
            // btnLoadComputersXML
            // 
            this.btnLoadComputersXML.Location = new System.Drawing.Point(12, 320);
            this.btnLoadComputersXML.Name = "btnLoadComputersXML";
            this.btnLoadComputersXML.Size = new System.Drawing.Size(126, 23);
            this.btnLoadComputersXML.TabIndex = 13;
            this.btnLoadComputersXML.Text = "Load Computers XML";
            this.btnLoadComputersXML.UseVisualStyleBackColor = true;
            this.btnLoadComputersXML.Click += new System.EventHandler(this.btnLoadComputersXML_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manufacturer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(392, 439);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(150, 20);
            this.txtManufacturer.TabIndex = 16;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(392, 474);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 20);
            this.txtModel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Model:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(392, 509);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(150, 20);
            this.txtSerialNo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Serial No.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(392, 544);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHardDriveSize
            // 
            this.txtHardDriveSize.Location = new System.Drawing.Point(662, 439);
            this.txtHardDriveSize.Name = "txtHardDriveSize";
            this.txtHardDriveSize.Size = new System.Drawing.Size(150, 20);
            this.txtHardDriveSize.TabIndex = 24;
            this.txtHardDriveSize.TextChanged += new System.EventHandler(this.txtHardDriveSize_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "HD Size:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(662, 474);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(150, 20);
            this.txtRAM.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "RAM:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(662, 509);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Description:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.FormattingEnabled = true;
            this.cboEquipmentType.Location = new System.Drawing.Point(662, 543);
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.Size = new System.Drawing.Size(150, 21);
            this.cboEquipmentType.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Equipment Type:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbxSoftware
            // 
            this.lbxSoftware.FormattingEnabled = true;
            this.lbxSoftware.Location = new System.Drawing.Point(145, 439);
            this.lbxSoftware.Name = "lbxSoftware";
            this.lbxSoftware.Size = new System.Drawing.Size(152, 134);
            this.lbxSoftware.TabIndex = 31;
            // 
            // btnLoadCompDb
            // 
            this.btnLoadCompDb.Location = new System.Drawing.Point(12, 349);
            this.btnLoadCompDb.Name = "btnLoadCompDb";
            this.btnLoadCompDb.Size = new System.Drawing.Size(126, 23);
            this.btnLoadCompDb.TabIndex = 32;
            this.btnLoadCompDb.Text = "Load Computers DB";
            this.btnLoadCompDb.UseVisualStyleBackColor = true;
            this.btnLoadCompDb.Click += new System.EventHandler(this.btnLoadCompDb_Click);
            // 
            // btnInsertComputerDB
            // 
            this.btnInsertComputerDB.Location = new System.Drawing.Point(12, 378);
            this.btnInsertComputerDB.Name = "btnInsertComputerDB";
            this.btnInsertComputerDB.Size = new System.Drawing.Size(126, 23);
            this.btnInsertComputerDB.TabIndex = 33;
            this.btnInsertComputerDB.Text = "Insert Computer DB";
            this.btnInsertComputerDB.UseVisualStyleBackColor = true;
            this.btnInsertComputerDB.Click += new System.EventHandler(this.btnInsertComputerDB_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(12, 407);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(126, 23);
            this.btnUpdateDB.TabIndex = 34;
            this.btnUpdateDB.Text = "Update Computer DB";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnDeleteComputerDB
            // 
            this.btnDeleteComputerDB.Location = new System.Drawing.Point(12, 436);
            this.btnDeleteComputerDB.Name = "btnDeleteComputerDB";
            this.btnDeleteComputerDB.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteComputerDB.TabIndex = 35;
            this.btnDeleteComputerDB.Text = "Delete Computer DB";
            this.btnDeleteComputerDB.UseVisualStyleBackColor = true;
            this.btnDeleteComputerDB.Click += new System.EventHandler(this.btnDeleteComputerDB_Click);
            // 
            // frmComputerWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 601);
            this.Controls.Add(this.btnDeleteComputerDB);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.btnInsertComputerDB);
            this.Controls.Add(this.btnLoadCompDb);
            this.Controls.Add(this.lbxSoftware);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboEquipmentType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHardDriveSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLoadComputersXML);
            this.Controls.Add(this.btnSaveComputersXML);
            this.Controls.Add(this.btnGetTypes);
            this.Controls.Add(this.btnWriteTypes);
            this.Controls.Add(this.btnDeleteObject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnTestData);
            this.Controls.Add(this.btnMakeComputer);
            this.Controls.Add(this.btnLoadComputers);
            this.Controls.Add(this.dgvComputers);
            this.Name = "frmComputerWorld";
            this.Text = "Computer World";
            this.Load += new System.EventHandler(this.frmComputerWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.Button btnLoadComputers;
        private System.Windows.Forms.Button btnMakeComputer;
        private System.Windows.Forms.Button btnTestData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteObject;
        private System.Windows.Forms.Button btnWriteTypes;
        private System.Windows.Forms.Button btnGetTypes;
        private System.Windows.Forms.Button btnSaveComputersXML;
        private System.Windows.Forms.Button btnLoadComputersXML;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHardDriveSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEquipmentType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxSoftware;
        private System.Windows.Forms.Button btnLoadCompDb;
        private System.Windows.Forms.Button btnInsertComputerDB;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Button btnDeleteComputerDB;
    }
}

