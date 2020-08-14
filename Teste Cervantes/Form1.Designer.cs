namespace Teste_Cervantes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_idade = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.text_telefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(195, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_nome
            // 
            this.text_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_nome.Location = new System.Drawing.Point(304, 22);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(484, 23);
            this.text_nome.TabIndex = 2;
            this.text_nome.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(67, 61);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(237, 23);
            this.text_email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(324, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade:\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(467, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone para contato:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_idade
            // 
            this.text_idade.Location = new System.Drawing.Point(369, 61);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(71, 23);
            this.text_idade.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MintCream;
            this.btn_save.Location = new System.Drawing.Point(170, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 38);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_codigo
            // 
            this.text_codigo.Location = new System.Drawing.Point(67, 22);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(102, 23);
            this.text_codigo.TabIndex = 1;
            this.text_codigo.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // tableUsers
            // 
            this.tableUsers.AllowUserToAddRows = false;
            this.tableUsers.AllowUserToDeleteRows = false;
            this.tableUsers.AllowUserToOrderColumns = true;
            this.tableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUsers.BackgroundColor = System.Drawing.Color.White;
            this.tableUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Location = new System.Drawing.Point(4, 178);
            this.tableUsers.MultiSelect = false;
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.ReadOnly = true;
            this.tableUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableUsers.Size = new System.Drawing.Size(804, 344);
            this.tableUsers.TabIndex = 9;
            this.tableUsers.Text = "dataGridView1";
            this.tableUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUsers_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MintCream;
            this.btn_delete.Location = new System.Drawing.Point(324, 115);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 38);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Remover";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.MintCream;
            this.cancel.Location = new System.Drawing.Point(481, 115);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(129, 38);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.reset_Click);
            // 
            // text_telefone
            // 
            this.text_telefone.Location = new System.Drawing.Point(597, 61);
            this.text_telefone.Mask = "(00)00000-9999";
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(191, 23);
            this.text_telefone.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(811, 524);
            this.Controls.Add(this.text_telefone);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tableUsers);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.text_idade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = " Cadastro de Usuários";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.MaskedTextBox text_telefone;
    }
}

