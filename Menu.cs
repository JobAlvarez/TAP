using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDETEC_JOB_ALVAREZ
{
    public partial class PIDETEC : Form
    {

        Form1 info = new Form1();
        //ToolStripLabel;
        //se declaran variebles de tipo int.
        public int progress, progressH, progressT, progressB, total;
        //Se mandan a llamar otros formularios que contienen las imagenes.
        ImagenB cambiarB = new ImagenB();
        ImagenT cambiarT = new ImagenT();
        ImagenH cambiarH = new ImagenH();
        Imagen cambiar = new Imagen();

        public static string usuarioCoectadoFinal;

        //Metodo PIDETEC.
        public PIDETEC()
        {
            //Inicializa los componentes
            InitializeComponent();
            //progress con valor 0.
            progress = 0;
            //lblNombre.Text = "Usuario conectado:" + Form1.UsuarioIngresado.ToString();
            //lblNombre.Text = "Usuario conectado:" + Form1.UsuarioIngresado2.ToString();
        }
        //Método que hace una control de un boton con un evento click.
        private void btnPapas_Click(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor progressB >= 0 && progressB <= 90 se ejecuta.
            if (progress>=0 && progress<=90)
            {
                //Suma 10 a la variable progress.
                progress += 10;
                //Se iguala la bara de progreso ala variable progress que amuenta cada vez que da click.
                pbPapas.Value = progress;
                //Suma 25 a la variable total.
                total += 25;
                //label que muestra el total
                lblT.Text = total.ToString();
            }
        }
        //Método que hace una control de un boton con un evento si el mouse permanece quieto sobre el control.
        private void btnPapas_MouseHover(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor es verdadero se ejecuta.
            if (true)
            {
                //Muestra el control "cambiar" al usuario.
                cambiar.Show();
            }

        }
        //Método que hace una control de un boton con un evento si el mouse permanece quieto sobre el control.
        private void btnHamburguesa_MouseHover(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor es verdadero se ejecuta.
            if (true)
            {
                //Muestra el control "cambiarH" al usuario.
                cambiarH.Show();
            }

        }
        //Método que hace una control de un boton con un evento si el mouse permanece quieto sobre el control.
        private void btnTacos_MouseHover(object sender, EventArgs e)
        {
            //Muestra el control "cambiarT" al usuario.
            cambiarT.Show();
        }
        //Método que hace una control de un boton con un evento si el mouse permanece quieto sobre el control.
        private void btnBoneless_MouseHover(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor es verdadero se ejecuta.
            if (true)
            {
                //Muestra el control "cambiarB" al usuario.
                cambiarB.Show();
            }                                                 
        }
        //Método que hace una control de un boton con un evento click.
        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor progressB >= 0 && progressB <= 90 se ejecuta.
            if (progressH >= 0 && progressH <= 90)
            {
                //Suma 50 a la variable total.
                total += 50;
                //Suma 10 a la variable progress.
                progressH += 10;
                //Se iguala la bara de progreso ala variable progress que amuenta cada vez que da click.
                pbHamburguesa.Value = progressH;
                //label que muestra el total
                lblT.Text = total.ToString();
            }
        }
        //Método que hace una control de un boton con un evento click.
        private void btnTacos_Click(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor progressB >= 0 && progressB <= 90 se ejecuta.
            if (progressT >= 0 && progressT <= 90)
            {
                //Suma 45 a la variable total.
                total += 45;
                //Suma 10 a la variable progress.
                progressT += 10;
                //Se iguala la bara de progreso ala variable progress que amuenta cada vez que da click.
                pbTacos.Value = progressT;
                //label que muestra el total
                lblT.Text = total.ToString();
            }
        }
        //Método que hace una control de un boton con un evento click.
        private void btnBoneless_Click(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor progressB >= 0 && progressB <= 90 se ejecuta.
            if (progressB >= 0 && progressB <= 90)
            {
                //Suma 60 a la variable total.
                total += 60;
                //Suma 10 a la variable progress.
                progressB += 10;
                //Se iguala la bara de progreso ala variable progress que amuenta cada vez que da click.
                pbBoneless.Value = progressB;
                //label que muestra el total
                lblT.Text = total.ToString();
            }
        }
        //Método que hace una control de un boton con un evento si el mouse no esta sobre el control.
        private void btnBoneless_MouseLeave(object sender, EventArgs e)
        {
            //Oculta el control "cambiarB" del usuario.
            cambiarB.Hide();
        }

        private void TspNombre_Click(object sender, EventArgs e)
        {

        }

        private void PIDETEC_Load(object sender, EventArgs e)
        {
            TspNombre.Text = Form1.usuarioCoectadoFinal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult CerrarSecion;
            CerrarSecion = MessageBox.Show("¿Deseas salir de la aplicación?", "Login TAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CerrarSecion == DialogResult.Yes)
            {
                Form1 muenucerrarsecion = new Form1();
                muenucerrarsecion.Show();
                this.Hide();
            }
            if (CerrarSecion == DialogResult.No)
            {
                return;
            }
        }

        //Método que hace una control de un label con un evento click.

        //Método que hace una control de un boton con un evento si el mouse no esta sobre el control.
        private void btnPapas_MouseLeave(object sender, EventArgs e)
        {
            //Oculta el control "cambiar" del usuario.
            cambiar.Hide();
        }
        //Método que hace una control de un boton con un evento si el mouse no esta sobre el control.
        private void btnHamburguesa_MouseLeave(object sender, EventArgs e)
        {
            //Oculta el control "cambiarH" del usuario.
            cambiarH.Hide();
        }
        //Método que hace una control de un boton con un evento si el mouse no esta sobre el control.
        private void btnTacos_MouseLeave(object sender, EventArgs e)
        {
            //Oculta el control "cambiarT" del usuario.
            cambiarT.Hide();
        } 
    }
}
