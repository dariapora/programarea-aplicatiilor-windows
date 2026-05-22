namespace Casa_de_Schimb_Valutar
{
    partial class FormParolaAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblParola
            //
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblParola.Location = new System.Drawing.Point(20, 20);
            this.lblParola.Name = "lblParola";
            this.lblParola.TabIndex = 0;
            this.lblParola.Text = "Parola admin:";
            //
            // txtParola
            //
            this.txtParola.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtParola.Location = new System.Drawing.Point(20, 45);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(260, 24);
            this.txtParola.TabIndex = 1;
            //
            // btnOK
            //
            this.btnOK.BackColor = System.Drawing.Color.Olive;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(200, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // FormParolaAdmin
            //
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParolaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acces Admin";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnOK;
    }
}
