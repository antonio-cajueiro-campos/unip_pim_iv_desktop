namespace Login_e_Registro_Sistema
{
    partial class frmClientList
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
            this.credentialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteOutputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAtuList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteOutputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUsuario.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeUsuario.Location = new System.Drawing.Point(12, 31);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(664, 48);
            this.txtNomeUsuario.TabIndex = 20;
            this.txtNomeUsuario.Text = "Lucas";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.SeaGreen;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.Location = new System.Drawing.Point(682, 31);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 48);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(569, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtuList
            // 
            this.btnAtuList.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAtuList.FlatAppearance.BorderSize = 0;
            this.btnAtuList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtuList.ForeColor = System.Drawing.Color.White;
            this.btnAtuList.Location = new System.Drawing.Point(12, 439);
            this.btnAtuList.Name = "btnAtuList";
            this.btnAtuList.Size = new System.Drawing.Size(143, 39);
            this.btnAtuList.TabIndex = 24;
            this.btnAtuList.Text = "Atualizar Lista";
            this.btnAtuList.UseVisualStyleBackColor = false;
            this.btnAtuList.Click += new System.EventHandler(this.btnAtuList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.userNameDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.clienteViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(754, 336);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChavePIX";
            this.dataGridViewTextBoxColumn3.HeaderText = "ChavePIX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clienteViewBindingSource
            // 
            this.clienteViewBindingSource.DataSource = typeof(Login_e_Registro_Sistema.Models.ClienteView);
            // 
            // frmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(778, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtuList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtNomeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientList";
            this.Text = "frmClientList";
            this.Load += new System.EventHandler(this.frmClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteOutputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource credentialBindingSource;
        private TextBox txtNomeUsuario;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private BindingSource clienteOutputBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chavePIXDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private Button btnAtuList;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource clienteViewBindingSource;
    }
}