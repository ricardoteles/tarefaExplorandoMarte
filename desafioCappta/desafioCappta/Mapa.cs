using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioCappta {
    public static class Mapa {
        public static int largura;
        public static int altura;

        public static bool estaNoLimiteDoMapa(int posX, int posY) {
            return ((posX >= 0 && posX <= largura) && (posY >= 0 && posY <= altura));
        }
    }
}
