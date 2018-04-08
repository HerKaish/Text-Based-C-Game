using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMEE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doublei
            double oneHandedAttack;
            double twoHandedAttack;
            double communicationSkills;
            double stealth;
            //Intriger Based variable
            int correct = 0;

            //Stringovi
            string pol;
            string klasa;
            string ime;

            // Kreacija pola
            do
            {
                Console.Clear();
                Console.WriteLine("Klasu vašeg lika: \n Muško \n Žensko");
                pol = Console.ReadLine().ToUpper();

                // Muški pol
                if (pol == "MUSKO" || pol == "MUŠKO")
                {
                    correct = 1;
                }
                //ženski pol
                else if (pol == "ZENSKO" || pol == "ŽENSKO")
                {

                    correct = 1;

                }
                else
                {

                }
            } while (correct == 0);
            
            correct = 0;
            // Kreacija klase
            do
            {
                Console.Clear();
                Console.WriteLine("Klasu vašeg lika: \n Trgovac \n Ratnik \n Lopov");
                klasa = Console.ReadLine().ToUpper();

                // Muški pol
                if (klasa == "TRGOVAC" || klasa == "LOPOV" || klasa == "RATNIK")
                {
                    correct = 1;
                }
                //ženski pol
               
                else
                { }
            } while (correct == 0);
            correct = 0;
           
            

            }
        }
    }
