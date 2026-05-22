namespace Casa_de_Schimb_Valutar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.cbValuta1 = new System.Windows.Forms.ComboBox();
            this.cbValuta2 = new System.Windows.Forms.ComboBox();
            this.txtSumaIntrodusa = new System.Windows.Forms.TextBox();
            this.btnDeschideIstoric = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnTranzactie = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblValuta1 = new System.Windows.Forms.Label();
            this.lblValuta2 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.txtSumaRezultata = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBuy
            // 
            this.rbBuy.AutoSize = true;
            this.rbBuy.BackColor = System.Drawing.Color.Transparent;
            this.rbBuy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbBuy.Location = new System.Drawing.Point(11, 38);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(81, 21);
            this.rbBuy.TabIndex = 0;
            this.rbBuy.TabStop = true;
            this.rbBuy.Text = "Cumpar";
            this.rbBuy.UseVisualStyleBackColor = false;
            this.rbBuy.CheckedChanged += new System.EventHandler(this.rbTip_CheckedChanged);
            // 
            // rbSell
            // 
            this.rbSell.AutoSize = true;
            this.rbSell.BackColor = System.Drawing.Color.Transparent;
            this.rbSell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rbSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbSell.Location = new System.Drawing.Point(98, 38);
            this.rbSell.Name = "rbSell";
            this.rbSell.Size = new System.Drawing.Size(62, 21);
            this.rbSell.TabIndex = 1;
            this.rbSell.TabStop = true;
            this.rbSell.Text = "Vand";
            this.rbSell.UseVisualStyleBackColor = false;
            this.rbSell.CheckedChanged += new System.EventHandler(this.rbTip_CheckedChanged);
            // 
            // cbValuta1
            // 
            this.cbValuta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValuta1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbValuta1.FormattingEnabled = true;
            this.cbValuta1.Location = new System.Drawing.Point(47, 84);
            this.cbValuta1.Name = "cbValuta1";
            this.cbValuta1.Size = new System.Drawing.Size(120, 24);
            this.cbValuta1.TabIndex = 2;
            this.cbValuta1.SelectedIndexChanged += new System.EventHandler(this.ValidareValuteDiferite);
            this.cbValuta1.SelectedIndexChanged += new System.EventHandler(this.txtSumaIntrodusa_TextChanged);
            // 
            // cbValuta2
            // 
            this.cbValuta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValuta2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbValuta2.FormattingEnabled = true;
            this.cbValuta2.Location = new System.Drawing.Point(47, 131);
            this.cbValuta2.Name = "cbValuta2";
            this.cbValuta2.Size = new System.Drawing.Size(120, 24);
            this.cbValuta2.TabIndex = 3;
            this.cbValuta2.SelectedIndexChanged += new System.EventHandler(this.ValidareValuteDiferite);
            this.cbValuta2.SelectedIndexChanged += new System.EventHandler(this.txtSumaIntrodusa_TextChanged);
            // 
            // txtSumaIntrodusa
            // 
            this.txtSumaIntrodusa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaIntrodusa.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSumaIntrodusa.Location = new System.Drawing.Point(173, 84);
            this.txtSumaIntrodusa.Name = "txtSumaIntrodusa";
            this.txtSumaIntrodusa.Size = new System.Drawing.Size(200, 24);
            this.txtSumaIntrodusa.TabIndex = 4;
            this.txtSumaIntrodusa.TextChanged += new System.EventHandler(this.txtSumaIntrodusa_TextChanged);
            // 
            // btnDeschideIstoric
            // 
            this.btnDeschideIstoric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeschideIstoric.FlatAppearance.BorderSize = 0;
            this.btnDeschideIstoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeschideIstoric.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDeschideIstoric.ForeColor = System.Drawing.Color.White;
            this.btnDeschideIstoric.Location = new System.Drawing.Point(15, 201);
            this.btnDeschideIstoric.Name = "btnDeschideIstoric";
            this.btnDeschideIstoric.Size = new System.Drawing.Size(358, 30);
            this.btnDeschideIstoric.TabIndex = 7;
            this.btnDeschideIstoric.Text = "Istoric Curs";
            this.btnDeschideIstoric.UseVisualStyleBackColor = false;
            this.btnDeschideIstoric.Click += new System.EventHandler(this.btnDeschideIstoric_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(12, 83);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(27, 72);
            this.btnSwitch.TabIndex = 12;
            this.btnSwitch.Text = "^\r\nv";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnTranzactie
            // 
            this.btnTranzactie.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTranzactie.FlatAppearance.BorderSize = 0;
            this.btnTranzactie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranzactie.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTranzactie.ForeColor = System.Drawing.Color.White;
            this.btnTranzactie.Location = new System.Drawing.Point(15, 168);
            this.btnTranzactie.Name = "btnTranzactie";
            this.btnTranzactie.Size = new System.Drawing.Size(358, 27);
            this.btnTranzactie.TabIndex = 14;
            this.btnTranzactie.UseVisualStyleBackColor = false;
            this.btnTranzactie.Click += new System.EventHandler(this.btnTranzactie_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.Gold;
            this.btnAdmin.Location = new System.Drawing.Point(324, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(55, 30);
            this.btnAdmin.TabIndex = 15;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblValuta1
            // 
            this.lblValuta1.AutoSize = true;
            this.lblValuta1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblValuta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValuta1.Location = new System.Drawing.Point(44, 64);
            this.lblValuta1.Name = "lblValuta1";
            this.lblValuta1.Size = new System.Drawing.Size(98, 14);
            this.lblValuta1.TabIndex = 2;
            this.lblValuta1.Text = "Vreau sa cumpar";
            // 
            // lblValuta2
            // 
            this.lblValuta2.AutoSize = true;
            this.lblValuta2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblValuta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValuta2.Location = new System.Drawing.Point(45, 114);
            this.lblValuta2.Name = "lblValuta2";
            this.lblValuta2.Size = new System.Drawing.Size(20, 14);
            this.lblValuta2.TabIndex = 3;
            this.lblValuta2.Text = "cu";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTip.Location = new System.Drawing.Point(8, 14);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(129, 21);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tip Tranzactie";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(11, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(103, 23);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "ANYCOIN";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.btnAdmin);
            this.panelHeader.Controls.Add(this.lblTitlu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(391, 52);
            this.panelHeader.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelBody.Controls.Add(this.txtSumaRezultata);
            this.panelBody.Controls.Add(this.lblTip);
            this.panelBody.Controls.Add(this.rbBuy);
            this.panelBody.Controls.Add(this.rbSell);
            this.panelBody.Controls.Add(this.lblValuta1);
            this.panelBody.Controls.Add(this.lblValuta2);
            this.panelBody.Controls.Add(this.cbValuta1);
            this.panelBody.Controls.Add(this.btnSwitch);
            this.panelBody.Controls.Add(this.cbValuta2);
            this.panelBody.Controls.Add(this.btnDeschideIstoric);
            this.panelBody.Controls.Add(this.txtSumaIntrodusa);
            this.panelBody.Controls.Add(this.btnTranzactie);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBody.Location = new System.Drawing.Point(0, 52);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(391, 248);
            this.panelBody.TabIndex = 0;
            // 
            // txtSumaRezultata
            // 
            this.txtSumaRezultata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaRezultata.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSumaRezultata.Location = new System.Drawing.Point(173, 131);
            this.txtSumaRezultata.Name = "txtSumaRezultata";
            this.txtSumaRezultata.Size = new System.Drawing.Size(200, 24);
            this.txtSumaRezultata.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(391, 300);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Casa de Schimb Valutar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.ComboBox cbValuta1;
        private System.Windows.Forms.ComboBox cbValuta2;
        private System.Windows.Forms.TextBox txtSumaIntrodusa;
        private System.Windows.Forms.Button btnDeschideIstoric;
        private System.Windows.Forms.Label lblValuta1;
        private System.Windows.Forms.Label lblValuta2;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TextBox txtSumaRezultata;
        private System.Windows.Forms.Button btnTranzactie;
        private System.Windows.Forms.Button btnAdmin;
    }
}
