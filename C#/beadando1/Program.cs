using System;

namespace Romlo_ertekek
    {
        class Program
        {   
            static void Main (string[] args)
            {
                int db=0, N;
                                
                N = int.Parse(Console.ReadLine()); //a ReadLine alapból stringet olvas be, ezért kell a Parse
                
                //Console.WriteLine("Napok szama: " + N);

                int[ , ] Levego = new int [N,2]; //nem tudjuk, hogy milyen hosszú lesz az N,
                                                 //ezért dinamikusan létrehozunk egy tömböt

                for(int i = 0; i < N; i++){
                        string[] sor = Console.ReadLine().Split(' ');
                        Levego[i, 0] = int.Parse(sor[0]); // bemeneti sor 1. elemét beolvassuk 
                        Levego[i, 1] = int.Parse(sor[1]);
                        //Console.WriteLine(sor[0]); //oszlop 1. eleme ennyi
                       // Console.WriteLine(sor[1]);
                }   
                /* for(int i=0; i< N; i++)
                    Console.WriteLine(Levego[i, 0] + " " + Levego[i, 1]);
 */
                for(int i=0; i<N-1; i++)
                     if (Levego[i, 0] < Levego[i+1, 0] && Levego[i,1] < Levego[i+1, 1])
                            db++;

                Console.WriteLine(db);
 
                }
            }
        } 
    
    
