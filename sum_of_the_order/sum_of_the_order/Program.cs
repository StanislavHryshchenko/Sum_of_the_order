using System;

namespace sum_of_the_order
{
    class Program
    {
        public static double[] InputOrders(double[] x)
        {
            Console.Clear();
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter the price for the {i + 1} -th product: ");
                x[i] = /*(int)*/Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Price {x[i]} for {i + 1} -th product without discount");
            }
            return x;
        }

        static double[] InputDiscounts(double[] j)
        {
            Console.Clear();
            for (int i = 0; i < j.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter a discount for {i + 1} - th product: ");
                j[i] = /*(int)*/Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine();
            for (int i = 0; i < j.Length; i++)
            {
                Console.WriteLine($"Discount {j[i]} for {i + 1} -th product");
            }
            return j;
        }

        static double Calc(double[] r, double[] d)
        {
            Console.Clear();
            double tsum = 0;

            for (int i = 0; i < r.Length; i++)
            {
                tsum += r[i] - (r[i] * (d[i]*0.01));
            }

            return tsum;
        }

        public static void Main(string[] args)
        {
            bool isContinue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 1 to work with the program..");
                Console.WriteLine("Press 0 to exit..");
                string k = Console.ReadLine();
                switch (k)
                {
                    case "1": 
                        {
                            Console.WriteLine("Enter the number of products:");
                            double[] price = new double[(int)Convert.ToDouble(Console.ReadLine())];
                            double[] x = new double[price.Length];
                            price = InputOrders(x);
                            Console.WriteLine();
                            double[] discont = new double[price.Length];
                            double[] j = new double[price.Length];
                            discont = InputDiscounts(j);

                            Console.WriteLine();
                            double[] r = new double[price.Length];
                            r = price;
                            double[] d = new double[price.Length];
                            d = discont;

                            double sum = Calc(r, d);
                            Console.WriteLine($"The sum of prices for all products {Math.Round(sum, 2)}");
                            Console.ReadKey();
                        } break;
                    case "0": isContinue = false; break;
                    default: break;
                }
            }
            while (isContinue == true);
        }
    }
}
