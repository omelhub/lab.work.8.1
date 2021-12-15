using System;

namespace lab.work._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factoryAf = new FactoryAF();
            factoryAf.AddCar(37);
            factoryAf.AddCar(39);
            factoryAf.AddCar(41);
            factoryAf.AddCar(43);
            factoryAf.Customers.Add(new Customer { FIO = "Луис Альберто Рамирес" });
            factoryAf.Customers.Add(new Customer { FIO = "Диего Сезар Рамос    " });
            factoryAf.Customers.Add(new Customer { FIO = "Артуро Сото Рангель  " });
            factoryAf.Customers.Add(new Customer { FIO = "Ана де ла Регуера    " });
            factoryAf.Customers.Add(new Customer { FIO = "Хуан Клаудио Ретес   " });

            string FormatOfWord()
            {
                int x = factoryAf.Cars.Count;
                if (x % 10 == 1)
                    return "машина";
                else if (x % 10 > 1 & x % 10 < 5)
                    return "машины";
                else return "машин";
            }

            Console.WriteLine($"На складе: {factoryAf.Cars.Count} {FormatOfWord()}.");
            Console.WriteLine();
            foreach (Customer customer in factoryAf.Customers)
            {
                Console.Write(customer.FIO);
                if (customer.Car is null)
                {
                    Console.Write(" - пешеход!\n");
                }
                else
                {
                    Console.WriteLine($" - номер машины = {customer.Car.Number}, размер педалей = {customer.Car.engine.Size}\n");
                }
            }

            factoryAf.SaleCar();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(".....................");
            Console.ResetColor();

            foreach (Customer customer in factoryAf.Customers)
            {
                Console.Write(customer.FIO);
                if (customer.Car is null)
                {
                    Console.Write(" - НЕ ХВАТИЛО МАШИНЫ!\n");
                }
                else
                {
                    Console.WriteLine($" - номер машины = {customer.Car.Number}, размер педалей = {customer.Car.engine.Size}\n");
                }
            }
            Console.ReadKey();
        }
    }
}
