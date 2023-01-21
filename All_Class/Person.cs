namespace ClassPerson
{
    class Person<T>
    {
        public T name;
        public T email;
        public T address;
        public T subject;
        public T phone;

        public Person(T name, T email, T address, T subject, T phone)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.subject = subject;
            this.phone = phone;
        }
        public void displayData()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.email);
            Console.WriteLine(this.address);
            Console.WriteLine(this.subject);
            Console.WriteLine(this.phone);
        }
    }
}