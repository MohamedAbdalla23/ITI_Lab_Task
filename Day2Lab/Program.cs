
namespace Day2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Title: Prime Numbers and Sorting");
            Console.Write("How many numbers? ");
            int count = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\nEnter numbers: ");
            int[] arr = new int[count];
            int sum = 0;
            for (int i = 0; i < count; i++)
                arr[i] = int.Parse(Console.ReadLine()!);
            Console.WriteLine("---------");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2 || arr[i] == 3)
                {
                    Console.WriteLine($"Prime numbers: {arr[i]} ");
                    sum += arr[i];
                }
                else if (arr[i] % 2 != 0 && arr[i] % 3 != 0)
                {
                    Console.WriteLine($"Prime numbers: {arr[i]} ");
                    sum += arr[i];
                }

            }
            Console.WriteLine("Sum of primes: " + sum);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            Console.Write("Sorted Array: ");
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.Write(arr[^i] + " ");
            }
            #endregion


            #region Task 2
            Console.WriteLine("Title: Transpose and Diagonal Sum of a Matrix");
            Console.WriteLine("Enter size of matrix: ");
            int size = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Enter {size}x{size} matrix: ");
            int[,] matrix = new int[size, size];
            int[,] transpos = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine()!);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Original Matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            transpos = matrix;
            Console.WriteLine("Transposed Matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(transpos[j, i] + " ");
                }
                Console.WriteLine();
            }

            int mainsum = 0, secondsum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        mainsum += matrix[i, j];
                    }

                }
            }
            Console.WriteLine("Main Diagonal Element: " + mainsum);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        secondsum += transpos[i, j];
                    }

                }
            }
            Console.WriteLine("Secondry Diagonal Element: " + secondsum);
            #endregion


            #region Task 3
            Console.WriteLine("Title: Count Vowels in a sentence");

            Console.WriteLine("\nEnter a sentence: ");
            string sentence = Console.ReadLine()!;
            int vowels = 0;
            foreach (char c in sentence.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    vowels++;
                }
            }
            Console.WriteLine("Number of vowels:" + vowels);
            #endregion


            #region Task 4
            Console.WriteLine("Title: Calculate Total and Average Marks Using Jagged Array\n\n");

            Console.Write("Enter number of students: ");
            int students = int.Parse(Console.ReadLine()!);
            Console.WriteLine(" ");
            int[][] jaggedArray = new int[students][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: ");
                Console.Write("Enter number of subjects: ");
                int subjects = int.Parse(Console.ReadLine()!);
                jaggedArray[i] = new int[subjects];
                for (int j = 0; j < subjects; j++)
                {
                    Console.Write($"Enter marks for subject {j + 1}: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine()!);
                }
                int total = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    total += jaggedArray[i][j];
                }
                Console.Write("Total Marks: ");
                Console.WriteLine(total);
                double average = (double)total / jaggedArray[i].Length;
                Console.WriteLine("Average Marks: " + average);
                Console.WriteLine(" ");
            }
            #endregion
        }
    }
}
