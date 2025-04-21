using laba5;

class Program
{
    public static void Main()
    {
        Train train = new Train(100, 92);
        Car car = new Car(120, 4);
        Moped moped = new Moped(80, 2);
        Motorbike motorbike = new Motorbike(150, 2);
        Bicycle bicycle = new Bicycle(25, 2);

        foreach (var transports in new Transport[] { train, car, moped, motorbike, bicycle })
        {
            transports.ShowInfo();
            Console.WriteLine(new string('-', 50));

        }

    }
}