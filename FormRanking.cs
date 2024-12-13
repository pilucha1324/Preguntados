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
    public partial class FormRanking : Form
    {
        private List<string> ranking;
        private string ArchivoRanking = "ranking.txt";
        public FormRanking()
        {
            InitializeComponent();
            ranking = CargarRanking();
            listBox1.DataSource = OrdenarRanking();
        }
        private List<string> CargarRanking()
        {   
            return File.Exists(ArchivoRanking) ? File.ReadAllLines(ArchivoRanking).ToList():new List<string>(); //ternario(if en una sola linea)
        }
        private List<string> OrdenarRanking()
        {
            var ListaOrdenada = this.ranking.OrderByDescending(L => int.Parse(L.Split(';')[1]));
            return ListaOrdenada.ToList();
        }
    }
}
