
namespace Day5Lab.Task_1
{
    internal class Manager : Employee
    {
        public double Bonus { get; set; }
        public List<Employee> TeamMembers { get; set; }

        public Manager(int id, string fullName, double baseSalary, double bonus, DateTime hireDate)
            : base(id, fullName, baseSalary, hireDate)
        {
            Bonus = bonus;
            TeamMembers = new List<Employee>();
            TotalPayroll += bonus;
        }

        public double GetTotalSalary()
        {
            return BaseSalary + Bonus;
        }

        public void AddTeamMember(Employee e)
        {
            TeamMembers.Add(e);
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}\nTotal Salary: {GetTotalSalary()}\nTeam Size: {TeamMembers.Count}");
            Console.WriteLine($"");
            Console.WriteLine($"");
        }

        public static Manager operator +(Manager a, Manager b)
        {
            int newId = a.Id + b.Id;
            string newName = $"{a.Name}-{b.Name}";
            double newBaseSalary = a.BaseSalary + b.BaseSalary;
            double newBonus = a.Bonus + b.Bonus;

            Manager mergedManager = new Manager(newId, newName, newBaseSalary, newBonus, DateTime.Now);

            foreach (var member in a.TeamMembers)
                mergedManager.AddTeamMember(member);
            foreach (var member in a.TeamMembers)
                mergedManager.AddTeamMember(member);

            return mergedManager;
        }
    }
}
