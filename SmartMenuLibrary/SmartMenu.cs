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

            //string Line2;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Mia\source\repos\SmartMenuApp.Code-master\FunctionLibrary\TextMenue.txt");
            line = file.ReadLine();
            //Line2 = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                hovedsætning += line;
                

                
            }

            

            Console.ReadKey();
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
