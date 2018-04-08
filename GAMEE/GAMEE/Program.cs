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
                Console.WriteLine("Unesite koji pol hocete biti: \n Muško \n Žensko");
                pol = Console.ReadLine().ToUpper();

                // Muški pol
                if (pol == "MUSKO" || pol =="MUŠKO")
                {
                    correct = 1;
                }
                //ženski pol
                else if (pol == "ZENSKO" ||pol =="ŽENSKO")
                {

                    correct = 1;

                }
                else
                { }
            } while (correct == 0);
            correct = 0;
            // Kreacija klase

        }
    }
}
