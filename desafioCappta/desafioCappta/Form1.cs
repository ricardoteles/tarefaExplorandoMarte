using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioCappta {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String tamMapa = txtTamMapa.Text;
            int largura = (int)Char.GetNumericValue(tamMapa[0]);
            int altura = (int)Char.GetNumericValue(tamMapa[2]);

            Mapa.largura = largura;
            Mapa.altura = altura;

            this.Hide();

            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Close();
        }
    }
}
