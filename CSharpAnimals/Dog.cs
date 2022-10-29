namespace CSharpAnimals;

public class Dog : Animal
{
    public bool Friendly { get; set; }
    
    public Dog(string name, bool friendly) : base (name, "woof")
    {
        Friendly = friendly;
    }
}