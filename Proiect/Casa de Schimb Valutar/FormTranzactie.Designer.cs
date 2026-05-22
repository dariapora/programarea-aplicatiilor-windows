namespace Casa_de_Schimb_Valutar
{
    partial class FormTranzactie
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblCardLogo = new System.Windows.Forms.Label();
            this.lblCardNr = new System.Windows.Forms.Label();
            this.lblCardTitular = new System.Windows.Forms.Label();
            this.lblCardExpirare = new System.Windows.Forms.Label();
            this.lblNrCard = new System.Windows.Forms.Label();
            this.txtNrCard = new System.Windows.Forms.TextBox();
            this.lblTitularCard = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblExpirare = new System.Windows.Forms.Label();
            this.txtExpirare = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.btnProceseaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.panelBody.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelBody.Controls.Add(this.panelCard);
            this.panelBody.Controls.Add(this.lblNrCard);
            this.panelBody.Controls.Add(this.txtNrCard);
            this.panelBody.Controls.Add(this.lblTitularCard);
            this.panelBody.Controls.Add(this.txtTitular);
            this.panelBody.Controls.Add(this.lblExpirare);
            this.panelBody.Controls.Add(this.txtExpirare);
            this.panelBody.Controls.Add(this.lblCVV);
            this.panelBody.Controls.Add(this.txtCVV);
            this.panelBody.Controls.Add(this.btnProceseaza);
            this.panelBody.Controls.Add(this.btnAnuleaza);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(420, 350);
            this.panelBody.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.panelCard.Controls.Add(this.lblCardLogo);
            this.panelCard.Controls.Add(this.lblCardNr);
            this.panelCard.Controls.Add(this.lblCardTitular);
            this.panelCard.Controls.Add(this.lblCardExpirare);
            this.panelCard.Location = new System.Drawing.Point(20, 15);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(375, 88);
            this.panelCard.TabIndex = 0;
            // 
            // lblCardLogo
            // 
            this.lblCardLogo.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardLogo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCardLogo.Location = new System.Drawing.Point(230, 8);
            this.lblCardLogo.Name = "lblCardLogo";
            this.lblCardLogo.Size = new System.Drawing.Size(130, 20);
            this.lblCardLogo.TabIndex = 0;
            this.lblCardLogo.Text = "ANYCOIN";
            this.lblCardLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardNr
            // 
            this.lblCardNr.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCardNr.ForeColor = System.Drawing.Color.White;
            this.lblCardNr.Location = new System.Drawing.Point(12, 32);
            this.lblCardNr.Name = "lblCardNr";
            this.lblCardNr.Size = new System.Drawing.Size(350, 24);
            this.lblCardNr.TabIndex = 1;
            this.lblCardNr.Text = "•••• •••• •••• ••••";
            // 
            // lblCardTitular
            // 
            this.lblCardTitular.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCardTitular.ForeColor = System.Drawing.Color.LightGray;
            this.lblCardTitular.Location = new System.Drawing.Point(12, 64);
            this.lblCardTitular.Name = "lblCardTitular";
            this.lblCardTitular.Size = new System.Drawing.Size(200, 18);
            this.lblCardTitular.TabIndex = 2;
            this.lblCardTitular.Text = "TITULAR CARD";
            // 
            // lblCardExpirare
            // 
            this.lblCardExpirare.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCardExpirare.ForeColor = System.Drawing.Color.LightGray;
            this.lblCardExpirare.Location = new System.Drawing.Point(255, 64);
            this.lblCardExpirare.Name = "lblCardExpirare";
            this.lblCardExpirare.Size = new System.Drawing.Size(108, 18);
            this.lblCardExpirare.TabIndex = 3;
            this.lblCardExpirare.Text = "Exp: LL/AA";
            this.lblCardExpirare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNrCard
            // 
            this.lblNrCard.AutoSize = true;
            this.lblNrCard.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNrCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNrCard.Location = new System.Drawing.Point(20, 115);
            this.lblNrCard.Name = "lblNrCard";
            this.lblNrCard.Size = new System.Drawing.Size(85, 17);
            this.lblNrCard.TabIndex = 1;
            this.lblNrCard.Text = "Numar card:";
            // 
            // txtNrCard
            // 
            this.txtNrCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrCard.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNrCard.Location = new System.Drawing.Point(20, 133);
            this.txtNrCard.MaxLength = 19;
            this.txtNrCard.Name = "txtNrCard";
            this.txtNrCard.Size = new System.Drawing.Size(375, 24);
            this.txtNrCard.TabIndex = 2;
            this.txtNrCard.TextChanged += new System.EventHandler(this.txtNrCard_TextChanged);
            // 
            // lblTitularCard
            // 
            this.lblTitularCard.AutoSize = true;
            this.lblTitularCard.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTitularCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitularCard.Location = new System.Drawing.Point(17, 167);
            this.lblTitularCard.Name = "lblTitularCard";
            this.lblTitularCard.Size = new System.Drawing.Size(81, 17);
            this.lblTitularCard.TabIndex = 3;
            this.lblTitularCard.Text = "Titular card:";
            // 
            // txtTitular
            // 
            this.txtTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitular.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTitular.Location = new System.Drawing.Point(20, 187);
            this.txtTitular.MaxLength = 100;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(375, 24);
            this.txtTitular.TabIndex = 4;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // lblExpirare
            // 
            this.lblExpirare.AutoSize = true;
            this.lblExpirare.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblExpirare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblExpirare.Location = new System.Drawing.Point(17, 221);
            this.lblExpirare.Name = "lblExpirare";
            this.lblExpirare.Size = new System.Drawing.Size(144, 17);
            this.lblExpirare.TabIndex = 5;
            this.lblExpirare.Text = "Data expirare (LL/AA):";
            // 
            // txtExpirare
            // 
            this.txtExpirare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpirare.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtExpirare.Location = new System.Drawing.Point(20, 241);
            this.txtExpirare.MaxLength = 5;
            this.txtExpirare.Name = "txtExpirare";
            this.txtExpirare.Size = new System.Drawing.Size(141, 24);
            this.txtExpirare.TabIndex = 6;
            this.txtExpirare.TextChanged += new System.EventHandler(this.txtExpirare_TextChanged);
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCVV.Location = new System.Drawing.Point(178, 223);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(38, 17);
            this.lblCVV.TabIndex = 7;
            this.lblCVV.Text = "CVV:";
            // 
            // txtCVV
            // 
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCVV.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCVV.Location = new System.Drawing.Point(178, 241);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '•';
            this.txtCVV.Size = new System.Drawing.Size(54, 24);
            this.txtCVV.TabIndex = 8;
            this.txtCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVV_KeyPress);
            // 
            // btnProceseaza
            // 
            this.btnProceseaza.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProceseaza.FlatAppearance.BorderSize = 0;
            this.btnProceseaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceseaza.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnProceseaza.ForeColor = System.Drawing.Color.White;
            this.btnProceseaza.Location = new System.Drawing.Point(20, 295);
            this.btnProceseaza.Name = "btnProceseaza";
            this.btnProceseaza.Size = new System.Drawing.Size(252, 36);
            this.btnProceseaza.TabIndex = 9;
            this.btnProceseaza.Text = "Proceseaza";
            this.btnProceseaza.UseVisualStyleBackColor = false;
            this.btnProceseaza.Click += new System.EventHandler(this.btnProceseaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnuleaza.FlatAppearance.BorderSize = 0;
            this.btnAnuleaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuleaza.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAnuleaza.ForeColor = System.Drawing.Color.White;
            this.btnAnuleaza.Location = new System.Drawing.Point(278, 295);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(117, 36);
            this.btnAnuleaza.TabIndex = 10;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // FormTranzactie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTranzactie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tranzactie Card";
            this.Load += new System.EventHandler(this.FormTranzactie_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblCardLogo;
        private System.Windows.Forms.Label lblCardNr;
        private System.Windows.Forms.Label lblCardTitular;
        private System.Windows.Forms.Label lblCardExpirare;
        private System.Windows.Forms.Label lblNrCard;
        private System.Windows.Forms.TextBox txtNrCard;
        private System.Windows.Forms.Label lblTitularCard;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblExpirare;
        private System.Windows.Forms.TextBox txtExpirare;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnProceseaza;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}
