namespace Casa_de_Schimb_Valutar
{
    partial class FormCursuri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursuri));
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.numSell = new System.Windows.Forms.NumericUpDown();
            this.lblSell = new System.Windows.Forms.Label();
            this.numBuy = new System.Windows.Forms.NumericUpDown();
            this.lblBuy = new System.Windows.Forms.Label();
            this.cbValutaTinta = new System.Windows.Forms.ComboBox();
            this.lblTinta = new System.Windows.Forms.Label();
            this.cbValutaBaza = new System.Windows.Forms.ComboBox();
            this.lblBaza = new System.Windows.Forms.Label();
            this.dgvCursuriExistente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuriExistente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblTitlu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(814, 52);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(11, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(328, 29);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Cursuri Valutare ANYCOIN";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelForm.Controls.Add(this.bindingNavigator1);
            this.panelForm.Controls.Add(this.btnSalveaza);
            this.panelForm.Controls.Add(this.numSell);
            this.panelForm.Controls.Add(this.lblSell);
            this.panelForm.Controls.Add(this.numBuy);
            this.panelForm.Controls.Add(this.lblBuy);
            this.panelForm.Controls.Add(this.cbValutaTinta);
            this.panelForm.Controls.Add(this.lblTinta);
            this.panelForm.Controls.Add(this.cbValutaBaza);
            this.panelForm.Controls.Add(this.lblBaza);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 52);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(814, 168);
            this.panelForm.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(814, 27);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.Olive;
            this.btnSalveaza.FlatAppearance.BorderSize = 0;
            this.btnSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalveaza.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalveaza.ForeColor = System.Drawing.Color.White;
            this.btnSalveaza.Location = new System.Drawing.Point(700, 54);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(97, 32);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Adauga";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // numSell
            // 
            this.numSell.DecimalPlaces = 4;
            this.numSell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numSell.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSell.Location = new System.Drawing.Point(540, 59);
            this.numSell.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSell.Name = "numSell";
            this.numSell.Size = new System.Drawing.Size(140, 28);
            this.numSell.TabIndex = 7;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSell.Location = new System.Drawing.Point(528, 35);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(166, 21);
            this.lblSell.TabIndex = 6;
            this.lblSell.Text = "Curs vanzare SELL";
            // 
            // numBuy
            // 
            this.numBuy.DecimalPlaces = 4;
            this.numBuy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numBuy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBuy.Location = new System.Drawing.Point(380, 59);
            this.numBuy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBuy.Name = "numBuy";
            this.numBuy.Size = new System.Drawing.Size(140, 28);
            this.numBuy.TabIndex = 5;
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuy.Location = new System.Drawing.Point(376, 35);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(89, 21);
            this.lblBuy.TabIndex = 4;
            this.lblBuy.Text = "Curs BUY";
            // 
            // cbValutaTinta
            // 
            this.cbValutaTinta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValutaTinta.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbValutaTinta.Location = new System.Drawing.Point(200, 59);
            this.cbValutaTinta.Name = "cbValutaTinta";
            this.cbValutaTinta.Size = new System.Drawing.Size(160, 29);
            this.cbValutaTinta.TabIndex = 3;
            // 
            // lblTinta
            // 
            this.lblTinta.AutoSize = true;
            this.lblTinta.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTinta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTinta.Location = new System.Drawing.Point(200, 37);
            this.lblTinta.Name = "lblTinta";
            this.lblTinta.Size = new System.Drawing.Size(109, 21);
            this.lblTinta.TabIndex = 2;
            this.lblTinta.Text = "Valuta tinta";
            // 
            // cbValutaBaza
            // 
            this.cbValutaBaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValutaBaza.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbValutaBaza.Location = new System.Drawing.Point(20, 59);
            this.cbValutaBaza.Name = "cbValutaBaza";
            this.cbValutaBaza.Size = new System.Drawing.Size(160, 29);
            this.cbValutaBaza.TabIndex = 1;
            // 
            // lblBaza
            // 
            this.lblBaza.AutoSize = true;
            this.lblBaza.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBaza.Location = new System.Drawing.Point(20, 37);
            this.lblBaza.Name = "lblBaza";
            this.lblBaza.Size = new System.Drawing.Size(135, 21);
            this.lblBaza.TabIndex = 0;
            this.lblBaza.Text = "Valuta de baza";
            // 
            // dgvCursuriExistente
            // 
            this.dgvCursuriExistente.AllowUserToAddRows = false;
            this.dgvCursuriExistente.AllowUserToDeleteRows = false;
            this.dgvCursuriExistente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursuriExistente.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvCursuriExistente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursuriExistente.ColumnHeadersHeight = 30;
            this.dgvCursuriExistente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCursuriExistente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursuriExistente.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvCursuriExistente.Location = new System.Drawing.Point(0, 220);
            this.dgvCursuriExistente.MultiSelect = false;
            this.dgvCursuriExistente.Name = "dgvCursuriExistente";
            this.dgvCursuriExistente.ReadOnly = true;
            this.dgvCursuriExistente.RowHeadersVisible = false;
            this.dgvCursuriExistente.RowHeadersWidth = 51;
            this.dgvCursuriExistente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursuriExistente.Size = new System.Drawing.Size(814, 280);
            this.dgvCursuriExistente.TabIndex = 2;
            // 
            // FormCursuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(814, 500);
            this.Controls.Add(this.dgvCursuriExistente);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FormCursuri";
            this.ShowIcon = false;
            this.Text = "Gestiune Cursuri";
            this.Load += new System.EventHandler(this.FormCursuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuriExistente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblBaza;
        private System.Windows.Forms.ComboBox cbValutaBaza;
        private System.Windows.Forms.Label lblTinta;
        private System.Windows.Forms.ComboBox cbValutaTinta;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.NumericUpDown numBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.NumericUpDown numSell;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.DataGridView dgvCursuriExistente;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}
