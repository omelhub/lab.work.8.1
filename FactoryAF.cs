using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._8._1
{
    class FactoryAF
    {
        public List<Customer> Customers { get; } = new List<Customer>();
        public List<Car> Cars { get; } = new List<Car>();


        public void SaleCar()
        {
            foreach (Customer customer in Customers)
            {
                if (customer.Car is null & Cars.Any())
                {
                    customer.Car = Cars.First();
                    Cars.Remove(Cars.First());
                }
            }
            if (Cars.Any())
                Cars.Clear();
        }

        public void AddCar(int Size)
        {
            Cars.Add(new Car(Size) { Number = Cars.Count + 1 });
        }
    }
}
