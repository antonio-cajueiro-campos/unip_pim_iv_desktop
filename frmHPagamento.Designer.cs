namespace Login_e_Registro_Sistema
{
    partial class frmHPagamento
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
            this.dataGridViewHP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHP
            // 
            this.dataGridViewHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHP.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewHP.Name = "dataGridViewHP";
            this.dataGridViewHP.RowTemplate.Height = 25;
            this.dataGridViewHP.Size = new System.Drawing.Size(603, 370);
            this.dataGridViewHP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historico de Pagamento do cliente :";
            // 
            // clientNameHP
            // 
            this.clientNameHP.AutoSize = true;
            this.clientNameHP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientNameHP.ForeColor = System.Drawing.Color.White;
            this.clientNameHP.Location = new System.Drawing.Point(264, 30);
            this.clientNameHP.Name = "clientNameHP";
            this.clientNameHP.Size = new System.Drawing.Size(190, 20);
            this.clientNameHP.TabIndex = 2;
            this.clientNameHP.Text = "Lucas Fernandes de Moraes";
            // 
            // frmHPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.clientNameHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHP);
            this.Name = "frmHPagamento";
            this.ShowIcon = false;
            this.Text = "Historico de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewHP;
        private Label label1;
        private Label clientNameHP;
    }
}