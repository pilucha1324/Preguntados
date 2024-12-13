using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace TP_FINAL_PREGUNTDOS
{
    public partial class FormPreguntas : Form
    {
        List<string> CategoriaElegida;
        FormCategorias FormCategorias;
        string nickName;
        private string ArchivoRanking = "ranking.txt";
        string RespuestaCorrecta = "";
        int vidas = 3;
        int nivel = 1;
        int totalNiveles = 5;
        public int puntos = 0;
        public FormPreguntas(string tituloCategoria, List<string> categoriaElegida, FormCategorias formCategorias, string nickName, int puntos)
        {
            InitializeComponent();
            lblCategoria.Text = tituloCategoria;
            CategoriaElegida = categoriaElegida;
            FormCategorias = formCategorias;
            CargarPregunta();
            this.nickName = nickName;
            this.puntos = puntos;
            
            
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
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            string A = "A";
            if(RespuestaCorrecta == A)
            {
                btnA.BackColor = Color.PaleGreen;
                puntos += 10;
                PuntosExtra();
                FormCategorias.ObtenerPuntos(puntos);
            }
            else
            {
                btnA.BackColor= Color.IndianRed;
                PerderVida();
            }
            CambiarPregunta();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            string B = "B";
            if(RespuestaCorrecta == B)
            {
                btnB.BackColor = Color.PaleGreen;
                puntos += 10;
                PuntosExtra();
                FormCategorias.ObtenerPuntos(puntos);
            }
            else
            {
                btnB.BackColor= Color.IndianRed;
                PerderVida();
            }
            CambiarPregunta();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string C = "C";
            if (RespuestaCorrecta == C) 
            {
                btnC.BackColor = Color.PaleGreen;
                puntos += 10;
                PuntosExtra();
                FormCategorias.ObtenerPuntos(puntos);
            }
            else
            {
                btnC.BackColor= Color.IndianRed;
                PerderVida();
            }
            CambiarPregunta();
        }

        private void CambiarPregunta()
        {
            System.Timers.Timer timer = new System.Timers.Timer(500);
            timer.Elapsed += (sender, e) =>
            {
                if (lblPregunta.InvokeRequired || lblLevel.InvokeRequired)
                {
                    lblLevel.Invoke(new Action(() =>
                    {
                        SubirNivel();
                    }));
                    if (nivel <= totalNiveles) 
                    {
                        lblPregunta.Invoke(new Action(() =>
                        {
                            CargarPregunta();
                        }));
                    }
                }   
                else
                {
                    CargarPregunta();
                }
                timer.Stop();
            };
            timer.AutoReset = false;
            timer.Start();
        }

        private void PerderVida()
        {
            vidas -= 1;
            lblVida.Text = string.Concat(Enumerable.Repeat("❤️", vidas));
            if(vidas == 0)
            {
                MessageBox.Show("¡Ups! Te quedaste sin vidas");
                //despues abrir el formulario del ranking, mostrando el puesto guardado
                string usuario = $"{nickName};{puntos}\n";
                GuardarUsuarios(ArchivoRanking, usuario);
                FormRanking ranking = new FormRanking();
                ranking.Show();
                this.Close();
            }
        }

        private void SubirNivel()
        {
            nivel++;
            if(nivel > totalNiveles)
            {
                this.FormCategorias.Show();
                this.Close();
            }
            lblLevel.Text = $"{nivel}/{totalNiveles}";
        }

        public void PuntosExtra()
        {
            if(nivel == 5 && vidas == 3)
            {
                puntos += 15;
            }
            else if(nivel == 5 && vidas == 2)
            {
                puntos += 10;
            }
            else if (nivel == 5 && vidas == 1)
            {
                puntos += 3;
            }
            FormCategorias.ObtenerPuntos(puntos);
        }
        private void GuardarUsuarios(string RutaArchivo, string usuarios)
        {
            File.AppendAllText(RutaArchivo, usuarios); //appenedalltext meto ruta y los datos q quiero guardar

        }
    }

}
