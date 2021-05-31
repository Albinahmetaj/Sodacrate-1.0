using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaCrateProject
{
    class Sodacrate
    {
        List<Tuple<string, int>> list = new List<Tuple<string, int>>();

        List<string> sodaCrate = new List<string>();
        private string[] läskback = new string[24];
        private string[] drycker = new string[] { "Coca Cola", "Fanta", "Julmust", "Lättöl", "Ramlösa" };
        private int[] priser = new int[] {1, 2, 3, 4, 5};

        private bool huvudMeny = true;

        public void Run()
        {
            while (huvudMeny)
            {
                Console.WriteLine("Välkommen till Läskbacken");
                Console.WriteLine("Vad vill du göra?.");

                Console.WriteLine(" 1. Lägg till dryck.");
                Console.WriteLine(" 2. Visa innehåll i backen.");
                Console.WriteLine(" 3. Beräkna värde för innehållet.");
                Console.WriteLine(" 4. Avsluta programmet. \n");

                switch (Console.ReadLine())
                {
                    case "1":
                        add_soda();
                        break;

                    case "2":
                        //show_content();
                        Console.WriteLine("Din läskeback innehåller:");
                        sodaCrate.ForEach(Console.WriteLine);
                        break;

                    case "3":
                        calculate_value();
                        break;

                    case "4":
                        huvudMeny = false;
                        break;
                }
            }
        }

        public void add_soda()
        {
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("Vilken dryck vill du lägga till i Läskbacken?");
                for (int i = 0; i <= 4; i++)
                {
                    int place = i + 1;
                    Console.WriteLine(" " + place + ". " + drycker[i]);
                    /*
                    
                    list.Add(new Tuple<int, string>(1, "cat"));
	    list.Add(new Tuple<int, string>(100, "apple"));
	    list.Add(new Tuple<int, string>(2, "zebra"));
                
                    */
                }
                Console.WriteLine(" 6. Visa innehållet i läskbacken");
                Console.WriteLine(" 7. Tillbaka");

                switch (Console.ReadLine())
                {
                    case "1":
                        sodaCrate.Add("Coca Cola");
                        list.Add(new Tuple<string, int>(drycker[0], priser[0]));
                        break;

                    case "2":
                        sodaCrate.Add("Fanta");
                        list.Add(new Tuple<string, int>(drycker[1], priser[1]));
                        break;

                    case "3":
                        sodaCrate.Add("Julmust");
                        list.Add(new Tuple<string, int>(drycker[2], priser[2]));
                        break;

                    case "4":
                        sodaCrate.Add("Lättöl");
                        list.Add(new Tuple<string, int>(drycker[3], priser[3]));
                        break;

                    case "5":
                        sodaCrate.Add("Ramlösa");
                        list.Add(new Tuple<string, int>(drycker[4], priser[4]));
                        break;
                    case "6":
                        Console.WriteLine("Din läskeback innehåller:");
                        foreach (Tuple<String, int> item in list)
                        {
                            String sodaName = item.Item1;
                            int sodaPrice = item.Item2;
                            Console.WriteLine(sodaName);
                        }
                        //list.ForEach(Console.WriteLine);
                        break;
                    case "7":
                        continueLoop = false;
                        break;
                }
            }
        }
        
        public void calculate_value()
        {
            int totalValue = 0;
            foreach (Tuple<String, int> item in list)
            {
                String sodaName = item.Item1;
                int sodaPrice = item.Item2;

                totalValue += sodaPrice;
            }
            Console.WriteLine("Totala värdet av läskebacken är:");
            Console.WriteLine(" " + totalValue);

        }

        public void sort_sodas()
        {
            
        }
    }
    public class TupleList<T1, T2> : List<Tuple<T1, T2>>
    {
        public void Add(T1 item, T2 item2)
        {
            Add(new Tuple<T1, T2>(item, item2));
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Skapar ett objekt av klassen Sodacrate som heter sodacrate
            var sodacrate = new Sodacrate();
            sodacrate.Run();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

    }
}
