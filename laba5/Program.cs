using laba5;

class Program
{
    public static void Main()
    {
        Train train = new Train(100);
        Car car = new Car(120);
        Moped moped = new Moped(80);
        Motorbike motorbike = new Motorbike(150);
        Bicycle bicycle = new Bicycle(25);

        foreach (var transports in new Transport[] { train, car, moped, motorbike, bicycle })
        {
            transports.ShowInfo();
            Console.WriteLine(new string('-', 50));

        }

    }
}