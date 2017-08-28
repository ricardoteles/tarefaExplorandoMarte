using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioCappta {
    public class Sonda {
        public int posX    { get; private set; }
        public int posY    { get; private set; }
        public char direcao     { get; private set; }
        public String sequencia { get; private set; }

        public Sonda(int posX, int posY, char direcao, String sequencia) {
            this.posX = posX;
            this.posY = posY;
            this.direcao = direcao;
            this.sequencia = sequencia;
        }

        private void moverParaFrente(int posX, int posY, char direcao) {           
            if(direcao.Equals('N') && Mapa.estaNoLimiteDoMapa(posX, posY+1))
                this.posY += 1;
            else if (direcao.Equals('S') && Mapa.estaNoLimiteDoMapa(posX, posY-1))
                this.posY -= 1;
            else if (direcao.Equals('E') && Mapa.estaNoLimiteDoMapa(posX+1, posY))
                this.posX += 1;
            else if (direcao.Equals('W') && Mapa.estaNoLimiteDoMapa(posX-1, posY))
                this.posX -= 1;

        }

        private void virar90GrausEsquerda(char direcao) {
            switch (direcao) {
                case 'N': this.direcao = 'W';
                    break;

                case 'S': this.direcao = 'E';
                    break;

                case 'E': this.direcao = 'N';
                    break;

                case 'W': this.direcao = 'S';
                    break;

            }
        }

        private void virar90GrausDireita(char direcao) {
            switch (direcao) {
                case 'N': this.direcao = 'E';
                    break;

                case 'S': this.direcao = 'W';
                    break;

                case 'E': this.direcao = 'S';
                    break;

                case 'W': this.direcao = 'N';
                    break;
            }
        }

        public String executaSequenciaMovimentos(String sequencia) {
            for (int i = 0; i < sequencia.Length; i++) {
                if (sequencia[i].Equals('M'))
                    moverParaFrente(this.posX, this.posY, this.direcao);
                else if (sequencia[i].Equals('L'))
                    virar90GrausEsquerda(this.direcao);
                else if (sequencia[i].Equals('R'))
                    virar90GrausDireita(this.direcao);
            }

            return this.posX + " " + this.posY + " " + this.direcao;
        }
    }
}
