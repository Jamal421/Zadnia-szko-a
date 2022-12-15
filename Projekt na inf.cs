using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gotowy?");
            bool tak = true;
            while (tak)
            {
                Console.WriteLine("Tak- a|||Nie- b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    Console.WriteLine("To zaczynamy");
                    Console.ReadLine();

                }
                else if (inp == "b")
                {
                    Console.WriteLine("Wróć jak będzisz gotoyw");
                    Console.ReadLine();
                    return;

                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Wchodzisz do szkoły, wchodzisz do sztni?");
                Console.WriteLine("Tak- a|||Nie- b");
                string inp1 = Console.ReadLine();
                if (inp1 == "a")
                {
                    Console.WriteLine("Zmieniasz buty i idzesz do sali");
                    Console.ReadKey();

                }
                else if (inp1 == "b")
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("woźna złapała cie, że nie zmieniłeś butów");
                    Console.WriteLine("zostałeś wyrzucony ze szkoły");
                    Console.WriteLine("może teraz isć do domu sie wyspać");
                    Console.WriteLine("pa pa");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Do jakiej sali idzisz");
                Console.WriteLine("Od geografi- a|||Od matmy- b|||Od chemi- c");
                string inp2 = Console.ReadLine();
                if (inp2 == "a")
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Wchodizsz do sali i się dowiadujesz że jest kartkóka");
                    Console.WriteLine("Zaczynasz się uczyć?");
                    Console.WriteLine("Tak- a|||Nie- b");
                    string inp3 = Console.ReadLine();
                    if (inp3 == "a")
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Dobra decyzja dostałeś 5 ");
                        Console.WriteLine("na spokojnie raczej dostaniesz obiad");
                        Console.ReadLine();
                        

                    }
                    else if (inp3 == "b")
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Oj to była załda decyzja bo dostałeś 1");
                        Console.WriteLine("mama będzie zła");
                        Console.WriteLine("lepiej uciekaj");
                        Console.ReadLine();
                        return;
                    }


                }
                else if (inp2 == "b")
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Zapomniałeś, że jest sprawdzan");
                    Console.WriteLine("dlatego uciekłeś do domu żeby nie dostać 1");
                    Console.ReadLine();
                    return;

                }
                else if (inp2 == "c")
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("W sali wybuchł pożar");
                    Console.WriteLine("Pomagasz ugasić- a|||Ratujesz włąsny tyłek- b");
                    string inp4 = Console.ReadLine();
                    if  (inp4 == "a")
                    {
                        Console.WriteLine("Brawo wszyscy przeżyli i są szczęsliwi");
                        Console.WriteLine("Dostałeś odznake od dyrektora");
                        Console.ReadLine();
                    }
                    else if (inp4 == "b")
                    {
                        Console.WriteLine("Przeżyłeś, ale reszta klasy spłoneła");
                        Console.WriteLine("szuka cie policja lepiej uciekaj");
                        Console.ReadLine();
                        return;


                    }
                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Udało ci sie przetrwać szkołe");
                Console.WriteLine("ze spokojem możesz iśc do domu");
                Console.ReadLine();
                return;

                


                
            }

        }
    }
}
