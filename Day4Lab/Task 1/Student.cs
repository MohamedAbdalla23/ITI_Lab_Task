
namespace Day4Lab
{
    internal class Student
    {
        public int Id;
        public string Name = default!; 
        public Gender Gender;
        public SubjectResult[] Results;


        public double CalculateAverage() 
        {
            double sum = 0;
            foreach (var item in Results)
            {
                sum += item.Grade;
            }
            return sum / Results.Length;
        } 
    }
}
