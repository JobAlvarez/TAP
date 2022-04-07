
namespace PIDETEC_JOB_ALVAREZ
{
    partial class PIDETEC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIDETEC));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnBoneless = new System.Windows.Forms.Button();
            this.btnTacos = new System.Windows.Forms.Button();
            this.btnHamburguesa = new System.Windows.Forms.Button();
            this.btnPapas = new System.Windows.Forms.Button();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.lblBoneless = new System.Windows.Forms.Label();
            this.lblTacos = new System.Windows.Forms.Label();
            this.lblHamburguesa = new System.Windows.Forms.Label();
            this.lblPapas = new System.Windows.Forms.Label();
            this.pbBoneless = new System.Windows.Forms.ProgressBar();
            this.pbTacos = new System.Windows.Forms.ProgressBar();
            this.pbHamburguesa = new System.Windows.Forms.ProgressBar();
            this.pbPapas = new System.Windows.Forms.ProgressBar();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TspNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.gbOpciones.SuspendLayout();
            this.gbDetalles.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnBoneless);
            this.gbOpciones.Controls.Add(this.btnTacos);
            this.gbOpciones.Controls.Add(this.btnHamburguesa);
            this.gbOpciones.Controls.Add(this.btnPapas);
            this.gbOpciones.Location = new System.Drawing.Point(12, 86);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(134, 239);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // btnBoneless
            // 
            this.btnBoneless.Location = new System.Drawing.Point(6, 185);
            this.btnBoneless.Name = "btnBoneless";
            this.btnBoneless.Size = new System.Drawing.Size(93, 54);
            this.btnBoneless.TabIndex = 3;
            this.btnBoneless.Text = "Boneless";
            this.btnBoneless.UseVisualStyleBackColor = true;
            this.btnBoneless.Click += new System.EventHandler(this.btnBoneless_Click);
            this.btnBoneless.MouseLeave += new System.EventHandler(this.btnBoneless_MouseLeave);
            this.btnBoneless.MouseHover += new System.EventHandler(this.btnBoneless_MouseHover);
            // 
            // btnTacos
            // 
            this.btnTacos.Location = new System.Drawing.Point(6, 129);
            this.btnTacos.Name = "btnTacos";
            this.btnTacos.Size = new System.Drawing.Size(95, 50);
            this.btnTacos.TabIndex = 2;
            this.btnTacos.Text = "Tacos";
            this.btnTacos.UseVisualStyleBackColor = true;
            this.btnTacos.Click += new System.EventHandler(this.btnTacos_Click);
            this.btnTacos.MouseLeave += new System.EventHandler(this.btnTacos_MouseLeave);
            this.btnTacos.MouseHover += new System.EventHandler(this.btnTacos_MouseHover);
            // 
            // btnHamburguesa
            // 
            this.btnHamburguesa.Location = new System.Drawing.Point(6, 74);
            this.btnHamburguesa.Name = "btnHamburguesa";
            this.btnHamburguesa.Size = new System.Drawing.Size(95, 49);
            this.btnHamburguesa.TabIndex = 1;
            this.btnHamburguesa.Text = "Hamburguesa";
            this.btnHamburguesa.UseVisualStyleBackColor = true;
            this.btnHamburguesa.Click += new System.EventHandler(this.btnHamburguesa_Click);
            this.btnHamburguesa.MouseLeave += new System.EventHandler(this.btnHamburguesa_MouseLeave);
            this.btnHamburguesa.MouseHover += new System.EventHandler(this.btnHamburguesa_MouseHover);
            // 
            // btnPapas
            // 
            this.btnPapas.Location = new System.Drawing.Point(6, 20);
            this.btnPapas.Name = "btnPapas";
            this.btnPapas.Size = new System.Drawing.Size(95, 46);
            this.btnPapas.TabIndex = 0;
            this.btnPapas.Text = "Papas fritas";
            this.btnPapas.UseVisualStyleBackColor = true;
            this.btnPapas.Click += new System.EventHandler(this.btnPapas_Click);
            this.btnPapas.MouseLeave += new System.EventHandler(this.btnPapas_MouseLeave);
            this.btnPapas.MouseHover += new System.EventHandler(this.btnPapas_MouseHover);
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.lblBoneless);
            this.gbDetalles.Controls.Add(this.lblTacos);
            this.gbDetalles.Controls.Add(this.lblHamburguesa);
            this.gbDetalles.Controls.Add(this.lblPapas);
            this.gbDetalles.Controls.Add(this.pbBoneless);
            this.gbDetalles.Controls.Add(this.pbTacos);
            this.gbDetalles.Controls.Add(this.pbHamburguesa);
            this.gbDetalles.Controls.Add(this.pbPapas);
            this.gbDetalles.Location = new System.Drawing.Point(152, 86);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(279, 239);
            this.gbDetalles.TabIndex = 1;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles";
            // 
            // lblBoneless
            // 
            this.lblBoneless.AutoSize = true;
            this.lblBoneless.Location = new System.Drawing.Point(6, 200);
            this.lblBoneless.Name = "lblBoneless";
            this.lblBoneless.Size = new System.Drawing.Size(50, 13);
            this.lblBoneless.TabIndex = 7;
            this.lblBoneless.Text = "Boneless";
            // 
            // lblTacos
            // 
            this.lblTacos.AutoSize = true;
            this.lblTacos.Location = new System.Drawing.Point(6, 140);
            this.lblTacos.Name = "lblTacos";
            this.lblTacos.Size = new System.Drawing.Size(37, 13);
            this.lblTacos.TabIndex = 6;
            this.lblTacos.Text = "Tacos";
            // 
            // lblHamburguesa
            // 
            this.lblHamburguesa.AutoSize = true;
            this.lblHamburguesa.Location = new System.Drawing.Point(6, 84);
            this.lblHamburguesa.Name = "lblHamburguesa";
            this.lblHamburguesa.Size = new System.Drawing.Size(73, 13);
            this.lblHamburguesa.TabIndex = 5;
            this.lblHamburguesa.Text = "Hamburguesa";
            // 
            // lblPapas
            // 
            this.lblPapas.AutoSize = true;
            this.lblPapas.Location = new System.Drawing.Point(6, 27);
            this.lblPapas.Name = "lblPapas";
            this.lblPapas.Size = new System.Drawing.Size(62, 13);
            this.lblPapas.TabIndex = 4;
            this.lblPapas.Text = "Papas fritas";
            // 
            // pbBoneless
            // 
            this.pbBoneless.Location = new System.Drawing.Point(6, 216);
            this.pbBoneless.Name = "pbBoneless";
            this.pbBoneless.Size = new System.Drawing.Size(267, 23);
            this.pbBoneless.TabIndex = 3;
            // 
            // pbTacos
            // 
            this.pbTacos.Location = new System.Drawing.Point(6, 156);
            this.pbTacos.Name = "pbTacos";
            this.pbTacos.Size = new System.Drawing.Size(267, 23);
            this.pbTacos.TabIndex = 2;
            // 
            // pbHamburguesa
            // 
            this.pbHamburguesa.Location = new System.Drawing.Point(6, 100);
            this.pbHamburguesa.Name = "pbHamburguesa";
            this.pbHamburguesa.Size = new System.Drawing.Size(267, 23);
            this.pbHamburguesa.TabIndex = 1;
            // 
            // pbPapas
            // 
            this.pbPapas.Location = new System.Drawing.Point(6, 43);
            this.pbPapas.Name = "pbPapas";
            this.pbPapas.Size = new System.Drawing.Size(267, 23);
            this.pbPapas.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(65, 4);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(303, 79);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "PIDETEC";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 335);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(164, 51);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 4;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(162, 335);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 44);
            this.lblT.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 398);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TspNombre,
            this.BtnCerrar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(437, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TspNombre
            // 
            this.TspNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TspNombre.Name = "TspNombre";
            this.TspNombre.Size = new System.Drawing.Size(109, 17);
            this.TspNombre.Text = "Usuario conectado:";
            this.TspNombre.Click += new System.EventHandler(this.TspNombre_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::PIDETEC_JOB_ALVAREZ.Properties.Resources.baseline_close_black_18dp;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(29, 20);
            this.BtnCerrar.Text = "Cerrar secion";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PIDETEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(437, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.gbDetalles);
            this.Controls.Add(this.gbOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PIDETEC";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.PIDETEC_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnBoneless;
        private System.Windows.Forms.Button btnTacos;
        private System.Windows.Forms.Button btnHamburguesa;
        private System.Windows.Forms.Button btnPapas;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.ProgressBar pbBoneless;
        private System.Windows.Forms.ProgressBar pbTacos;
        private System.Windows.Forms.ProgressBar pbHamburguesa;
        private System.Windows.Forms.ProgressBar pbPapas;
        private System.Windows.Forms.Label lblBoneless;
        private System.Windows.Forms.Label lblTacos;
        private System.Windows.Forms.Label lblHamburguesa;
        private System.Windows.Forms.Label lblPapas;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblT;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TspNombre;
        private System.Windows.Forms.ToolStripDropDownButton BtnCerrar;
    }
}