using System;
using PuntuacionBolos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bowlingTest
{
    [TestClass]
    public class BolosAccountTest
    {
        [TestMethod]
        public void TestStrikes()
        {
            Bolera bolo = new Bolera();
            for (int i = 0; i < 10; i++)
            {
                bolo.guardarTiradas(10);
                bolo.guardarTiradas(0);
            }
            bolo.guardarTiradas(10);
            bolo.guardarTiradas(10);

            int punt = bolo.puntuacion();
            Assert.AreEqual(300, punt);
        }

        [TestMethod]
        public void TestSpares()
        {
            Bolera bolo = new Bolera();
            for (int i = 0; i < 21; i++)
            {
                bolo.guardarTiradas(5);
            }
            int punt = bolo.puntuacion();
            Assert.AreEqual(150, punt);
        }


        [TestMethod]
        public void Test() // el de la web
        {
            Bolera bolo = new Bolera();

            bolo.guardarTiradas(1);
            bolo.guardarTiradas(4);

            bolo.guardarTiradas(4);
            bolo.guardarTiradas(5);

            bolo.guardarTiradas(6);
            bolo.guardarTiradas(4);

            bolo.guardarTiradas(5);
            bolo.guardarTiradas(5);

            bolo.guardarTiradas(10);
            bolo.guardarTiradas(0);

            bolo.guardarTiradas(0);
            bolo.guardarTiradas(1);

            bolo.guardarTiradas(7);
            bolo.guardarTiradas(3);

            bolo.guardarTiradas(6);
            bolo.guardarTiradas(4);

            bolo.guardarTiradas(10);
            bolo.guardarTiradas(0);

            bolo.guardarTiradas(2);
            bolo.guardarTiradas(8);
            // el tiro extra
            bolo.guardarTiradas(6);

            int punt = bolo.puntuacion();
            Assert.AreEqual(133, punt);
        }

        [TestMethod]
        public void TestUnos() // AQUI NO HAY NINGUN TIRO EXTRA NI PUNTUACIONES DOBLES
        {
            Bolera bolo = new Bolera();
            for (int i = 1; i <= 20; i++)
            {
                bolo.guardarTiradas(1);
            }
            Assert.AreEqual(20, bolo.puntuacion());
        }

    }
}
