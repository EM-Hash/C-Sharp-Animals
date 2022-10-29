namespace CSharpAnimals;

public class Teacher : Animal
{
    public int Age { get; set; }

    public Teacher(string name, int age) : base(name, "don't forget to do the assigned reading")
    {
        Age = age;
    }
}