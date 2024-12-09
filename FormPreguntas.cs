using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace TP_FINAL_PREGUNTDOS
{
    public partial class FormPreguntas : Form
    {
        List<string> CategoriaElegida;
        string RespuestaCorrecta = "";
        public FormPreguntas(string tituloCategoria, List<string> categoriaElegida)
        {
            InitializeComponent();
            lblCategoria.Text = tituloCategoria;
            CategoriaElegida = categoriaElegida;
            CargarPregunta();
        }

        private string ElegirPregunta()
        {
            Random rnd = new Random();
            int limite = CategoriaElegida.Count;
            int numeroAleatorio = rnd.Next(0, limite);
            return CategoriaElegida[numeroAleatorio];
        }

        private void CargarPregunta()
        {
            string preguntaRandom = ElegirPregunta();
            string[] PreguntaSeparada = preguntaRandom.Split(';');
            lblPregunta.Text = PreguntaSeparada[1];
            btnA.Text = PreguntaSeparada[2];
            btnB.Text = PreguntaSeparada[3];
            btnC.Text = PreguntaSeparada[4];
            RespuestaCorrecta = PreguntaSeparada[5];
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            string A = "A";
            if(RespuestaCorrecta == A)
            {
                btnA.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA.BackColor= Color.IndianRed;
            }
            CambiarPregunta();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            string B = "B";
            if(RespuestaCorrecta == B)
            {
                btnB.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB.BackColor= Color.IndianRed;
            }
            CambiarPregunta();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string C = "C";
            if (RespuestaCorrecta == C) 
            {
                btnC.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC.BackColor= Color.IndianRed;
            }
            CambiarPregunta();
        }
        private void CambiarPregunta() //CHEQUEAR!!!
        {
            System.Timers.Timer timer = new System.Timers.Timer(2000);
            timer.Elapsed += (sender, e) =>
            {
                ElegirPregunta();
                timer.Stop();
            };
            timer.AutoReset = false;
            timer.Start();
        }
    }
}
