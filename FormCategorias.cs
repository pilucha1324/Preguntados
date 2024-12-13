using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP_FINAL_PREGUNTDOS
{
    public partial class FormCategorias : Form
    {
        string nickName;
        int puntosTotales;
        private string ArchivoRanking = "ranking.txt";

        public FormCategorias(string nickName)
        {
            InitializeComponent();
            CrearArchivo(ArchivoRanking);
            this.nickName = nickName;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //TRUCAZO
        #region categorias 
        public enum Categorias
        {
            arte = 1,
            ciencia = 2,
            cine = 3,
            random = 4
        }

        private List<string> ElegirCategoria(Categorias idCategoria)
        {
            List<string> preguntas = CargarCategorias();
            return preguntas.Where((pregunta) => pregunta.Contains(idCategoria.ToString())).ToList();
        }
        private List<string> CargarCategorias()
        {
            string rutaArchivo = "preguntas.txt";
            return File.ReadAllLines(rutaArchivo).ToList();
        }

        private void btnArte_Click(object sender, EventArgs e)
        {
            List<string> ListaPreguntas = ElegirCategoria(Categorias.arte);
            FormPreguntas Preguntas = new FormPreguntas(Categorias.arte.ToString(), ListaPreguntas, this,  nickName, puntosTotales);
            this.Hide();
            Preguntas.Show();
        }

        private void btnCiencia_Click(object sender, EventArgs e)
        {
            List<string> ListaPreguntas = ElegirCategoria(Categorias.ciencia);
            FormPreguntas Preguntas = new FormPreguntas(Categorias.ciencia.ToString(), ListaPreguntas, this, nickName, puntosTotales);
            this.Hide();
            Preguntas.Show();
        }

        private void btnCine_Click(object sender, EventArgs e)
        {
            List<string> ListaPreguntas = ElegirCategoria(Categorias.cine);
            FormPreguntas Preguntas = new FormPreguntas(Categorias.cine.ToString(), ListaPreguntas, this, nickName, puntosTotales);
            this.Hide();
            Preguntas.Show();
        }

        
        #endregion
        private void btnProvisorio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region ranking
        private void CrearArchivo(string RutaArchivo)
        {
            try
            {
                if (!VerificarArchivo(RutaArchivo))
                {

                    File.CreateText(RutaArchivo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool VerificarArchivo(string RutaArchivo)
        {
            return File.Exists(RutaArchivo);
        }
        private void GuardarUsuarios(string RutaArchivo, string usuarios)
        {
            File.AppendAllText(RutaArchivo, usuarios); //appenedalltext meto ruta y los datos q quiero guardar

        }
        #endregion
        private int CargarPuntos(FormPreguntas formPreguntas)
        {
            if (formPreguntas != null)  // Verifica si formPreguntas no es null
            {
                puntosTotales = formPreguntas.puntos;  // Ahora es seguro acceder a formPreguntas.puntos
            }
            else
            {
                MessageBox.Show("El formulario de preguntas no ha sido inicializado.");
            }
            return puntosTotales;
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            
            FormRanking formRanking = new FormRanking();
            formRanking.Show();   
        }
        public void ObtenerPuntos(int puntos)
        {
            puntosTotales = puntos;
        }
    }
}
