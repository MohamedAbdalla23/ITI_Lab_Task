
namespace Day5Lab.Task_2
{
    internal class LibraryStats
    {
        public static void PrintTotalItems()
        {
            Console.WriteLine($"Total Library Items: {LibraryItem.ItemCount}");
        }

        public static Book GetMostBorrowed(Book[] books)
        {
            Book mostBorrowed = books[0];
            foreach (var book in books)
            {
                if (book.BorrowCount > mostBorrowed.BorrowCount)
                    mostBorrowed = book;
            }
            return mostBorrowed;
        }
    }
}
