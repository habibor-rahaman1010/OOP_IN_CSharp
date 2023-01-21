class Student<Type>
{
    public Type id;
    public Type name;
    public Type email;
    public Type phone;
    public Type depertment;
    public Type[] subjects;

    public Student(Type id, Type name, Type email, Type phone, Type depertmet, Type subjets)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.depertment = depertment;
        this.subjects = subjects;
    }
}