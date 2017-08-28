using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using desafioCappta;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaEntradaEnunciado()
        {
            desafioCappta.Mapa.largura = 5;
            desafioCappta.Mapa.altura = 5;
            desafioCappta.Sonda s1 = new Sonda(1, 2, 'N', "LMLMLMLMM");
            desafioCappta.Sonda s2 = new Sonda(3, 3, 'E', "MMRMMRMRRM");

            Assert.AreEqual("1 3 N", s1.executaSequenciaMovimentos("LMLMLMLMM"));
            Assert.AreEqual("5 1 E", s2.executaSequenciaMovimentos("MMRMMRMRRM"));
        }

        [TestMethod]
        public void TestaLimiteMapa()
        {
            desafioCappta.Mapa.largura = 5;
            desafioCappta.Mapa.altura = 5;
            desafioCappta.Sonda s1 = new Sonda(1, 2, 'N', "MMMM");
            desafioCappta.Sonda s2 = new Sonda(1, 2, 'N', "MMMM");

            Assert.AreEqual("1 5 N", s1.executaSequenciaMovimentos("MMMM"));
            Assert.AreEqual("1 5 S", s2.executaSequenciaMovimentos("MMMMMMMLL"));
        }

        [TestMethod]
        public void TestaGirarNoLugar()
        {
            desafioCappta.Mapa.largura = 5;
            desafioCappta.Mapa.altura = 5;
            desafioCappta.Sonda s1 = new Sonda(1, 2, 'N', "RRRR");

            Assert.AreEqual("1 2 N", s1.executaSequenciaMovimentos("RRRR"));
        }

        [TestMethod]
        public void TestaMapaUnitario()
        {
            desafioCappta.Mapa.largura = 0;
            desafioCappta.Mapa.altura = 0;
            desafioCappta.Sonda s1 = new Sonda(0, 0, 'N', "M");
            desafioCappta.Sonda s2 = new Sonda(0, 0, 'W', "M");
            desafioCappta.Sonda s3 = new Sonda(0, 0, 'E', "M");
            desafioCappta.Sonda s4 = new Sonda(0, 0, 'S', "M");

            Assert.AreEqual("0 0 N", s1.executaSequenciaMovimentos("M"));
            Assert.AreEqual("0 0 W", s2.executaSequenciaMovimentos("M"));
            Assert.AreEqual("0 0 E", s3.executaSequenciaMovimentos("M"));
            Assert.AreEqual("0 0 S", s4.executaSequenciaMovimentos("M"));
        }

    }
}
