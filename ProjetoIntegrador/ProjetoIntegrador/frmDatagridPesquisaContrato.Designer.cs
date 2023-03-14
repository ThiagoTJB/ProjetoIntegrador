namespace ProjetoIntegrador
{
    partial class frmDatagridPesquisaContrato
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
            this.dataGridParceiroPesquisa = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParceiroPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridParceiroPesquisa
            // 
            this.dataGridParceiroPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParceiroPesquisa.Location = new System.Drawing.Point(12, 41);
            this.dataGridParceiroPesquisa.Name = "dataGridParceiroPesquisa";
            this.dataGridParceiroPesquisa.RowTemplate.Height = 25;
            this.dataGridParceiroPesquisa.Size = new System.Drawing.Size(776, 405);
            this.dataGridParceiroPesquisa.TabIndex = 0;
            this.dataGridParceiroPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridParceiroPesquisa_CellContentClick);
        
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 1;
            // 
            // frmDatagridPesquisaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridParceiroPesquisa);
            this.Name = "frmDatagridPesquisaContrato";
            this.Text = "frmDatagridPesquisaContrato";
            this.Load += new System.EventHandler(this.frmDatagridPesquisaContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParceiroPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridParceiroPesquisa;
        private TextBox textBox1;
    }
}