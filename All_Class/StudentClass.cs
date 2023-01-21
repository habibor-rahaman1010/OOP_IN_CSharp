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

    public void DisplayInfo<T>(Student<T> data)
    {
        Console.WriteLine("ID: " + data.id);
        Console.WriteLine("Name: " + data.name);
        Console.WriteLine("Email " + data.email);
        Console.WriteLine("Phone" + data.phone);
        Console.WriteLine("Department: " + data.department);

        Console.WriteLine("Subjects: ");
        foreach (var item in data.subjects)
        {
            Console.WriteLine("\t" + item);
        }
    }
}