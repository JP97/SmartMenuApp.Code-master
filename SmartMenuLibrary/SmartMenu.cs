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
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\julia\Desktop\programmerings-projekt\SmartMenuApp.Code-master\FunctionLibrary\TextMenue.txt");
            Line1 = file.ReadLine();
            Console.WriteLine(Line1);
            Console.ReadLine();
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
