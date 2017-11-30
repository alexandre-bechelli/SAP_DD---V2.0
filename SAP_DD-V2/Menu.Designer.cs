namespace SAP_DD_V2
{
    partial class Menu
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
            this.login_bx = new System.Windows.Forms.ComboBox();
            this.senha_bx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_bx
            // 
            this.login_bx.FormattingEnabled = true;
            this.login_bx.Items.AddRange(new object[] {
            "Operador",
            "Encarregado"});
            this.login_bx.Location = new System.Drawing.Point(59, 12);
            this.login_bx.Name = "login_bx";
            this.login_bx.Size = new System.Drawing.Size(76, 21);
            this.login_bx.TabIndex = 0;
            // 
            // senha_bx
            // 
            this.senha_bx.Location = new System.Drawing.Point(59, 42);
            this.senha_bx.Name = "senha_bx";
            this.senha_bx.Size = new System.Drawing.Size(76, 20);
            this.senha_bx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(150, 15);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(58, 23);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 83);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha_bx);
            this.Controls.Add(this.login_bx);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox login_bx;
        private System.Windows.Forms.TextBox senha_bx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label2;
    }
}

