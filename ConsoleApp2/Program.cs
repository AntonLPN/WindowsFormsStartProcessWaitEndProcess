using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


          

                args = new string[3];

                args[0] = "3";
                args[1] = "7";
                args[2] = "+";

                double a = 0, b = 0, res = 0;
                string oper = string.Empty;


                foreach (var item in args)
                {
                    Console.WriteLine(item);
                }


                foreach (var item in args)
                {
                    switch (item.ToString())
                    {
                        case "3":
                            {
                                double.TryParse(item.ToString(), out a);
                            }
                            break;

                        case "7":
                            {
                                double.TryParse(item.ToString(), out b);
                            }
                            break;
                        case "+":
                            {
                                oper = item.ToString();
                                res = a + b;
                            }
                            break;
                    }
                }



                Console.WriteLine($"{a}{oper}{b}={res}");

                Console.ReadKey();

            }
        
    }
}
