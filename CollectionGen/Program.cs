using System;
using ClassLibrary;

namespace CollectionGen
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Car> carCollection = new MyCollection<Car>();
            Car car = new Car { CarBrand = "mersedes" };
            carCollection.Add(car);
            Car car1 = new Car { CarBrand = "bmw" };
            carCollection.Add(car1);
            Car car2 = new Car { CarBrand = "audi" };
            carCollection.Add(car2);
            Console.WriteLine("Общее количество элементов: " + carCollection.Count);
            Console.WriteLine(carCollection[0]);

            Console.WriteLine();

            MyCollection<Boat> boatCollection = new MyCollection<Boat>();
            Boat boat = new Boat { Name = "submarine" };
            boatCollection.Add(boat);
            Boat boat1 = new Boat { Name = "kayak" };
            boatCollection.Add(boat1);
            Boat boat2 = new Boat { Name = "canoe" };
            boatCollection.Add(boat2);
            Console.WriteLine("Общее количество элементов: " + boatCollection.Count);
            Console.WriteLine(boatCollection[0]);

            Console.ReadKey();
        }
    }
}
