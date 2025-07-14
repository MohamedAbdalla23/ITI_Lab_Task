
namespace Day4Lab.Task_3
{
    public class Car
    {
        public int CarId;
        public string Model = String.Empty;
        public CarType Type;
        public bool IsRented;
        public double DailyRate;
        public Dimensions Size = default!;

        public Car(int carid, string model, CarType carType, bool isrented, double dailyRate, Dimensions dimensions)
        {
            CarId = carid;
            Model = model;
            Type = carType;
            IsRented = isrented;
            DailyRate = dailyRate;
            Size = dimensions;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {CarId} | Model: {Model} | Type: {Type} | Rented: {IsRented} | Rate: {DailyRate}/day");
            Console.WriteLine($"Dimensions: {Size.Length}m x {Size.Width}m x {Size.Height}m");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Available Cars: ");
            Console.WriteLine($"{Model} | Type: {Type} | Rate: {DailyRate}/day\r\n");
            Console.WriteLine($"Kia Sportage{Model} | {Type}Type: SUV | Rate: {DailyRate}650/day");
            Console.WriteLine($"Most Expensive Car: BMW X7 | Type: Luxury | Rate: 1200/day");
            Console.WriteLine($"Total Revenue from rented cars: 8800 EGP");
        }

        public double CalculateRentalCost(int days)
        {
            return days * DailyRate;
        }
    }
}
