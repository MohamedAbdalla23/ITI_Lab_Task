using System.Diagnostics.CodeAnalysis;

namespace Day3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Section 1
            #region Task 1: Increase Salary
            Console.WriteLine("What is your current salary? ");
            int salary = int.Parse(Console.ReadLine()!);
            AddBonus(ref salary);
            Console.WriteLine($"The new salary is {salary}.");
            #endregion


            #region Task 2: Swap Two Numbers
            Console.WriteLine("Please enter two number: ");
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The numbers before swapping; A = {x}, B = {y}");
            SwapValues(ref x, ref y);
            Console.WriteLine($"The numbers after swapping; A = {x}, B = {y}");
            #endregion


            #region Task 3: Reverse an Array (Using ref)
            Console.WriteLine("Please enter numbers of elements in array: ");
            int size = int.Parse(Console.ReadLine()!);

            int[] arr = new int[size];
            Console.WriteLine("Please enter the number of each element array: ");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine()!);

            Console.WriteLine("The original array: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($" {arr[i]} ");

            Console.WriteLine("\nThe reversed array: ");
            ReverseArray(ref arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($" {arr[i]} ");
            #endregion



            //Section 2
            #region Task 4: Division Helper
            Console.WriteLine("Please enter the dividend number:");
            int dividend = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Please enter the divisor number:");
            int divisor = int.Parse(Console.ReadLine()!);
            int qoutient, remainder;
            DivideAndRemainder(dividend, divisor, out qoutient, out remainder);
            Console.WriteLine($"Quotient: {qoutient}");
            Console.WriteLine($"Remainder: {remainder}");
            #endregion


            #region Task 5: Get Student Info
            Console.WriteLine("Please enter Student info: ");
            Console.Write("Student's name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine(" ");
            GetStudentInfo(name, out int age, out double grade);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            #endregion


            #region Task 6: Array Statistics
            Console.Write("Enter the number of scores: ");
            int scorenumber = int.Parse(Console.ReadLine()!);
            int[] scores = new int[scorenumber];
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Enter score {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine()!);
            }
            CalculateArrayStats(scores, out int max, out int min, out double average);
            Console.Write("The Score: ");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{scores[i]} ");
            }
            Console.Write("Maximum Score: ");
            Console.WriteLine(max);
            Console.Write("Minimum Score: ");
            Console.WriteLine(min);
            Console.Write("Average Score: ");
            Console.WriteLine(average);
            #endregion


            #region  Task 7: Modify Array Values with ref and out
            Console.Write("Enter the number of array: ");
            int arraynumber = int.Parse(Console.ReadLine()!);
            int[] array = new int[arraynumber];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine()!);
            }
            ModifyAndSumArray(ref array, out int sum);
            Console.Write("Modified array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
            Console.Write("The sum: ");
            Console.WriteLine(sum);
            #endregion


            #region  Task 8: Separate Even and Odd Numbers
            Console.Write("Enter the number of array: ");
            int arraysize = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[arraysize];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            SeparateEvenOdd(numbers, out int[] evennumbers, out int[] oddnumbers);
            Console.WriteLine("\nEven Numbers:");
            foreach (int even in evennumbers)
            {
                Console.Write(even + " ");
            }
            Console.WriteLine("\nOdd Numbers:");
            foreach (int odd in oddnumbers)
            {
                Console.Write(odd + " ");
            }
            #endregion


            #region employee attendance tracking system
            Employee[] Employees = new Employee[3];
            Console.WriteLine("Enter details for 3 employees:\n");
            for (int i = 0; i < Employees.Length; i++)
            {
                Employees[i] = new Employee();

                Console.WriteLine($"Employee #{i + 1}");

                Console.Write("Enter ID: ");
                Employees[i].Id = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Name: ");
                Employees[i].Name = Console.ReadLine()!;

                Console.Write("Enter Department: ");
                Employees[i].Department = Console.ReadLine()!;

                Console.WriteLine("Choose Attendance Status: ");
                Console.WriteLine("0 - Present, 1 - Absent, 2 - OnLeave");
                int statusChoice = int.Parse(Console.ReadLine()!);

                Console.WriteLine();
            }
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"{"ID",-5} {"Name",-15} {"Department",-15} {"Status",-10}");
            foreach (var emp in Employees)
            {
                Console.WriteLine($"{emp.Id,-5} {emp.Name,-15} {emp.Department,-15} {emp.Status,-10}");
            }
            #endregion
        }

        static void AddBonus(ref int salary)
        {
            salary += 1000;
        }

        static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void ReverseArray(ref int[] numbers)
        {
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = numbers[numbers.Length - i - 1];
            }
            numbers = arr;
        }

        static void DivideAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        static void GetStudentInfo(string name, out int age, out double grade)
        {
            age = 20;
            grade = 85.5;
        }

        static void CalculateArrayStats(int[] scores, out int max, out int min, out double average)
        {
            max = scores[0];
            min = scores[0];
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                    max = scores[i];
            }

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            average = sum / scores.Length;
        }

        static void ModifyAndSumArray(ref int[] arr, out int sum)
        {
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 5;
                sum += arr[i];
            }
        }

        static void SeparateEvenOdd(int[] input, out int[] evenNumbers, out int[] oddNumbers)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evens.Add(input[i]);
                }
                else
                {
                    odds.Add(input[i]);
                }
            }

            evenNumbers = evens.ToArray();
            oddNumbers = odds.ToArray();
        }
    }


    enum AttendanceStatus
    {
        Present,
        Absent,
        OnLeave,
        Late
    }

    struct Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public AttendanceStatus Status;
    }


}
