
namespace Day5Lab.Task_2
{
    internal class Book : LibraryItem
    {
        public string? Genre { get; set; }
        public int BorrowCount { get; set; }

        public Book(string title, string author, string genre)
            : base(title, author)
        {
            Genre = genre;
            BorrowCount = 0;
        }

        public void Borrow()
        {
            BorrowCount++;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Book: {Title}, Author: {Author}, Genre: {Genre}, Borrowed: {BorrowCount} times");
        } 

        public static bool operator >(Book left, Book right)
        {
            return left.BorrowCount > right.BorrowCount;
        }

        public static bool operator <(Book left, Book right)
        {
            return left.BorrowCount < left.BorrowCount;
        }
    }
}
