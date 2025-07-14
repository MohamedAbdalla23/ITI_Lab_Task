
namespace Day5Lab.Task_2
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public DateTime PublishDate { get; set; }

        public Magazine(string title, string author, int issueNumber, DateTime publishDate)
            : base(title, author)
        {
            IssueNumber = issueNumber;
            PublishDate = publishDate;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Magazine: {Title}, Issue: {IssueNumber}, Published: {PublishDate:dd/MM/yyyy}");
        }
    }
}
