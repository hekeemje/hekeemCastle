using System;

namespace Task3
{
    class Vehicle
    {
        public string Coord;
        public int Price, Speed, SinceYear;

        public Vehicle(string coord, int price, int speed, int sinceYear)
        {
            Coord = coord;
            Price = price;
            Speed = speed;
            SinceYear = sinceYear;
        }

        public virtual void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Координаты : {Coord} | Цена : {Price}$ | Скорость : {Speed} км/ч | Дата выпуска т/с : {SinceYear}");
        }

    }

    class Plane : Vehicle
    {
        private double height;
        private int passengersCountPlane;

        public Plane(string coord, int price, int speed, int sinceYear, double height, int passengersCountPlane)
            : base(coord, price, speed, sinceYear)
        {
            this.height = height;
            this.passengersCountPlane = passengersCountPlane;

        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Info about Plane : ");
            base.PrintInfo();
            Console.WriteLine($"Высота полёта {height} | Количество пассажиров на борту : {passengersCountPlane}");
        }

    }

    class Car : Vehicle
    {
        private int maxSpeed;
        private string carName;

        public Car(string coord, int price, int speed, int sinceYear, string carName, int maxSpeed)
            : base(coord, price, speed, sinceYear)
        {
            this.carName = carName;
            this.maxSpeed = maxSpeed;

        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info about Car : ");
            base.PrintInfo();
            Console.WriteLine($"Максимальная скорость машины {maxSpeed} | Название машины : {carName}");
        }
    }

    class Ship : Vehicle
    {
        private int passengersCountShip;
        private string portName;

        public Ship(string coord, int price, int speed, int sinceYear, int passengersCountShip, string portName)
            : base(coord, price, speed, sinceYear)
        {
            this.portName = portName;
            this.passengersCountShip = passengersCountShip;

        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Info about Ship : ");
            base.PrintInfo();
            Console.WriteLine($"Название порта остановки : {portName} | Количество пассажиров на борту : {passengersCountShip}");
        }

    }
}
