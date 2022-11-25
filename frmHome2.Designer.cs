namespace Login_e_Registro_Sistema
{
    partial class frmHome2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 134);
            this.panel1.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Data.ForeColor = System.Drawing.Color.White;
            this.Data.Location = new System.Drawing.Point(185, 65);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(294, 65);
            this.Data.TabIndex = 4;
            this.Data.Text = "00/00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "HORA:";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hora.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hora.ForeColor = System.Drawing.Color.White;
            this.Hora.Location = new System.Drawing.Point(185, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(222, 65);
            this.Hora.TabIndex = 1;
            this.Hora.Text = "13:50:14";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Identificação de abreviações(Fazer dpois)";
            // 
            // frmHome2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(778, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome2";
            this.Text = "frmHome2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Hora;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label Data;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Label label3;
    }
}