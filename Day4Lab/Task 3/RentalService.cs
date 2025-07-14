
namespace Day4Lab.Task_3
{
    public class RentalService
    {
        public List<Car> Fleet { get; set; } = new List<Car>();

        public void ShowAvailableCars()
        {
            Console.WriteLine("Available Cars:");
            foreach (Car car in Fleet)
            {
                if (!car.IsRented)
                {
                    Console.WriteLine($"- {car.Model} | Type: {car.Type} | Rate: {car.DailyRate}/day");
                } 
            }
            Console.WriteLine();
        }

        public Car? GetMostExpensiveCar()
        {
            if (Fleet.Count == 0) return null;

            Car expensiveCar = Fleet[0];

            foreach (var car in Fleet)
            {
                if (car.DailyRate > expensiveCar.DailyRate)
                {
                    expensiveCar = car;
                }
            }
            return expensiveCar;
        }

        public double CalculateTotalRevenue(int[] rentalDays)
        {
            int total = 0;
            for (int i = 0; i < Fleet.Count && i < rentalDays.Length; i++)
            {
                if (Fleet[i].IsRented)
                {
                    total += (int)Fleet[i].CalculateRentalCost(rentalDays[i]);
                }
            }
            return total;
        }

        public bool ChangeRentalStatus(int carId, bool newStatus)
        {
            var car = Fleet.FirstOrDefault(c => c.CarId == carId);
            if (car != null)
            {
                car.IsRented = newStatus;
                return true;
            }
            return false;
        }

        public void SortCarsByRateDescending()
        {
            Fleet = Fleet.OrderByDescending(c => c.DailyRate).ToList();
        }

        public List<Car> FilterCarsByType(CarType type)
        {
            return Fleet.Where(c => c.Type == type).ToList();
        }
    }
}
