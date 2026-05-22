namespace Casa_de_Schimb_Valutar
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnTranzactii = new System.Windows.Forms.Button();
            this.btnCursuri = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblTitlu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 52);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(11, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(136, 23);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Panou Admin";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelButtons.Controls.Add(this.btnTranzactii);
            this.panelButtons.Controls.Add(this.btnCursuri);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 52);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 104);
            this.panelButtons.TabIndex = 1;
            // 
            // btnTranzactii
            // 
            this.btnTranzactii.BackColor = System.Drawing.Color.Olive;
            this.btnTranzactii.FlatAppearance.BorderSize = 0;
            this.btnTranzactii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranzactii.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnTranzactii.ForeColor = System.Drawing.Color.White;
            this.btnTranzactii.Location = new System.Drawing.Point(40, 12);
            this.btnTranzactii.Name = "btnTranzactii";
            this.btnTranzactii.Size = new System.Drawing.Size(140, 80);
            this.btnTranzactii.TabIndex = 0;
            this.btnTranzactii.Text = "Tranzactii";
            this.btnTranzactii.UseVisualStyleBackColor = false;
            this.btnTranzactii.Click += new System.EventHandler(this.btnTranzactii_Click);
            // 
            // btnCursuri
            // 
            this.btnCursuri.BackColor = System.Drawing.Color.Olive;
            this.btnCursuri.FlatAppearance.BorderSize = 0;
            this.btnCursuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursuri.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnCursuri.ForeColor = System.Drawing.Color.White;
            this.btnCursuri.Location = new System.Drawing.Point(220, 12);
            this.btnCursuri.Name = "btnCursuri";
            this.btnCursuri.Size = new System.Drawing.Size(140, 80);
            this.btnCursuri.TabIndex = 1;
            this.btnCursuri.Text = "Cursuri";
            this.btnCursuri.UseVisualStyleBackColor = false;
            this.btnCursuri.Click += new System.EventHandler(this.btnCursuri_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(400, 156);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnTranzactii;
        private System.Windows.Forms.Button btnCursuri;
    }
}
