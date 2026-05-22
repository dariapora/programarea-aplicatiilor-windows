namespace Casa_de_Schimb_Valutar
{
    partial class FormIstoric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIstoric));
            this.dgvCursuri = new System.Windows.Forms.DataGridView();
            this.chartCursuri = new Casa_de_Schimb_Valutar.GraficLinie();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.panelRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.rbCumparare = new System.Windows.Forms.RadioButton();
            this.rbVanzare = new System.Windows.Forms.RadioButton();
            this.rbAmbele = new System.Windows.Forms.RadioButton();
            this.panelLegenda = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBuy = new System.Windows.Forms.Panel();
            this.lblBuy = new System.Windows.Forms.Label();
            this.pnlSell = new System.Windows.Forms.Panel();
            this.lblSell = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelRadio.SuspendLayout();
            this.panelLegenda.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvCursuri
            //
            this.dgvCursuri.AllowUserToAddRows = false;
            this.dgvCursuri.AllowUserToDeleteRows = false;
            this.dgvCursuri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursuri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursuri.Location = new System.Drawing.Point(0, 0);
            this.dgvCursuri.Name = "dgvCursuri";
            this.dgvCursuri.ReadOnly = true;
            this.dgvCursuri.RowHeadersVisible = false;
            this.dgvCursuri.Size = new System.Drawing.Size(750, 170);
            this.dgvCursuri.TabIndex = 0;
            //
            // panelTop
            //
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 36);
            this.panelTop.TabIndex = 0;
            this.panelTop.Controls.Add(this.lblTitlu);
            this.panelTop.Controls.Add(this.panelRadio);
            //
            // lblTitlu
            //
            this.lblTitlu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Text = "Evolutia cursului";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // panelRadio
            //
            this.panelRadio.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRadio.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Padding = new System.Windows.Forms.Padding(6, 6, 10, 6);
            this.panelRadio.Size = new System.Drawing.Size(280, 36);
            this.panelRadio.WrapContents = false;
            this.panelRadio.Controls.Add(this.rbCumparare);
            this.panelRadio.Controls.Add(this.rbVanzare);
            this.panelRadio.Controls.Add(this.rbAmbele);
            //
            // rbCumparare
            //
            this.rbCumparare.AutoSize = true;
            this.rbCumparare.Name = "rbCumparare";
            this.rbCumparare.Text = "Cumparare";
            this.rbCumparare.UseVisualStyleBackColor = true;
            //
            // rbVanzare
            //
            this.rbVanzare.AutoSize = true;
            this.rbVanzare.Name = "rbVanzare";
            this.rbVanzare.Text = "Vanzare";
            this.rbVanzare.UseVisualStyleBackColor = true;
            //
            // rbAmbele
            //
            this.rbAmbele.AutoSize = true;
            this.rbAmbele.Checked = true;
            this.rbAmbele.Name = "rbAmbele";
            this.rbAmbele.Text = "Ambele";
            this.rbAmbele.TabStop = true;
            this.rbAmbele.UseVisualStyleBackColor = true;
            //
            // panelLegenda
            //
            this.panelLegenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLegenda.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelLegenda.Location = new System.Drawing.Point(0, 366);
            this.panelLegenda.Name = "panelLegenda";
            this.panelLegenda.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.panelLegenda.Size = new System.Drawing.Size(750, 28);
            this.panelLegenda.TabIndex = 2;
            this.panelLegenda.Controls.Add(this.pnlBuy);
            this.panelLegenda.Controls.Add(this.lblBuy);
            this.panelLegenda.Controls.Add(this.pnlSell);
            this.panelLegenda.Controls.Add(this.lblSell);
            //
            // pnlBuy
            //
            this.pnlBuy.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlBuy.Margin = new System.Windows.Forms.Padding(0, 5, 4, 5);
            this.pnlBuy.Name = "pnlBuy";
            this.pnlBuy.Size = new System.Drawing.Size(18, 10);
            //
            // lblBuy
            //
            this.lblBuy.AutoSize = true;
            this.lblBuy.Margin = new System.Windows.Forms.Padding(0, 3, 18, 0);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Text = "Cumparare";
            //
            // pnlSell
            //
            this.pnlSell.BackColor = System.Drawing.Color.IndianRed;
            this.pnlSell.Margin = new System.Windows.Forms.Padding(0, 5, 4, 5);
            this.pnlSell.Name = "pnlSell";
            this.pnlSell.Size = new System.Drawing.Size(18, 10);
            //
            // lblSell
            //
            this.lblSell.AutoSize = true;
            this.lblSell.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Text = "Vanzare";
            //
            // chartCursuri
            //
            this.chartCursuri.BackColor = System.Drawing.Color.White;
            this.chartCursuri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCursuri.Location = new System.Drawing.Point(0, 36);
            this.chartCursuri.Name = "chartCursuri";
            this.chartCursuri.Size = new System.Drawing.Size(750, 330);
            this.chartCursuri.TabIndex = 1;
            //
            // splitContainer
            //
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer.Panel1
            //
            this.splitContainer.Panel1.Controls.Add(this.chartCursuri);
            this.splitContainer.Panel1.Controls.Add(this.panelLegenda);
            this.splitContainer.Panel1.Controls.Add(this.panelTop);
            //
            // splitContainer.Panel2
            //
            this.splitContainer.Panel2.Controls.Add(this.dgvCursuri);
            this.splitContainer.Size = new System.Drawing.Size(750, 600);
            this.splitContainer.SplitterDistance = 426;
            this.splitContainer.TabIndex = 0;
            //
            // FormIstoric
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIstoric";
            this.ShowIcon = false;
            this.Text = "Istoric Curs";
            this.Load += new System.EventHandler(this.FormIstoric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuri)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelRadio.ResumeLayout(false);
            this.panelRadio.PerformLayout();
            this.panelLegenda.ResumeLayout(false);
            this.panelLegenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursuri;
        private Casa_de_Schimb_Valutar.GraficLinie chartCursuri;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.FlowLayoutPanel panelRadio;
        private System.Windows.Forms.RadioButton rbCumparare;
        private System.Windows.Forms.RadioButton rbVanzare;
        private System.Windows.Forms.RadioButton rbAmbele;
        private System.Windows.Forms.FlowLayoutPanel panelLegenda;
        private System.Windows.Forms.Panel pnlBuy;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Panel pnlSell;
        private System.Windows.Forms.Label lblSell;
    }
}
