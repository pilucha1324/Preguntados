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
    public partial class FormCategorias: Form
    {
        private FormNickname formNickname;
        public FormCategorias(FormNickname formNickname)
        {
            InitializeComponent();
            this.formNickname = formNickname;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public enum Categorias
        {
            arte=1,
            ciencia=2,
            cine=3,
            random=4
        }
        private List<string> ElegirCategoria(Categorias idCategoria)
        {
            List<string> preguntas = CargarCategorias();
            return preguntas.Where((pregunta)=>pregunta.Contains(idCategoria.ToString())).ToList();
        }
        private List<string> CargarCategorias()
        {
            string rutaArchivo = "preguntas.txt";
            return File.ReadAllLines(rutaArchivo).ToList();
        }
    
        private void btnArte_Click(object sender, EventArgs e)
        {
            ElegirCategoria(Categorias.arte);
        }

        private void btnCiencia_Click(object sender, EventArgs e)
        {
            ElegirCategoria(Categorias.ciencia);
        }

        private void btnCine_Click(object sender, EventArgs e)
        {
            ElegirCategoria(Categorias.cine);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ElegirCategoria(Categorias.random);
        }

        private void btnProvisorio_Click(object sender, EventArgs e)
        {
            FormBienvenida formBienvenida = new FormBienvenida();
            this.Hide();
            formBienvenida.Show();
        }
    }
}
