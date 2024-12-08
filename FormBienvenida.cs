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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNickname formNickname = new FormNickname(this);
            this.Hide();
            formNickname.Show();
        }
    }
}
