
namespace Day5Lab.Task_2
{
    internal class LibraryItem
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }

        public static int ItemCount;
        private static int _nextId = 1;

        public LibraryItem(string title, string author)
        {
            Id = _nextId;
            Title = title;
            Author = author;
            _nextId++;
            ItemCount++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {Author}");
        }

        public void ShowInfo(string prefix)
        {
            Console.WriteLine($"{prefix}");
            ShowInfo();
        }
    }
}
