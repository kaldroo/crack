using System;

namespace ejm
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 1;
            int NumeroAlea;
            int contador = 0;
            int MenuNo;
            Random Azar = new Random();
            int[] NumeroR = new int[10];
            NumeroAlea = Azar.Next(0, 100);
            Console.WriteLine(NumeroAlea);
            Console.WriteLine("Rifa\n" +
           "1.Jugar una personas \n" +
            "2 jugar varias personas");
            MenuNo = Convert.ToInt32(Console.ReadLine());
            switch (MenuNo)
            {
                case 1:
                    for (int i = 0; i < NumeroR.Length; i++)
                    {
                        Console.WriteLine("ingrese el numero {0} ", i + 1);
                        NumeroR[i] = Convert.ToInt32(Console.ReadLine());
                        if (NumeroAlea > NumeroR[i]) Console.WriteLine("muy bajo");
                        else if (NumeroAlea < NumeroR[i]) Console.WriteLine("muy alto");
                        else if (NumeroR[i] == NumeroAlea)
                        {
                            Console.WriteLine("los intentos fueron : " + (i + 1));
                            Console.WriteLine("felicidades ganaste!!! el numero ganador es " + NumeroAlea);
                            for (int j = i + 1; j < NumeroR.Length; j++)
                            {
                                NumeroR[j] = 0;
                            }
                            //verificador menor
                            int VarMen = NumeroR[0];
                            for (int s = 0; s < contador; s++)
                            {
                                if (NumeroR[s] < VarMen)
                                {
                                    VarMen = NumeroR[s];

                                }
                            }
                            //metodo burbuja 
                            for (int a = 1; a < NumeroR.Length; a++)
                            {
                                for (int b = NumeroR.Length - 1; b >= a; b--)
                                {
                                    if (NumeroR[b - 1] > NumeroR[b])
                                    {
                                        t = NumeroR[b - 1];
                                        NumeroR[b - 1] = NumeroR[b];
                                        NumeroR[b] = t;
                                    }
                                }
                            }
                            //fin de burbuja
                            Console.WriteLine("el numero menor propuesto es: " + VarMen);
                            Console.WriteLine("el numero mayor propuesto es: " + NumeroR[9]);
                            break;
                        }
                        contador++;
                    }
                       if (contador==10)
                       {
                        Console.WriteLine("has perdido, numeros de intentos fueron:" + contador + "  el numero ganador era: " + NumeroAlea);
                       
                       }
                    break;
                case 2:
                    byte NumPer = 0;
                    byte incre = 0;
                    Console.WriteLine("cuantas personas van a jugar?");
                    NumPer = Convert.ToByte(Console.ReadLine());
                    if (NumPer <= 1)
                    {
                        Console.WriteLine("Por favor reincie y escoja un jugador");
                    }
                    else
                    {
                        int[] juego = new int[10];
                        string[] Nombres = new string[NumPer];
                        byte mostarJ;

                        for (int i = 0; i < Nombres.Length; i++)
                        {
                            int j = i;
                            Console.WriteLine("Nombres : " + (++j));
                            Nombres[i] = Console.ReadLine();
                        }
                        do
                        {
                            Random azar = new Random();
                            int Randon = azar.Next(0,100);
                            Console.WriteLine(Randon);
                            for (int i = 0; i < juego.Length; i++)
                            {
                                Console.WriteLine("Ingrese un numero entre 1-100  " );
                                juego[i] = Convert.ToInt32(Console.ReadLine());
                                if (Randon > juego[i]) Console.WriteLine("muy bajo");
                                else if (Randon < juego[i]) Console.WriteLine("muy alto");
                                else if (Randon == juego[i])
                                {
                                    Console.WriteLine("Ganastes");
                                    break;
                                }
                            }
                            mostarJ = incre;
                            incre++;


                        } while (incre != NumPer);
                        Console.WriteLine("Los Jugadores fueron : "+ ++mostarJ);
                        for (int i = 0; i < NumPer; i++)
                        {   
                            if (i == NumPer-1)Console.WriteLine(Nombres[i] );
                            else Console.Write(Nombres[i] + " - ");
                        }
                    }
                    break;
                default:


                    break;
            }
        }
    }
}