namespace Projet_R.forma1
{
    partial class fm1_formulario2
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
            this.btn_devolver = new System.Windows.Forms.Button();
            this.txtDevolver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ParametroRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(208, 214);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(131, 36);
            this.btn_devolver.TabIndex = 9;
            this.btn_devolver.Text = "Devolver para form1";
            this.btn_devolver.UseVisualStyleBackColor = true;
            // 
            // txtDevolver
            // 
            this.txtDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDevolver.Location = new System.Drawing.Point(14, 144);
            this.txtDevolver.Name = "txtDevolver";
            this.txtDevolver.Size = new System.Drawing.Size(325, 26);
            this.txtDevolver.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resposta a Devolver";
            // 
            // ParametroRecebido
            // 
            this.ParametroRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ParametroRecebido.Location = new System.Drawing.Point(15, 53);
            this.ParametroRecebido.Name = "ParametroRecebido";
            this.ParametroRecebido.Size = new System.Drawing.Size(325, 26);
            this.ParametroRecebido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parâmetro Recebido: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fm1_formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 330);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.txtDevolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParametroRecebido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm1_formulario2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "fm1_formulario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.TextBox txtDevolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParametroRecebido;
        private System.Windows.Forms.Label label1;
    }
}