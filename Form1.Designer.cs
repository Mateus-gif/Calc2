namespace Calc
{
    partial class MyForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKreditbetrag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTilgung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abnnuität = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestschuld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLaufzeit = new System.Windows.Forms.TextBox();
            this.textBoxTilgungssatz = new System.Windows.Forms.TextBox();
            this.textBoxZinsatz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-288, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kreditbetrag:";
            // 
            // textBoxKreditbetrag
            // 
            this.textBoxKreditbetrag.Location = new System.Drawing.Point(72, 81);
            this.textBoxKreditbetrag.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxKreditbetrag.Name = "textBoxKreditbetrag";
            this.textBoxKreditbetrag.Size = new System.Drawing.Size(196, 31);
            this.textBoxKreditbetrag.TabIndex = 8;
            this.textBoxKreditbetrag.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1056, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Zinsbindungsfrist (Laufzeit)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "anfänglicher Tilgungssatz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Zinssatz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kreditbetrag:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(1390, 73);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(294, 44);
            this.buttonCalc.TabIndex = 23;
            this.buttonCalc.Text = "Berechnen";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colYear,
            this.Column1,
            this.colZins,
            this.colTilgung,
            this.Abnnuität,
            this.colRestschuld});
            this.dataGridView.Location = new System.Drawing.Point(30, 187);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(2094, 692);
            this.dataGridView.TabIndex = 22;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Jahr";
            this.colYear.MinimumWidth = 10;
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colYear.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kreditbetrag";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // colZins
            // 
            this.colZins.HeaderText = "Zins";
            this.colZins.MinimumWidth = 10;
            this.colZins.Name = "colZins";
            this.colZins.ReadOnly = true;
            this.colZins.Width = 200;
            // 
            // colTilgung
            // 
            this.colTilgung.HeaderText = "Tilgung";
            this.colTilgung.MinimumWidth = 10;
            this.colTilgung.Name = "colTilgung";
            this.colTilgung.ReadOnly = true;
            this.colTilgung.Width = 200;
            // 
            // Abnnuität
            // 
            this.Abnnuität.HeaderText = "Annuität";
            this.Abnnuität.MinimumWidth = 10;
            this.Abnnuität.Name = "Abnnuität";
            this.Abnnuität.ReadOnly = true;
            this.Abnnuität.Width = 200;
            // 
            // colRestschuld
            // 
            this.colRestschuld.HeaderText = "Restschuld";
            this.colRestschuld.MinimumWidth = 10;
            this.colRestschuld.Name = "colRestschuld";
            this.colRestschuld.ReadOnly = true;
            this.colRestschuld.Width = 200;
            // 
            // textBoxLaufzeit
            // 
            this.textBoxLaufzeit.Location = new System.Drawing.Point(1066, 81);
            this.textBoxLaufzeit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxLaufzeit.Name = "textBoxLaufzeit";
            this.textBoxLaufzeit.Size = new System.Drawing.Size(196, 31);
            this.textBoxLaufzeit.TabIndex = 20;
            this.textBoxLaufzeit.Text = "10";
            // 
            // textBoxTilgungssatz
            // 
            this.textBoxTilgungssatz.Location = new System.Drawing.Point(636, 79);
            this.textBoxTilgungssatz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxTilgungssatz.Name = "textBoxTilgungssatz";
            this.textBoxTilgungssatz.Size = new System.Drawing.Size(196, 31);
            this.textBoxTilgungssatz.TabIndex = 21;
            this.textBoxTilgungssatz.Text = "2";
            // 
            // textBoxZinsatz
            // 
            this.textBoxZinsatz.Location = new System.Drawing.Point(372, 79);
            this.textBoxZinsatz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxZinsatz.Name = "textBoxZinsatz";
            this.textBoxZinsatz.Size = new System.Drawing.Size(196, 31);
            this.textBoxZinsatz.TabIndex = 19;
            this.textBoxZinsatz.Text = "3";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2148, 952);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxLaufzeit);
            this.Controls.Add(this.textBoxTilgungssatz);
            this.Controls.Add(this.textBoxZinsatz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKreditbetrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MyForm";
            this.Text = "Kreditrechner";
            this.Load += new System.EventHandler(this.MyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKreditbetrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxLaufzeit;
        private System.Windows.Forms.TextBox textBoxTilgungssatz;
        private System.Windows.Forms.TextBox textBoxZinsatz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTilgung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abnnuität;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestschuld;
    }
}

