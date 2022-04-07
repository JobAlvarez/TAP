
namespace PIDETEC_JOB_ALVAREZ
{
    partial class Imagen
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
            this.pctPapas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapas)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPapas
            // 
            this.pctPapas.Image = global::PIDETEC_JOB_ALVAREZ.Properties.Resources.papas;
            this.pctPapas.Location = new System.Drawing.Point(-2, 0);
            this.pctPapas.Name = "pctPapas";
            this.pctPapas.Size = new System.Drawing.Size(234, 175);
            this.pctPapas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPapas.TabIndex = 0;
            this.pctPapas.TabStop = false;
            // 
            // Imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 174);
            this.ControlBox = false;
            this.Controls.Add(this.pctPapas);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Imagen";
            this.ShowInTaskbar = false;
            this.Text = "Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.pctPapas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPapas;
    }
}