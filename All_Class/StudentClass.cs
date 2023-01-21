class Student<Type>
{
    public Type id;
    public Type name;
    public Type email;
    public Type phone;
    public Type depertment;
    public Type[] subjects;

    public Student(Type id, Type name, Type email, Type phone, Type depertment, Type[] subjects)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.depertment = depertment;
        this.subjects = subjects;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(this.id);
        Console.WriteLine(this.name);
        Console.WriteLine(this.email);
        Console.WriteLine(this.phone);
        Console.WriteLine(this.depertment);
        Console.WriteLine(this.subjects);
    }
}