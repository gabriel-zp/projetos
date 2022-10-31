using System;
namespace teste
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the funcion to calculate the full price of 5 done projects");
            PriceCalc();
        }
        static void PriceCalc()
        {
            double[] price = new double[5];
            double[] individualPrice = new double[5];
            double valor = 0;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"Enter project price {i+1}");
                price[i] = double.Parse(Console.ReadLine());
                valor = valor + price[i];
            }
            System.Console.WriteLine("\nProjects list:");
            for(int z=0;z<5;z++)
            {
                System.Console.WriteLine($"{z+1}. Price: ${price[z]}");
            }
            double finalPrice = valor-(valor*0.18);
            Console.WriteLine($"\nThe total amount of the projects is {finalPrice}");
            Console.WriteLine($"Insert the number of the speficic project you want to know the price");
            int a = int.Parse(Console.ReadLine());
            individualPrice[a] = price[a]*0.82;
            Console.WriteLine($"The price of the projet {a} is {individualPrice[a]}");
            Console.ReadKey();
        }
    }
}