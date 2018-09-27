using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            string line;
            string hovedsætning = "";
           
            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\" + path +"");
            line = file.ReadLine();
           
            while ((line = file.ReadLine()) != null)
            {
              //  System.Console.WriteLine(line);
                hovedsætning += line;
            }
        }
        public void Activate()
        { 


            Console.WriteLine("intast et tal fra menu");

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
