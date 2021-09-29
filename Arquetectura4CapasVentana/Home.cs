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
    public partial class Home : Form
    {
        //Instacio de la Capa de Datos
        private JugadorBBL jServicio = new JugadorBBL();
        private UsuarioBBL uServicio = new UsuarioBBL();
        private BitacoraBBL bServicio = new BitacoraBBL();
        Usuario u1;
        
        public Home()
        {
         
        }
        //Constructor para el loging. Viene después del Login.
        public Home(string texto, Usuario usuario)
        {
            InitializeComponent();
            label5.Text = "El Usuario es:  " + texto;
            u1 = usuario;
            try
            {
                //Traer registro del Login
                dataGridViewJugadores.DataSource = null;
                Usuario usuarioValidado = uServicio.GetUsuario(u1.Codigo); //Traer el registro del Login
                if (usuarioValidado != null)
                {
                    ActualizarGrilla(u1.Codigo);
                }
                else
                {
                    MessageBox.Show("El Registro no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Registro no existe. " + ex.Message);
            }

        }
        //Tablero de Jugadores
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridView fila in dataGridViewJugadores.Rows)
            {
                fila.ReadOnly = true;//Solo vista
            }
            
        }
        //-----------------------------Botón Nuevo Jugador--------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = u1.Codigo;//Pasar el usuario ingresado en login
                string nombre = caja_nombre.Text;
                string apellido = caja_apellido.Text;
                double fuerza = Convert.ToDouble(caja_fuerza.Text);
                double angulo = Convert.ToDouble(caja_angulo.Text);

                Jugador jugador = new Jugador(id, nombre, apellido,fuerza, angulo);
                //Llamo a Capa de Negocio
                string respuesta = jServicio.AltaJugador(jugador);
                //MessageBox.Show(respuesta);
                MessageBox.Show("Se ingresó el Jugador: " + nombre + " " + apellido );

                bServicio.Post(id, "Alta de Jugador", TipoConsultaEnum.Alta);
                dataGridViewJugadores.DataSource = null;
                dataGridViewJugadores.DataSource = jServicio.TraerlistaJugadores(id); //id
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("pepe" +  ex.Message);
            }
        }

        //------------------------------Botón Borrar Jugador------------------------------------//
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int buscar = dataGridViewJugadores.SelectedCells[0].RowIndex;
                string id = dataGridViewJugadores.Rows[buscar].Cells[0].Value.ToString();
                string registro = dataGridViewJugadores.Rows[buscar].Cells[1].Value.ToString();
                jServicio.BajaJugador(id, registro);
                bServicio.Post(Convert.ToInt32(registro), "Baja", TipoConsultaEnum.Baja);
                dataGridViewJugadores.DataSource = null;
                dataGridViewJugadores.DataSource = jServicio.TraerlistaJugadores(Convert.ToInt32(registro));
                MessageBox.Show("Se eliminó el jugador");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un jugador para eliminarlo" + ex.Message);
            }
        }

        //----------------------------------Actualizar Tabla-------------------------------------//
        internal void ActualizarGrilla(int registroValidado)
        {
            dataGridViewJugadores.DataSource = null;
            //dataGridViewJugadores.DataSource = jServicio.TraerlistaJugadores(registroValidado);
            dataGridViewJugadores.DataSource = jServicio.TraerlistaJugadores(registroValidado);
        }
        //Botón Bienes
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridViewJugadores.SelectedCells[0].RowIndex;
                string id = dataGridViewJugadores.Rows[i].Cells[0].Value.ToString();
                Bienes bienes = new Bienes(id, u1.Codigo.ToString(), this); 
                bienes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valide y luego seleccione un jugador para ver sus bienes. " + ex.Message);
            }

        }
        //-----------------------CAJAS Y TEXTO---------------------------------------------------//


        //Caja Nombre
        private void tx_nombre_TextChanged(object sender, EventArgs e)
        {

        }
        //Caja Jugadores
        private void lb_jugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Caja Apellido
        private void tx_apellido_TextChanged(object sender, EventArgs e)
        {

        }
        //Caja Fuerza
        private void tx_fuerza_TextChanged(object sender, EventArgs e)
        {

        }
        //Caja Angulo
        private void caja_angulo_TextChanged(object sender, EventArgs e)
        {

        }
        //Botón Atrás
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        // Texto Ingresar Jugador
        private void Lb_AltaJugador_Click(object sender, EventArgs e)
        {

        }
        //Texto Jugadores Ingresados
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Lb_CodigoJugador_Click(object sender, EventArgs e)
        {
        }

    }
}
