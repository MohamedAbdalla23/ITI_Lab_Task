using Day4Lab.Task_2;
using Day4Lab.Task_3;
using System.Diagnostics;
using System.Xml.Linq;

namespace Day4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Student Management System
            Student[] student = new Student[3];
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                Console.Write("Student Name: ");
                student[i].Name = Console.ReadLine()!;
                Console.Write("Gender: ");
                student[i].Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine()!, true);
                student[i].Results = new SubjectResult[2];
                Console.WriteLine("Subjects: ");
                for (int j = 0; j < student[i].Results.Length; j++)
                {
                    SubjectResult sr = new SubjectResult();
                    Console.Write($"- Subject {j + 1} name: ");
                    sr.SubjectName = Console.ReadLine()!;
                    Console.Write($"- Grade: ");
                    sr.Grade = int.Parse(Console.ReadLine()!);
                    student[i].Results[j] = sr;
                }
                Console.WriteLine($"Average: {student[i].CalculateAverage()}");
                Console.WriteLine();
            }
            Console.Write($"Top Student: {TopStudent(student).Name} with average {TopStudent(student).CalculateAverage()}");
            #endregion


            #region Task 2: Product Inventory System
            Product[] product = new Product[3];

            product[0] = new Product(1, "Laptop", Category.Electronics, 15000, new Size(35, 25, 2));
            product[1] = new Product(2, "T-shirt", Category.Clothing, 300, new Size(40, 60, 1));
            product[2] = new Product(3, "Book", Category.Books, 200, new Size(15, 21, 2));

            foreach (var item in product)
            {
                item.DisplayInfo();
            }

            double totalprice = Product.GetTotalPrice(product);
            Console.WriteLine($"Total Price: {totalprice}");

            Product expensive = GetMostExpensiveProduct(product);
            Console.WriteLine($"Most Expensive Product: {expensive.Name}");
            #endregion


            #region Task 3: Car Rental System
            RentalService rentalService = new RentalService();

            rentalService.Fleet.Add(new Car(1, "Toyota Corolla", CarType.Sedan, false, 400, new Dimensions(4.6, 1.8, 1.5)));
            rentalService.Fleet.Add(new Car(2, "Kia Sportage", CarType.SUV, true, 650, new Dimensions(4.5, 1.9, 1.7)));
            rentalService.Fleet.Add(new Car(3, "BMW X7", CarType.Luxury, true, 1200, new Dimensions(5.1, 2.0, 1.8)));
            rentalService.Fleet.Add(new Car(4, "Hyundai i10", CarType.Economy, false, 300, new Dimensions(3.7, 1.7, 1.5)));

            rentalService.ShowAvailableCars();

            var expensiveCar = rentalService.GetMostExpensiveCar();
            if (expensiveCar != null)
            {
                Console.WriteLine($"Most Expensive Car: {expensiveCar.Model} | Type: {expensiveCar.Type} | Rate: {expensiveCar.DailyRate}/day\n");
            }

            int[] rentalDays = { 2, 3, 5, 1 };
            double totalRevenue = rentalService.CalculateTotalRevenue(rentalDays);
            Console.WriteLine($"Total Revenue from rented cars: {totalRevenue} EGP\n");

            rentalService.ChangeRentalStatus(1, true);

            var suvs = rentalService.FilterCarsByType(CarType.SUV);
            Console.WriteLine("SUV Cars:");
            foreach (var suv in suvs)
            {
                suv.DisplayInfo();
            }

            rentalService.SortCarsByRateDescending();
            Console.WriteLine("Cars Sorted by Daily Rate (Descending):");
            foreach (var car in rentalService.Fleet)
            {
                car.DisplayInfo();
            }
            #endregion
        }


        static Student TopStudent(Student[] std)
        {
            var top = std[0];
            double highavg = std[0].CalculateAverage();
            foreach (var student in std)
            {
                double average = student.CalculateAverage();
                if (average > highavg)
                {
                    highavg = average; 
                    top = student;
                }
            }
            return top;
        }

        static Product GetMostExpensiveProduct(Product[] products)
        {
            if (products.Length == 0) return null!;

            Product mostExpensive = products[0];
            foreach (var product in products)
            {
                if (product.Price > mostExpensive.Price)
                {
                    mostExpensive = product;
                }
            }
            return mostExpensive;
        }
    }
}
