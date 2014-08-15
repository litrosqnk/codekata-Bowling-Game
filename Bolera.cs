using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntuacionBolos
{
    public class Bolera
    {
        private int[] arrayTiradas;
        private int ind;

        public Bolera(){
            arrayTiradas = new int[22];
            ind = 0;
        }
        public int puntuacion()
        {
            int puntuacion = 0;
            int posic = 0;
            //recorro el array con las puntuaciones guardadas para sumarlos y buscar strike o spare
            for ( posic = 0; posic < 20; posic++)
            {
                
                //Console.ReadLine();
                if (arrayTiradas[posic] == 10) //STRIKE!
                {
                    if (posic < 18)
                    {
                        if (arrayTiradas[posic + 2] == 10)
                        {
                            puntuacion += arrayTiradas[posic] + arrayTiradas[posic + 2] + arrayTiradas[posic + 4];
                        }
                        else
                        {
                            puntuacion += arrayTiradas[posic] + arrayTiradas[posic + 2] + arrayTiradas[posic + 3];
                        }
                    }
                    else
                    {
                        puntuacion += arrayTiradas[posic] + arrayTiradas[posic + 2] + arrayTiradas[posic + 3];
                    }

                }
                else if ((arrayTiradas[posic] + arrayTiradas[posic + 1] )== 10)
                    {
                        puntuacion += (arrayTiradas[posic] + arrayTiradas[posic + 1]) + arrayTiradas[posic + 2];
                }
                    else
                    {
                        puntuacion += (arrayTiradas[posic] + arrayTiradas[posic + 1]);
                    }
               posic++;
                
            }

                return puntuacion;
        }
        public void guardarTiradas(int posicion)
        {
            arrayTiradas[ind] = posicion;
            ind++;
        }
    }
}
