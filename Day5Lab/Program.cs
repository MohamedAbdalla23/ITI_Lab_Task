using Day5Lab.Task_1;
using Day5Lab.Task_2;

namespace Day5Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Company HR & Payroll Management
            Employee e1 = new Employee(1, "Ali Hassan", 8000, DateTime.Now);
            Manager m1 = new Manager(2, "Sarah Ahmed", 12000, 3000, DateTime.Now);
            Employee e2 = new Employee(3, "Omar Tarek", 9000, DateTime.Now);
            Employee e3 = new Employee(4, "Laila Mohamed", 6000, DateTime.Now);

            m1.AddTeamMember(e2);
            m1.AddTeamMember(e3);

            Console.WriteLine($"Total Employees: {Employee.TotalEmployees}");
            Console.WriteLine($"Total Payroll: {Employee.TotalPayroll}");

            m1.DisplayInfo();

            Manager m2 = new Manager(5, "Ahmed Youssef", 10000, 2000, DateTime.Now);
            Employee e4 = new Employee(6, "Mona Adel", 5000, DateTime.Now);
            Employee e5 = new Employee(7, "Youssef Gamal", 7000, DateTime.Now);

            m2.AddTeamMember(e4);
            m2.AddTeamMember(e5);

            Manager mergedManager = m1 + m2;

            Console.WriteLine("\n[After Operator Overloading]");
            Console.WriteLine($"MergedManager created with total salary: {mergedManager.GetTotalSalary()}");
            Console.WriteLine($"Team Size: {mergedManager.TeamMembers.Count}");
            #endregion


            #region Task 2: Library System – Book and Borrow Management
            Book book1 = new Book("Clean Code", "Robert C. Martin", "Programming");
            Book book2 = new Book("The Pragmatic Programmer", "Andrew Hunt", "Programming");

            for (int i = 0; i < 7; i++)
                book1.Borrow();
            for (int i = 0; i < 5; i++)
                book2.Borrow();

            Magazine mag1 = new Magazine("National Geographic", "National Geographic Society", 142, new DateTime(2023, 6, 1));

            LibraryStats.PrintTotalItems();

            book1.ShowInfo();
            Console.WriteLine("----------");
            book2.ShowInfo();

            if (book1 > book2)
                Console.WriteLine($"\n{book1.Title} is more popular than {book2.Title}");
            else
                Console.WriteLine($"\n{book2.Title} is more popular than {book1.Title}");

            Book mostBorrowed = LibraryStats.GetMostBorrowed(new Book[] { book1, book2 });
            Console.WriteLine($"\nMost Borrowed Book: {mostBorrowed.Title}");

            mag1.ShowInfo();
            #endregion
        }
    }
}
