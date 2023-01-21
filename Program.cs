namespace ClassPerson
{

    class Program
    {
        static void Main(string[] args)
        {
            Person<string> p1 = new ClassPerson.Person<string>("Habibor Rahaman", "habibor@gmail.com", "Dhaka", "Computer Science", "01768280237");
            p1.displayData();

            Person<int> p2 = new ClassPerson.Person<int>(12, 23, 45, 56, 11);
            p2.displayData();

            Person<object> p3 = new ClassPerson.Person<object>("mama", 34, "hello programme", 'A', true);
            p3.displayData();
        }
    }
}