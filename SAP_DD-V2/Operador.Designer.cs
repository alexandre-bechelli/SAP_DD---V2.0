namespace SAP_DD_V2
{
    partial class Operador
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
            this.fo_d_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fo_d_btn
            // 
            this.fo_d_btn.Location = new System.Drawing.Point(92, 52);
            this.fo_d_btn.Name = "fo_d_btn";
            this.fo_d_btn.Size = new System.Drawing.Size(106, 32);
            this.fo_d_btn.TabIndex = 0;
            this.fo_d_btn.Text = "Folha de defeito";
            this.fo_d_btn.UseVisualStyleBackColor = true;
            this.fo_d_btn.Click += new System.EventHandler(this.fo_d_btn_Click);
            // 
            // Operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fo_d_btn);
            this.Name = "Operador";
            this.Text = "Operador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fo_d_btn;
    }
}