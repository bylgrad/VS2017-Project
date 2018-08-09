namespace firstapp
{
    partial class frmVehicle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelVehicle = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dialogLabel = new System.Windows.Forms.Label();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelVehicle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelVehicle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 361);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 30);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(67, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(195, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(259, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelVehicle
            // 
            this.panelVehicle.Controls.Add(this.txtState);
            this.panelVehicle.Controls.Add(this.label7);
            this.panelVehicle.Controls.Add(this.txtFuelType);
            this.panelVehicle.Controls.Add(this.label6);
            this.panelVehicle.Controls.Add(this.txtAge);
            this.panelVehicle.Controls.Add(this.label5);
            this.panelVehicle.Controls.Add(this.txtPlateNo);
            this.panelVehicle.Controls.Add(this.label1);
            this.panelVehicle.Controls.Add(this.label2);
            this.panelVehicle.Controls.Add(this.label3);
            this.panelVehicle.Controls.Add(this.txtVersion);
            this.panelVehicle.Controls.Add(this.label4);
            this.panelVehicle.Controls.Add(this.txtModel);
            this.panelVehicle.Controls.Add(this.txtBrand);
            this.panelVehicle.Location = new System.Drawing.Point(12, 48);
            this.panelVehicle.Name = "panelVehicle";
            this.panelVehicle.Size = new System.Drawing.Size(326, 257);
            this.panelVehicle.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.dialogLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 47);
            this.panel4.TabIndex = 11;
            // 
            // dialogLabel
            // 
            this.dialogLabel.AutoSize = true;
            this.dialogLabel.Location = new System.Drawing.Point(4, 4);
            this.dialogLabel.Name = "dialogLabel";
            this.dialogLabel.Size = new System.Drawing.Size(37, 13);
            this.dialogLabel.TabIndex = 0;
            this.dialogLabel.Text = "Status";
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlateNo.Location = new System.Drawing.Point(107, 21);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(190, 20);
            this.txtPlateNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plate No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model:";
            // 
            // txtVersion
            // 
            this.txtVersion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVersion.Location = new System.Drawing.Point(107, 117);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(190, 20);
            this.txtVersion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Version:";
            // 
            // txtModel
            // 
            this.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModel.Location = new System.Drawing.Point(107, 85);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(190, 20);
            this.txtModel.TabIndex = 11;
            this.txtModel.TextChanged += new System.EventHandler(this.txtMiddlename_TextChanged);
            // 
            // txtBrand
            // 
            this.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrand.Location = new System.Drawing.Point(107, 53);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(190, 20);
            this.txtBrand.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAge.Location = new System.Drawing.Point(107, 149);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(190, 20);
            this.txtAge.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Age:";
            // 
            // txtFuelType
            // 
            this.txtFuelType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuelType.Location = new System.Drawing.Point(107, 181);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(190, 20);
            this.txtFuelType.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fuel Type:";
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(107, 213);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(190, 20);
            this.txtState.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "State:";
            // 
            // frmVehicle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmVehicle";
            this.Text = "Vehicle Information";
            this.Load += new System.EventHandler(this.frmVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelVehicle.ResumeLayout(false);
            this.panelVehicle.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dialogLabel;
        public System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtBrand;
    }
}