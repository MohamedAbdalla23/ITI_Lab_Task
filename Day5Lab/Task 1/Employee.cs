
namespace Day5Lab.Task_1
{
    internal class Employee : Person
    {
        public static int TotalEmployees = 0;
        public static double TotalPayroll = 0;


        public double BaseSalary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id,string name, double basesalary, DateTime hiredate):base(id,name)
        {
            BaseSalary = basesalary;
            HireDate = hiredate;
            TotalEmployees++;
            TotalPayroll += BaseSalary;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee's Salary: {BaseSalary}\nHire Date: {HireDate}");

        }
    }
}
