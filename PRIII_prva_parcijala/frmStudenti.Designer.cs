namespace PRIII_prva_parcijala
{
    partial class frmStudenti
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.lbDetalji = new System.Windows.Forms.Label();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.brojIndeksaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosjecnaOcjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPolozenihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite broj indeksa:";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojIndeksa.Location = new System.Drawing.Point(203, 32);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(480, 28);
            this.txtBrojIndeksa.TabIndex = 1;
            this.txtBrojIndeksa.TextChanged += new System.EventHandler(this.txtBrojIndeksa_TextChanged);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(689, 23);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(117, 42);
            this.btnDetalji.TabIndex = 2;
            this.btnDetalji.Text = "Prikazi detalje";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(812, 25);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(117, 42);
            this.btnNovi.TabIndex = 3;
            this.btnNovi.Text = "Novi student";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // lbDetalji
            // 
            this.lbDetalji.AutoSize = true;
            this.lbDetalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalji.Location = new System.Drawing.Point(16, 408);
            this.lbDetalji.Name = "lbDetalji";
            this.lbDetalji.Size = new System.Drawing.Size(0, 18);
            this.lbDetalji.TabIndex = 5;
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.AutoGenerateColumns = false;
            this.dgvStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojIndeksaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.prosjecnaOcjenaDataGridViewTextBoxColumn,
            this.brojPolozenihDataGridViewTextBoxColumn});
            this.dgvStudenti.DataSource = this.studentBindingSource;
            this.dgvStudenti.Location = new System.Drawing.Point(16, 80);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(913, 301);
            this.dgvStudenti.TabIndex = 6;
            // 
            // brojIndeksaDataGridViewTextBoxColumn
            // 
            this.brojIndeksaDataGridViewTextBoxColumn.DataPropertyName = "BrojIndeksa";
            this.brojIndeksaDataGridViewTextBoxColumn.HeaderText = "BrojIndeksa";
            this.brojIndeksaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojIndeksaDataGridViewTextBoxColumn.Name = "brojIndeksaDataGridViewTextBoxColumn";
            this.brojIndeksaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prosjecnaOcjenaDataGridViewTextBoxColumn
            // 
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.DataPropertyName = "ProsjecnaOcjena";
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.HeaderText = "ProsjecnaOcjena";
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.Name = "prosjecnaOcjenaDataGridViewTextBoxColumn";
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojPolozenihDataGridViewTextBoxColumn
            // 
            this.brojPolozenihDataGridViewTextBoxColumn.DataPropertyName = "BrojPolozenih";
            this.brojPolozenihDataGridViewTextBoxColumn.HeaderText = "BrojPolozenih";
            this.brojPolozenihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPolozenihDataGridViewTextBoxColumn.Name = "brojPolozenihDataGridViewTextBoxColumn";
            this.brojPolozenihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(PRIII_prva_parcijala.Student);
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.lbDetalji);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.label1);
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Label lbDetalji;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojIndeksaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosjecnaOcjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojPolozenihDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}