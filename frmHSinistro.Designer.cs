namespace Login_e_Registro_Sistema
{
    partial class frmHSinistro
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
            this.clientNameHS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHS)).BeginInit();
            this.SuspendLayout();
            // 
            // clientNameHS
            // 
            this.clientNameHS.AutoSize = true;
            this.clientNameHS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientNameHS.ForeColor = System.Drawing.Color.White;
            this.clientNameHS.Location = new System.Drawing.Point(239, 30);
            this.clientNameHS.Name = "clientNameHS";
            this.clientNameHS.Size = new System.Drawing.Size(190, 20);
            this.clientNameHS.TabIndex = 5;
            this.clientNameHS.Text = "Lucas Fernandes de Moraes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historico do Sinistro do cliente :";
            // 
            // dataGridViewHS
            // 
            this.dataGridViewHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHS.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewHS.Name = "dataGridViewHS";
            this.dataGridViewHS.RowTemplate.Height = 25;
            this.dataGridViewHS.Size = new System.Drawing.Size(603, 370);
            this.dataGridViewHS.TabIndex = 3;
            // 
            // frmHSinistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.clientNameHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHS);
            this.Name = "frmHSinistro";
            this.ShowIcon = false;
            this.Text = "Historico do Sinistro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clientNameHS;
        private Label label1;
        private DataGridView dataGridViewHS;
    }
}