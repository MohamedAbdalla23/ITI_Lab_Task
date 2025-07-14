
namespace Day5Lab.Task_1
{
    internal class Person
    {
        private int _id;
        private string? _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string? Name
        {
            get { return _name; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Name is Invalid");
                }
                else
                {
                    _name = value;
                }
            }
        }


        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}");
        }


        public void DisplayInfo(bool showid)
        {
            if (showid == true)
            {
                Console.WriteLine($"Id: {Id}\nName: {Name}");
            }
            else
            {
                Console.WriteLine($"Name: {Name}");
            }
        }
    }
} 
