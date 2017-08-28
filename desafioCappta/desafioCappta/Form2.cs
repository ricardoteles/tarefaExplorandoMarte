using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioCappta
{
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void bntOk_Click(object sender, EventArgs e) {
            String textoPosIni = txtPosIni.Text;
            String sequencia = txtSeqMov.Text;
            int posX = (int)Char.GetNumericValue(textoPosIni[0]);
            int posY = (int)Char.GetNumericValue(textoPosIni[2]);
            char direcao = textoPosIni[4];

            Sonda s1 = new Sonda(posX, posY, direcao, sequencia);
            MessageBox.Show("A posição final da sonda é:  " + s1.executaSequenciaMovimentos(sequencia));
        }

        private void button1_Click(object sender, EventArgs e) {
            txtPosIni.Text = "";
            txtSeqMov.Text = "";
        }
    }
}
