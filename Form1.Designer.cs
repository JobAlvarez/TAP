
namespace PIDETEC_JOB_ALVAREZ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbAcceso = new System.Windows.Forms.GroupBox();
            this.txtInvitado = new System.Windows.Forms.TextBox();
            this.chbInvitado = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAcceso
            // 
            this.gbAcceso.Controls.Add(this.txtInvitado);
            this.gbAcceso.Controls.Add(this.chbInvitado);
            this.gbAcceso.Controls.Add(this.txtUsuario);
            this.gbAcceso.Controls.Add(this.btnCancelar);
            this.gbAcceso.Controls.Add(this.btnAceptar);
            this.gbAcceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcceso.Location = new System.Drawing.Point(0, 0);
            this.gbAcceso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAcceso.Name = "gbAcceso";
            this.gbAcceso.Padding = new System.Windows.Forms.Padding(2);
            this.gbAcceso.Size = new System.Drawing.Size(325, 147);
            this.gbAcceso.TabIndex = 1;
            this.gbAcceso.TabStop = false;
            this.gbAcceso.Text = "Acceso";
            // 
            // txtInvitado
            // 
            this.txtInvitado.ForeColor = System.Drawing.Color.Gray;
            this.txtInvitado.Location = new System.Drawing.Point(27, 36);
            this.txtInvitado.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvitado.Name = "txtInvitado";
            this.txtInvitado.Size = new System.Drawing.Size(250, 21);
            this.txtInvitado.TabIndex = 6;
            this.txtInvitado.Text = "Ingresa tu nombre (MAYÚSCULAS).";
            this.txtInvitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInvitado.Click += new System.EventHandler(this.txtInvitado_Click);
            this.txtInvitado.TextChanged += new System.EventHandler(this.txtInvitado_TextChanged);
            this.txtInvitado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvitado_KeyPress);
            // 
            // chbInvitado
            // 
            this.chbInvitado.AutoSize = true;
            this.chbInvitado.Location = new System.Drawing.Point(45, 95);
            this.chbInvitado.Name = "chbInvitado";
            this.chbInvitado.Size = new System.Drawing.Size(68, 19);
            this.chbInvitado.TabIndex = 5;
            this.chbInvitado.Text = "Invitado";
            this.chbInvitado.UseVisualStyleBackColor = true;
            this.chbInvitado.CheckedChanged += new System.EventHandler(this.chbInvitado_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(27, 36);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 21);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Ingresa tu matricula o número de empleado.";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(209, 80);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(136, 80);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 46);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 147);
            this.ControlBox = false;
            this.Controls.Add(this.gbAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAcceso.ResumeLayout(false);
            this.gbAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcceso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chbInvitado;
        private System.Windows.Forms.TextBox txtInvitado;
    }
}

