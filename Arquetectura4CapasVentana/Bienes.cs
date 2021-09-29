using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;

namespace Arquetectura4CapasVentana
{
    public partial class Bienes : Form
    {
        private BienesBBL bienServicio;
        private Home home;
        private string usuario;

        //Constructor
        public Bienes(string id, string usuario, Home presentacion)
        {
            home = presentacion;
            this.usuario = usuario;
            bienServicio = new BienesBBL();
            InitializeComponent();
            bien_caja_jugador.Enabled = false; //Para no modificar
            comboBox1.DataSource = Enum.GetValues(typeof(TipoBienesEnum));//Carga el Combo con los enumeradores
            this.bien_caja_jugador.Text = id;
            int idJugador = Convert.ToInt32(bien_caja_jugador.Text);
            dataGridViewBienes.DataSource = bienServicio.ListarBienesDeJugador(idJugador);
        }


        private void Bienes_Load(object sender, EventArgs e)
        {
            //No funciona, rarísimo
            //comboBox1.DataSource = Enum.GetValues(typeof(TipoBienesEnum));
        }

        //Botón Ingresar Bien
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TipoBienesEnum tipoSeleccionado = (TipoBienesEnum)comboBox1.SelectedValue;
                string nombre = bien_caja_nombre.Text;
                int idJugador = Convert.ToInt32(bien_caja_jugador.Text);                
                decimal precio = Convert.ToDecimal(bien_caja_precio.Text);
                string fecha = DateTime.Now.ToString();
                
                Bien bien = new Bien(tipoSeleccionado, idJugador, nombre, precio, fecha);
                string respuesta = bienServicio.AltaBien(bien);
                dataGridViewBienes.DataSource = null;
                dataGridViewBienes.DataSource = bienServicio.ListarBienesDeJugador(idJugador);
                this.home.ActualizarGrilla(Convert.ToInt32(this.usuario));
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ingrese todos los campos. " + ex.Message);
            }
        }

        //Volver atrás
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón Borrar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridViewBienes.SelectedCells[0].RowIndex;
                string id = dataGridViewBienes.Rows[i].Cells[0].Value.ToString();
                string idJugador = dataGridViewBienes.Rows[i].Cells[2].Value.ToString();
                bienServicio.Baja(id, idJugador, usuario);
                dataGridViewBienes.DataSource = null;
                dataGridViewBienes.DataSource = bienServicio.ListarBienesDeJugador(Convert.ToInt32(idJugador));
                this.home.ActualizarGrilla(Convert.ToInt32(this.usuario));
            }

            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un jugador para eliminar. " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Print Jugador
        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void bien_caja_jugador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
