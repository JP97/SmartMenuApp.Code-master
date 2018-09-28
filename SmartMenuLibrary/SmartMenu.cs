using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        string[] hovedsætningArray;
        string[] hovedsætningArraypaeengelsk;
        string hovedsætning = "";
        string line;
        public void LoadMenu(string path)
        {
            hovedsætningArray = File.ReadLines(@"..\..\" + path + "").Take(8).ToArray();
            hovedsætningArray = File.ReadLines(@"..\..\" + path + "").Skip(9).Take(10).ToArray();
        }
        
        public void Activate()
        {
            

            for (int i = 0; hovedsætningArray.Length > i; i++)
            {
                Console.WriteLine(hovedsætningArray[i]);
            }

            Console.WriteLine(hovedsætning);
            Console.WriteLine("intast et tal fra menu");

            int caseSwitch = int.Parse(Console.ReadLine());


            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("noget");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.WriteLine("3");
                    break;

                case 4:
                    Console.WriteLine("4");
                    break;

                default:
                    break;

            }



            string indtast = Console.ReadLine();
            int menuevalg = int.Parse(indtast);

            if (menuevalg >= 0 && menuevalg <= 5)
            {
                if (menuevalg == 1)
                {
                    Console.WriteLine("punkt 1 udført");
                }
                else if (menuevalg == 2)
                {
                    Console.WriteLine("punkt 2 udført");
                }
                else if (menuevalg == 3)
                {
                    Console.WriteLine("punkt 3 udført");
                }
                else if (menuevalg == 4)
                {
                    Console.WriteLine("punkt 4 udført");
                }
                else if (menuevalg == 5)
                {
                    Console.WriteLine("nu er menuet på engelsk");
                }
                else if (menuevalg == 0)
                {
                    Console.WriteLine("Slutter Programmet");
                }
                Console.ReadLine();
            }
        }
    }
}
