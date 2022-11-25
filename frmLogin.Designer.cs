namespace Login_e_Registro_Sistema
{
    partial class frmLogin
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
            this.cadastrarFuncionario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLimparLogin = new System.Windows.Forms.Button();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.senhaUsuario = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.nomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.SuspendLayout();
            // 
            // cadastrarFuncionario
            // 
            this.cadastrarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cadastrarFuncionario.AutoSize = true;
            this.cadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarFuncionario.ForeColor = System.Drawing.Color.SeaGreen;
            this.cadastrarFuncionario.Location = new System.Drawing.Point(85, 342);
            this.cadastrarFuncionario.Name = "cadastrarFuncionario";
            this.cadastrarFuncionario.Size = new System.Drawing.Size(143, 17);
            this.cadastrarFuncionario.TabIndex = 32;
            this.cadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.cadastrarFuncionario.Click += new System.EventHandler(this.cadastrarFuncionario_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Clique aqui para";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonLimparLogin
            // 
            this.buttonLimparLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimparLogin.BackColor = System.Drawing.Color.White;
            this.buttonLimparLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonLimparLogin.Location = new System.Drawing.Point(49, 266);
            this.buttonLimparLogin.Name = "buttonLimparLogin";
            this.buttonLimparLogin.Size = new System.Drawing.Size(216, 35);
            this.buttonLimparLogin.TabIndex = 29;
            this.buttonLimparLogin.Text = "LIMPAR";
            this.buttonLimparLogin.UseVisualStyleBackColor = false;
            // 
            // buttonLogar
            // 
            this.buttonLogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogar.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonLogar.FlatAppearance.BorderSize = 0;
            this.buttonLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogar.ForeColor = System.Drawing.Color.White;
            this.buttonLogar.Location = new System.Drawing.Point(49, 225);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(216, 35);
            this.buttonLogar.TabIndex = 28;
            this.buttonLogar.Text = "LOGAR";
            this.buttonLogar.UseVisualStyleBackColor = false;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(49, 189);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(113, 21);
            this.checkBoxMostrarSenha.TabIndex = 27;
            this.checkBoxMostrarSenha.Text = "Mostrar Senha";
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(49, 162);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(216, 28);
            this.txtSenha.TabIndex = 21;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // senhaUsuario
            // 
            this.senhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhaUsuario.AutoSize = true;
            this.senhaUsuario.Location = new System.Drawing.Point(49, 142);
            this.senhaUsuario.Name = "senhaUsuario";
            this.senhaUsuario.Size = new System.Drawing.Size(45, 17);
            this.senhaUsuario.TabIndex = 20;
            this.senhaUsuario.Text = "Senha";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUsuario.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeUsuario.Location = new System.Drawing.Point(49, 94);
            this.txtNomeUsuario.Multiline = true;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(216, 28);
            this.txtNomeUsuario.TabIndex = 19;
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeUsuario.AutoSize = true;
            this.nomeUsuario.Location = new System.Drawing.Point(49, 74);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(116, 17);
            this.nomeUsuario.TabIndex = 18;
            this.nomeUsuario.Text = "Nome do Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Iniciar";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.SeaGreen;
            this.guna2ControlBox1.Location = new System.Drawing.Point(285, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 33;
            // 
            // guna2ResizeForm1
            // 
            this.guna2ResizeForm1.TargetForm = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 422);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cadastrarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLimparLogin);
            this.Controls.Add(this.buttonLogar);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.senhaUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP SEGUROS BRASIL";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cadastrarFuncionario;
        private Label label3;
        private Button buttonLimparLogin;
        private Button buttonLogar;
        private CheckBox checkBoxMostrarSenha;
        private TextBox txtSenha;
        private Label senhaUsuario;
        private TextBox txtNomeUsuario;
        private Label nomeUsuario;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
    }
}