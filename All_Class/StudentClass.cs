class Student<Type>
{
    public Type id;
    public Type name;
    public Type email;
    public Type phone;
    public Type department;
    public Type[] subjects;

    public Student(Type id, Type name, Type email, Type phone, Type department, Type[] subjects)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.department = department;
        this.subjects = subjects;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("ID: ", this.id);
        Console.WriteLine("Name: ", this.name);
        Console.WriteLine("Email ", this.email);
        Console.WriteLine("Phone", this.phone);
        Console.WriteLine("Department: ", this.department);

        Console.WriteLine("Subjects: ");
        foreach (var item in this.subjects)
        {
            Console.WriteLine("\tb", item);
        }
    }
}