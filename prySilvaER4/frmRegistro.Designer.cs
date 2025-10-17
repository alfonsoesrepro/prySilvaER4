namespace prySilvaER4
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            dgvRegistro = new DataGridView();
            colMozo = new DataGridViewTextBoxColumn();
            cmlComidas = new DataGridViewTextBoxColumn();
            cmlBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            cmlBebidasConAlcohol = new DataGridViewTextBoxColumn();
            cmlPostres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistro
            // 
            dgvRegistro.AllowUserToAddRows = false;
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Columns.AddRange(new DataGridViewColumn[] { colMozo, cmlComidas, cmlBebidasSinAlcohol, cmlBebidasConAlcohol, cmlPostres });
            dgvRegistro.Location = new Point(7, 11);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.RowHeadersVisible = false;
            dgvRegistro.Size = new Size(503, 337);
            dgvRegistro.TabIndex = 0;
            dgvRegistro.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMozo
            // 
            colMozo.HeaderText = "Mozos";
            colMozo.Name = "colMozo";
            // 
            // cmlComidas
            // 
            cmlComidas.HeaderText = "Comidas";
            cmlComidas.Name = "cmlComidas";
            // 
            // cmlBebidasSinAlcohol
            // 
            cmlBebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            cmlBebidasSinAlcohol.Name = "cmlBebidasSinAlcohol";
            // 
            // cmlBebidasConAlcohol
            // 
            cmlBebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            cmlBebidasConAlcohol.Name = "cmlBebidasConAlcohol";
            // 
            // cmlPostres
            // 
            cmlPostres.HeaderText = "Postres";
            cmlPostres.Name = "cmlPostres";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 450);
            Controls.Add(dgvRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistro";
            Text = "Bar La Milanga - Registro de ventas";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRegistro;
        private DataGridViewTextBoxColumn colMozo;
        private DataGridViewTextBoxColumn cmlComidas;
        private DataGridViewTextBoxColumn cmlBebidasSinAlcohol;
        private DataGridViewTextBoxColumn cmlBebidasConAlcohol;
        private DataGridViewTextBoxColumn cmlPostres;
    }
}
