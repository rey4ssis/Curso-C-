﻿namespace Projet_R
{
    partial class FmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forma1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forma2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forma3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forma1ToolStripMenuItem,
            this.forma2ToolStripMenuItem,
            this.forma3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // forma1ToolStripMenuItem
            // 
            this.forma1ToolStripMenuItem.Name = "forma1ToolStripMenuItem";
            this.forma1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.forma1ToolStripMenuItem.Text = "Forma 1";
            // 
            // forma2ToolStripMenuItem
            // 
            this.forma2ToolStripMenuItem.Name = "forma2ToolStripMenuItem";
            this.forma2ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.forma2ToolStripMenuItem.Text = "Forma 2";
            // 
            // forma3ToolStripMenuItem
            // 
            this.forma3ToolStripMenuItem.Name = "forma3ToolStripMenuItem";
            this.forma3ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.forma3ToolStripMenuItem.Text = "Forma 3";
            // 
            // FmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmMDI";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forma1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forma2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forma3ToolStripMenuItem;
    }
}

