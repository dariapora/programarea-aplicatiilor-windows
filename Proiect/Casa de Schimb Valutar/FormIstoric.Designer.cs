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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIstoric));
            this.dgvCursuri = new System.Windows.Forms.DataGridView();
            this.chartCursuri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCursuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            // chartCursuri
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCursuri.ChartAreas.Add(chartArea1);
            this.chartCursuri.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCursuri.Legends.Add(legend1);
            this.chartCursuri.Location = new System.Drawing.Point(0, 0);
            this.chartCursuri.Name = "chartCursuri";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "Cumparare";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Tomato;
            series2.Legend = "Legend1";
            series2.Name = "Vanzare";
            this.chartCursuri.Series.Add(series1);
            this.chartCursuri.Series.Add(series2);
            this.chartCursuri.Size = new System.Drawing.Size(750, 426);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartCursuri)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursuri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCursuri;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
