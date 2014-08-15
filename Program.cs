using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntuacionBolos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] nombre = new string[6];
            Bolera Bol = new Bolera();
            bool extra = false;
            int puntuacion = 0;
            int num = 1; //numero de jugadores
            //int ronda = 1; // este no vale demomento = i del for
            int tirada = 0, tirada2 = 0, tirada3 = 0;
            Console.WriteLine(" ###########################################################");
            Console.WriteLine(" ####                CODEKATA BOWLING GAME              ####");
            Console.WriteLine(" ####                                                   ####");
            Console.WriteLine(" ####   Anota tus puntaciones en el juego de los bolos  ####");
            Console.WriteLine(" ###########################################################");

            Console.Write("Presione ENTER para comenzar ");
            Console.ReadLine(); // A LA ESPERA PARA SALIR
            Console.Clear();


            for (int i = 1; i <= 10; i++)   // CAMBIAR EL 2 POR 10 DESPUES DE LAS PRUEBAS INICIALES 
            {
                Console.WriteLine("\nRonda: {0}", i);
                Console.Write("Lanzamiento 1:");
                tirada = Convert.ToInt32(Console.ReadLine());
                if (i < 10) // NO ES LA ULTIMA RONDA    // CAMBIAR EL 2 POR 10 DESPUES DE LAS PRUEBAS INICIALES
                {
                    while (tirada > 10)
                    {
                        Console.WriteLine("Puntuacion no valida, el valor maximo es 10");
                        Console.Write("Lanzamiento 1:");
                        tirada = Convert.ToInt32(Console.ReadLine());
                    }
                    if (tirada == 10) // STRIKE!
                    {
                        Console.WriteLine("\n  STRIKE\n");
                        Bol.guardarTiradas(tirada);
                        Bol.guardarTiradas(0);
                    }
                    else
                    {
                        Console.Write("Lanzamiento 2:");
                        tirada2 = Convert.ToInt32(Console.ReadLine());
                        while (tirada + tirada2 > 10)
                        {
                            Console.WriteLine("Puntuacion no valida, la suma de las dos tiradas no puede superar 10");
                            Console.Write("Lanzamiento 2:");
                            tirada2 = Convert.ToInt32(Console.ReadLine());
                        }
                        if (tirada2 + tirada == 10) //SPARE
                        {
                            Console.WriteLine("\n  SPARE\n");
                            // GUARDO LAS PUNTUACIONES
                        }
                        Bol.guardarTiradas(tirada);
                        Bol.guardarTiradas(tirada2);
                        //break

                    }
                }
                else // ULTIMA RONDA 
                {
                    if (tirada == 10) // STRIKE! 
                    {
                        Console.WriteLine("  STRIKE - 2 BOLAS EXTRA\n");
                        extra = true;
                        Bol.guardarTiradas(tirada);
                        Bol.guardarTiradas(0);
                    }

                    Console.Write("Lanzamiento 2:");
                    tirada2 = Convert.ToInt32(Console.ReadLine());
                    while (tirada + tirada2 > 10 && tirada <10)
                        {
                            Console.WriteLine("Puntuacion no valida, la suma de las dos tiradas no puede superar 10");
                            Console.Write("Lanzamiento 2:");
                            tirada2 = Convert.ToInt32(Console.ReadLine());
                        }
                    if (tirada2 + tirada == 10) //SPARE
                    {
                        Console.WriteLine("  SPARE - 1 BOLA EXTRA\n");
                        // GUARDO LAS PUNTUACIONES
                        extra = true;
                    }
                    if (tirada < 10)
                    {
                        Bol.guardarTiradas(tirada);
                    }
                    Bol.guardarTiradas(tirada2);

                    if (extra)
                    {
                        Console.Write("Lanzamiento 3:");
                        tirada3 = Convert.ToInt32(Console.ReadLine());
                        Bol.guardarTiradas(tirada3);
                    }
                    
                    
 
                }
                                
                Console.Write("\tPuntuacion: {0}\n", Bol.puntuacion());
            }// fin for


            Console.Write("Presione ENTER para salir ");
            Console.ReadLine(); // A LA ESPERA PARA SALIR
        }

    }
}
