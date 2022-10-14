namespace Projet_R.forma1
{
    partial class fm1_formulario1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ParametroEnviar = new System.Windows.Forms.TextBox();
            this.txtRecebida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parâmetro para Enviar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ParametroEnviar
            // 
            this.ParametroEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ParametroEnviar.Location = new System.Drawing.Point(16, 65);
            this.ParametroEnviar.Name = "ParametroEnviar";
            this.ParametroEnviar.Size = new System.Drawing.Size(325, 26);
            this.ParametroEnviar.TabIndex = 1;
            // 
            // txtRecebida
            // 
            this.txtRecebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRecebida.Location = new System.Drawing.Point(16, 187);
            this.txtRecebida.Name = "txtRecebida";
            this.txtRecebida.Size = new System.Drawing.Size(325, 26);
            this.txtRecebida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resposta Recebida: ";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(210, 97);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(131, 36);
            this.btn_enviar.TabIndex = 4;
            this.btn_enviar.Text = "Enviar para form2";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // fm1_formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 330);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txtRecebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParametroEnviar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm1_formulario1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "fm1_formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParametroEnviar;
        private System.Windows.Forms.TextBox txtRecebida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enviar;
    }
}