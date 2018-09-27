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
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Mathias Elken\source\repos\SmartMenuApp.Code-master\FunctionLibrary\TextMenue.txt");
            line = file.ReadLine();
            //Line2 = file.ReadLine();
            //f
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                hovedsætning += line;
                
            }
            
        }
        public void Activate()
        {
             
            string line;
            string hovedsætning = "";
            
            //string Line2;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Mathias Elken\source\repos\SmartMenuApp.Code-master2\FunctionLibrary\TextMenue.txt");
            line = file.ReadLine();
            //Line2 = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                hovedsætning += line;

            }
            string[] menuIArray= hovedsætning.Split(';');


            Console.WriteLine("indtast et tal fra menu");

            int første = int.Parse(menuIArray[3]);
            int anden = int.Parse(menuIArray[5]);
            int tredje = int.Parse(menuIArray[7]);
            int fjerde = int.Parse(menuIArray[9]);

            int menuevalg = int.Parse(Console.ReadLine());
            

            if (menuevalg >= 0 && menuevalg <= 9)
            {
                if (menuevalg == 3)
                {
                    Console.WriteLine("det er 3");
                }
                else if (menuevalg == 5)
                {
                    Console.WriteLine("punkt 5 udført");
                }
                else if (menuevalg == 7)
                {
                    Console.WriteLine("punkt 7 udført");
                }
                else if (menuevalg == 9)
                {
                    Console.WriteLine("punkt 9 udført");
                }
            }
        }
    }
}
