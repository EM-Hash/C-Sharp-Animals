namespace CSharpAnimals;

public abstract class Animal
{
    public string Name { get; set; }

    public string Phrase { get; }

    public string Talk()
    {
        return $"{Name} says {Phrase}!";
    }

    public Animal(string name, string phrase)
    {
        Name = name;
        Phrase = phrase;
    }
}