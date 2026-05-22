namespace DataGridView_si_Aplicatii_cu_Ferestre_Multiple
{
    partial class FormAngajat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDepartament = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataAngajarii = new System.Windows.Forms.DateTimePicker();
            this.chkEstePermanent = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(117, 25);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(116, 20);
            this.txtNume.TabIndex = 1;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(117, 65);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(116, 20);
            this.txtPrenume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume";
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(117, 141);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(116, 20);
            this.txtSalariu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salariu";
            // 
            // cmbDepartament
            // 
            this.cmbDepartament.FormattingEnabled = true;
            this.cmbDepartament.Items.AddRange(new object[] {
            "IT",
            "HR",
            "Financiar",
            "Vânzări"});
            this.cmbDepartament.Location = new System.Drawing.Point(117, 102);
            this.cmbDepartament.Name = "cmbDepartament";
            this.cmbDepartament.Size = new System.Drawing.Size(116, 21);
            this.cmbDepartament.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Angajării";
            // 
            // dtpDataAngajarii
            // 
            this.dtpDataAngajarii.Location = new System.Drawing.Point(117, 177);
            this.dtpDataAngajarii.Name = "dtpDataAngajarii";
            this.dtpDataAngajarii.Size = new System.Drawing.Size(116, 20);
            this.dtpDataAngajarii.TabIndex = 9;
            // 
            // chkEstePermanent
            // 
            this.chkEstePermanent.AutoSize = true;
            this.chkEstePermanent.Location = new System.Drawing.Point(19, 217);
            this.chkEstePermanent.Name = "chkEstePermanent";
            this.chkEstePermanent.Size = new System.Drawing.Size(116, 17);
            this.chkEstePermanent.TabIndex = 10;
            this.chkEstePermanent.Text = "Angajat Permanent";
            this.chkEstePermanent.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightGreen;
            this.btnOk.Location = new System.Drawing.Point(12, 252);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(161, 26);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(179, 252);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(73, 26);
            this.btnAnuleaza.TabIndex = 12;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // FormAngajat
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(264, 290);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkEstePermanent);
            this.Controls.Add(this.dtpDataAngajarii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDepartament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataAngajarii;
        private System.Windows.Forms.CheckBox chkEstePermanent;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}