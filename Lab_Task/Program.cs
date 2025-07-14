namespace Day1Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.Write("How many numbers will you enter? ");
            int count = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");

            int sum = 0, average = 0, max = 0, min = 0, odd = 0, even = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine()!);

                if (number > max)
                    max = number;

                if (number < min || i == 1)
                    min = number;


                if (number % 2 == 0)
                    even++;
                else
                    odd++;

                sum += number;

                average = sum / count;
            }
            if (even > odd)
            {
                Console.WriteLine("\n\nMost of your numbers are even.");
            }
            else
            {
                Console.WriteLine("\n\nMost of your numbers are odd.");
            }

            Console.WriteLine("\n\nSum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            #endregion


            #region Task 2
            int balance = 1000;
            Console.Write("Welcome to the ATM!\n\n");
            while (true)
            {
                Console.WriteLine("1) Check Blance");
                Console.WriteLine("2) Deposit");
                Console.WriteLine("3) Withdraw");
                Console.WriteLine("4) Exit");

                int choice = int.Parse(Console.ReadLine()!);


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is: $" + balance);
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        int deposit = int.Parse(Console.ReadLine()!);
                        balance += deposit;
                        Console.WriteLine("Balance is now: " + balance);
                        break;
                    case 3:
                        Console.Write("Enter the amount to withdraw: ");
                        int withdraw = int.Parse(Console.ReadLine()!);
                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient funds. Your current balance is: $" + balance);
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("Balance is now: " + balance);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exitting..");
                        break;
                    default:
                        Console.WriteLine("Invalid Value");
                        break;
                }
                if (choice == 4)
                {
                    Environment.Exit(0);
                }
            }
            #endregion
        }
    }
}
