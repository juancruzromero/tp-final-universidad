using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arquetectura4CapasVentana;
using CapaEntidades;
using CapaNegocios;

namespace Arquetectura4CapasVentana
{
    public partial class Login : Form
    {
        Usuario usuario1 = new Usuario();
        UsuarioBBL servicio = new UsuarioBBL();
        JugadorBBL jugador = new JugadorBBL();
        BitacoraBBL bitacora = new BitacoraBBL();


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        //Botón Ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoRegistro = Convert.ToInt32(caja_registro.Text);                
                usuario1 = servicio.GetUsuario(codigoRegistro);

                //Validación Contraseña
                if (caja_contrasena.Text == "")
                {
                    MessageBox.Show("Ingrese su contraseña");
                }
                else if (caja_contrasena.Text == "cai2019")
                {
                    List<Jugador> lista = jugador.TraerJugadores(usuario1.Codigo);
                    MessageBox.Show(usuario1.ToString() + lista.Count());
                    //Es lo mejor que pude hacer Silvio! :(
                    string nombreusuario = usuario1.Nombre;
                    Home main = new Home(nombreusuario, usuario1);//Sigo en Home
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un Numero");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Usuario no encontrado");
            }
            catch (OverflowException)
            {
                //Bitácora faltante
                Bitacora login = new Bitacora(usuario1.Codigo, "Se superó el rango ingresado", TipoConsultaEnum.Error);
                MessageBox.Show( "Superaste el rango");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a produciod un error"+ ex);
            }
        }

        //Caja para ingresar Registro
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        //Boton Salir
        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Frase Ingrese Registro
        private void label1_Click(object sender, EventArgs e)
        {
        }

        //Texto "Contraseña"
        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        //Caja ingresar Contraseña
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
