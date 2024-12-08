using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL_PREGUNTDOS
{
    public partial class FormNickname : Form
    {
        private FormBienvenida formularioBienvenida;
        public FormNickname(FormBienvenida formularioBienvenida)
        {
            InitializeComponent();
            this.formularioBienvenida = formularioBienvenida;
        }

        private void FormNickname_Load(object sender, EventArgs e)
        {

        }

        private void btnNickname_Click(object sender, EventArgs e)
        {
            FormCategorias formElegirCategoria = new FormCategorias(this);
            this.Close();
            formElegirCategoria.Show();
        }
    }
}
