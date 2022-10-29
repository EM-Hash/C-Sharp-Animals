namespace CSharpAnimals;

public class Cat : Animal
{
    public int MiceKilled { get; set; }

    public Cat(string name, int miceKilled) : base(name, "meow")
    {
        MiceKilled = miceKilled;
    }
}