using System;

namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Da li zelis jebati kokosku ili koristiti kalkulator");
            string pitanje = Console.ReadLine();

            if (pitanje.Equals("kokosku") || pitanje.Equals("kokoska"))
            {
                Console.WriteLine("Uspesno ste izjebali kokosku sad idite na kalkulator");
            }
            else if (pitanje.Equals("kalkulator"))
            {
                Console.WriteLine("Upisite neki broj:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Upisite neki operator:");
                string op = Console.ReadLine();
                Console.WriteLine("Upisite neki broj ponovo:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (op.Equals("+") || op.Equals("/") || op.Equals("-") || op.Equals("*") || op.Equals("%"))
                {
                    switch (op)
                    {
                        case "+":
                            Console.WriteLine(num1 + num2);
                            break;
                        case "-":
                            Console.WriteLine(num1 - num2);
                            break;
                        case "/":
                            Console.WriteLine(num1 / num2);
                            break;
                        case "*":
                            Console.WriteLine(num1 * num2);
                            break;
                        case "%":
                            Console.WriteLine(num1 % num2);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ti si bolestan");
                }
            }
            else
            {
                Console.WriteLine("Sta bre?");
            }
        }
    }
}