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

           
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Mia\source\repos\SmartMenuApp.Code-master\FunctionLibrary\TextMenue.txt");
            line = file.ReadLine();
            
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                hovedsætning += line;
                
            }
            
        }
        public void Activate()
        {
            Console.Write("intast et menupunkt: ");
            int intastMenuPunkt = int.Parse(Console.ReadLine());

            if (intastMenuPunkt >= 0 && intastMenuPunkt <= 4)
            {
                while (intastMenuPunkt >= 0 && intastMenuPunkt <= 4)
                {
                    if (intastMenuPunkt == 0)
                    {
                        //hvad der skal ske for punkt 0
                    }
                    else if (intastMenuPunkt == 1)
                    {
                        //hvad der skal ske for punkt 1..
                    }
                    else if (intastMenuPunkt == 2)
                    {
                        //hvad der skal ske for punkt 2..
                    }
                    else if (intastMenuPunkt == 3)
                    {
                        //osv
                    }
                    else if (intastMenuPunkt == 4)
                    {

                    }

                    Console.Write("Intast et nyt menupunkt, eller tryk 5 for at afslutte ");
                    intastMenuPunkt = int.Parse(Console.ReadLine());    //opdatere input
                }
            }
            
            
            
        }
    }
}
