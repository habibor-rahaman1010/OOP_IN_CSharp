namespace ClassPerson
{

    class Program
    {
        static void Main(string[] args)
        {
            Student<object> student1 = new Student<object>(144369, "Habibor Rahaman", "habibor.rahaman1010@gmail.com", "01768280237", "Computer science and engineering", new string[] { "hello", "mello" });

            student1.DisplayInfo();
        }
    }
}