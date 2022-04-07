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
    //Clase form1 principal
    public partial class Form1 : Form
    {
        /*
       -Nombre de práctica: PIDETEC.
       -Tema de referencia: Unidad I: Interfaz gráfica de usuario. .
       -Objetivo de la práctica: DESARROLLAR E IMPLEMENTAR UNA APLICACIÓN PARA WINDOWS FORMS,
        HACIENDO USO DEL LENGUAJE DE PROGRAMACIÓN C# Y EL IDE VISUAL STUDIO
        COMMUNITY EDITION (2015+), QUE PERMITA TOMAR ORDENES DE COMIDA EN
        LA CAFETERÍA DE UNA INSTITUCIÓN EDUCATIVA. 
       -Materia: Tópicos avanzados de programación.
       -Alumno: Job Alberto Alvarez Loza.
       */

        public static string usuarioCoectadoFinal;
        public static string UsuarioIngresado;
        public static string UsuarioIngresado2;
        //Se crea un directorio para alumnos.
        Dictionary<string, string> alumnos = new Dictionary<string, string>();
        //Se crea un directorio para empeados.
        Dictionary<string, string> empleados = new Dictionary<string, string>();
        //Se crea una varieble global y de tipo public static.
        public static string usuario;
        //Metodo form1
        public Form1()
        {
            //Inicializa los componentes
            InitializeComponent();
            //Se llena el directorio de alumnos.
            alumnos.Add("201000079", "ALVAREZ LOZA JOB ALBERTO");
            alumnos.Add("201000180", "AVITIA MUÑIZ ELIENAI AZUCENA");
            alumnos.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");
            alumnos.Add("201000068", "CENICEROS CABRERA YOHEL");
            alumnos.Add("201000078", "HERNANDEZ AGUILAR NAYDELIN GUADALUPE");
            alumnos.Add("201000130", "JIMENEZ IBARRA HECTOR ADAIR");
            alumnos.Add("201000133", "LOZA MILAN LEONARDO");
            alumnos.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");
            alumnos.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");
            alumnos.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");
            //Se llena el directorio de empleados.
            empleados.Add("001", "ALEJANDRO DANIEL REYES EQUIVEL");
            empleados.Add("002", "ISABEL ESMERALDA CARILLO RODRIGUEZ");
            empleados.Add("003", "JAIME EMMANUEL QUISTIAN SANCHEZ");
            empleados.Add("004", "CHRISTIAN HUMBERTO PONCE FLORES");
            empleados.Add("005", "ADRIANA ZURITA DE LA CRUZ");
            empleados.Add("006", "DANIELA RAMIREZ MARTINEZ");
            empleados.Add("007", "KEVIN OROZCO REBOLLAR");
            empleados.Add("008", "FANNY BERLANGA ESCOBEDO");
            empleados.Add("009", "LEONARDO LOZA MILAN");
            empleados.Add("010", "ALLISON MURILLO LOZA");

            UsuarioIngresado2 = txtUsuario.Text.ToString();
            UsuarioIngresado = txtInvitado.Text.ToString();
        }
        //Método que hace un control de caja de texto con un evento de cambio de valor de própiedad.
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //cambia el color de letra a negro en el txtusuario
            txtUsuario.ForeColor = Color.Black;
        }
        //Método que hace un control de caja de texto con un evento de click sobre el cotrol.
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            //Borra el contenido de la caja de usuario.
            txtUsuario.Text = string.Empty;
        }
        //Método que hace un control de caja de texto con un evento de activacion en el formulario.
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el usuario borra el contenido de la caja de usuario se ejecuta.
            if (txtUsuario.Text == string.Empty)
            {
                //Caja de texto con un mensaje.
                txtUsuario.Text = Text;
            }
            //Cambia el color de las letras dentro de la caja de texto.
            txtUsuario.ForeColor = Color.Gray;
        }
        //Método que hace un control de boton con el evento click.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Declarar una variable de tipo DailogREsult.
            //se guarda la opcion elelgida por el usuario.
            DialogResult seleccionDelUsuario;
            //ase un mensege de texto que muestra una ventana con un texto definido.
            seleccionDelUsuario = MessageBox.Show("¿Deseas salir de la aplicación?", "Login TAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Es un if que si cumple se ejecuta, en este caso si es "Yes" el valor se ejecuta.
            if (seleccionDelUsuario == DialogResult.Yes)
            {
                //Cierra todo
                Application.Exit();
            }
            //Es un if que si cumple se ejecuta, en este caso si es "No" el valor se ejecuta.
            if (seleccionDelUsuario == DialogResult.No)
            {
                //retorna
                return;
            }
        }

        //Método que hace una interfaz grafica de usuario con un evento de activacion en el formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Oculta el control "txtInvitado" del usuario.
            txtInvitado.Hide();
        }
        //Método que hace una control de un boton con un evento click.
        private void btnAceptar_Click(object sender, EventArgs e)
        {//Validar al usuario que ingresa al sistema
            //Tipos de usuario: Empleado | Alumno | Usuario invitado
            //Para validar Empleado | Alumno necesito cohnsultar el duccionario
            //COntainsKey => el key del diccionario si existe
            string msg = string.Empty;
            string usuario = string.Empty;
            if (alumnos.ContainsKey(txtUsuario.Text) || empleados.ContainsKey(txtUsuario.Text))
            {

                if (alumnos.ContainsKey(txtUsuario.Text))
                {
                    msg = string.Format("Bienvenido a PIDETEC estimado alumno: {0}, espero tu visita sea placentera.", alumnos[txtUsuario.Text].ToString());
                    usuario = alumnos[txtUsuario.Text].ToString();
                }
                if (empleados.ContainsKey(txtUsuario.Text))
                {
                    msg = string.Format("Bienvenido a PIDETEC {0}", empleados[txtUsuario.Text].ToString());
                    usuario = empleados[txtUsuario.Text].ToString();
                }
                MessageBox.Show(msg);
                //Cambiar de Form
                //Instanciar frmMenu.cs
                PIDETEC menu = new PIDETEC();
                this.Hide();

                DialogResult dialogResult = menu.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    this.Show();
                }
                //Es un if que si cumple se ejecuta, en este caso si el valor
                if (chbInvitado.Checked == true)
                {
                    //una variable que guarda un texto.
                    msg = string.Format("Bienvenidos a PIDETEC{0}", "esperamos atenderte lo mejor posible", (txtInvitado.Text).ToString());
                    //Es una varieble que guarda lo que tiene el textbox.
                    usuario = (txtInvitado.Text);
                    PIDETEC cambiar = new PIDETEC();
                    //Muestra el control "cambiar" del usuario.
                    cambiar.Show();
                    //Esconde el formulario.
                    this.Hide();
                }
            }
        }
        ////Método que hace una control de un checkBox con un evento CheckedChanged.
        private void chbInvitado_CheckedChanged(object sender, EventArgs e)
        {
            //Es un if que si cumple se ejecuta, en este caso si el valor de chbInvitado.Checked es "true".
            if (chbInvitado.Checked == true)
            {
                //Al cumplir el DialogResult muestra un mensaje de texto.
                DialogResult res = MessageBox.Show("¿Estás seguro que quieres ingresar como invitado?", "Ingresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Es un if que si cumple se ejecuta, en este caso si el valor de res es "Yes".
                if (res == DialogResult.Yes )
                {
                    //Muestra el el control "txtInvitado" al usuario.
                    txtInvitado.Show();
                    //Establece un foco de entrada en txtInvitado.
                    txtInvitado.Focus();
                    //Pone un texto 
                    //txtInvitado.Text = "Ingresa tu nombre de invitado (MAYÚSCULAS)";
                    //Cambia el color de las letras a gris.
                    txtInvitado.ForeColor = Color.Gray;
                    //Oculta el el control "txtInvitado" al usuario.
                    txtUsuario.Hide();
                }
                //Es un if que si cumple se ejecuta, en este caso si el valor de res es "NO".
                if (res == DialogResult.No)
                {
                    //retorna
                    return;
                }
            }
        }
        //Método que hace una control de una caja de texto con un evento de KeyPress.
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Es un if donde se crea una condicion para que solo pueda entrar numero.
            if (e.KeyChar >= 00 && e.KeyChar <= 47 && e.KeyChar !=27 && e.KeyChar !=08 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                //Hace que los caracteres del if no sean aceptados.
                e.Handled = true;
                //retorna
                return;
            }
        }
        //Método que hace una control de una caja de texto con un evento de KeyPress.
        private void txtInvitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Es un if donde se crea una condicion para que solo pueda entrar letras mayúsculas.
            if (e.KeyChar >= 00 && e.KeyChar <= 64 && e.KeyChar != 27 && e.KeyChar != 08 || e.KeyChar >= 91 && e.KeyChar <= 255)
            {
                //Hace que los caracteres del if no sean aceptados.
                e.Handled = true;
                //retorna
                return;
            }
        }
        //Método que hace una control de una caja de texto con un evento click.
        private void txtInvitado_Click(object sender, EventArgs e)
        {
            //Borra el contenido de la caja de usuario.
            txtInvitado.Text = string.Empty;
        }
        //Método que hace una control de una caja de texto con un evento de TextChanged.
        private void txtInvitado_TextChanged(object sender, EventArgs e)
        {
            //Cambia el color de las letras de la caja de texto.
            txtInvitado.ForeColor = Color.Black;
        }
    }
}
