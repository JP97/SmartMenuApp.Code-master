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
            string Line1;
            string Line2;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Mia\source\repos\SmartMenuApp.Code-master\FunctionLibrary\TextMenue.txt");
            Line1 = file.ReadLine();
            Line2 = file.ReadLine();

            Console.WriteLine(Line1);
            Console.Write(Line2);
            Console.ReadKey();
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
