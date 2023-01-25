using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string surname;
            int num1;

            surname = "Abbasov";
            num1 = 34;
            num1 = 55;
            num1 = 88;

            string name = "Hikmet";
            char letter = 'A';

            bool check = false;

            byte age = 255;

            var num = 55;

            float price = 45.5f;


            var avgPoint = 55;

            var monthlyCreditPercent = 66.5; //camel case

            var MonthlyCreditPercent = 66.5; // pascal case

            var monthly_credit_percent = 66.5; //snake case

            // var monthly-credit-percent  kebab case

            bool isPasswordCorret = false;

            if(!isPasswordCorret)
            {
                Console.WriteLine("Sifre yanlisdir");
            }
           

            int number = 12;

            if (number > 0)
            {
                if (number%2==0)
                {
                    Console.WriteLine("musbet ve cutdur");
                }
                else
                {
                    Console.WriteLine("musbet ve tekdir");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("menfidir");
            }
            else
            {
                Console.WriteLine("Sifirdir");
            }

            




        }
    }
}
