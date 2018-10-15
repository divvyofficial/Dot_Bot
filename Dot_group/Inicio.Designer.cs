namespace Bots
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.linkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelErro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.btLogar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 228);
            this.button1.TabIndex = 19;
            this.button1.Text = "iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkEsqueciSenha
            // 
            this.linkEsqueciSenha.AutoSize = true;
            this.linkEsqueciSenha.Location = new System.Drawing.Point(107, 171);
            this.linkEsqueciSenha.Name = "linkEsqueciSenha";
            this.linkEsqueciSenha.Size = new System.Drawing.Size(111, 13);
            this.linkEsqueciSenha.TabIndex = 18;
            this.linkEsqueciSenha.TabStop = true;
            this.linkEsqueciSenha.Text = "Esqueci minha senha!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Version:";
            // 
            // labelErro
            // 
            this.labelErro.AutoEllipsis = true;
            this.labelErro.AutoSize = true;
            this.labelErro.Location = new System.Drawing.Point(11, 186);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(0, 13);
            this.labelErro.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(119, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(80, 84);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(44, 13);
            this.labelSenha.TabIndex = 14;
            this.labelSenha.Text = "Senha: ";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(80, 43);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(49, 13);
            this.labelUsuario.TabIndex = 13;
            this.labelUsuario.Text = "Usuário: ";
            // 
            // btLogar
            // 
            this.btLogar.Location = new System.Drawing.Point(83, 141);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(161, 23);
            this.btLogar.TabIndex = 12;
            this.btLogar.Text = "OK";
            this.btLogar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtSenha.Location = new System.Drawing.Point(83, 100);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(161, 23);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtUsuario.Location = new System.Drawing.Point(83, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.Text = "roberto";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkEsqueciSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Inicio";
            this.Text = "Bot Teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkEsqueciSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelErro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}

