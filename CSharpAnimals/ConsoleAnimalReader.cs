using System.Collections;

namespace CSharpAnimals;

public class ConsoleAnimalReader
{
    public void getAnimals(ArrayList animalList, string[] animalNames)
    {
        string input = "";
        while (input.Length <= 0 || input.ToUpper()[0] != 'N')
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Would you like to add an animal? (Y/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                input = Console.ReadLine();

                if (input.ToUpper()[0] != 'Y')
                {
                    if (input.ToUpper()[0] == 'N' )
                    {
                        break;
                    }
                    throw new Exception("Invalid input");
                }

                
                
                Console.WriteLine("What kind of animal is it?");
                for (int i = 0; i < animalNames.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}. {animalNames[i]}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                string? animalNumInput = Console.ReadLine();
                EnsureStringNotEmpty(animalNumInput);

                int animalNum;
                if (!Int32.TryParse(animalNumInput, out animalNum))
                {
                    throw new Exception("Invalid input");
                }

                string animal;

                if (animalNames[animalNum] != null)
                {
                    animal = animalNames[animalNum];
                }
                else
                {
                    throw new Exception("Invalid input");
                }

                Console.WriteLine("What is the animal's name?");
                string? name = Console.ReadLine();
                EnsureStringNotEmpty(name);

                
                switch (animal)
                {
                    case "Dog":
                        animalList.Add(GetDog(name));
                        break;
                    case "Cat":
                        animalList.Add(GetCat(name));
                        break;
                    case "Teacher":
                        animalList.Add(GetTeacher(name));
                        break;
                    default:
                        throw new Exception("Invalid input");
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {e.Message}.");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }

    private Dog GetDog(string name)
    {
        Console.WriteLine($"Is {name} friendly?");
        string? friendlyInput = Console.ReadLine();
        EnsureStringNotEmpty(friendlyInput);
        char friendlyChar = friendlyInput.ToUpper()[0];
        bool isFriendly;
        switch (friendlyChar)
        {
            case 'Y':
                isFriendly = true;
                break;
            case 'N':
                isFriendly = false;
                break;
            default:
                throw new Exception("Invalid input");
        }

        return new Dog(name, isFriendly);
    }

    private Cat GetCat(string name)
    {
        Console.WriteLine($"How many mice has {name} hunted?");
        string? input = Console.ReadLine();
        EnsureStringNotEmpty(input);
        int miceHunted;
        if(!Int32.TryParse(input, out miceHunted))
        {
            throw new Exception("Invalid input");
        }

        return new Cat(name, miceHunted);
    }

    private Teacher GetTeacher(string name)
    {
        Console.WriteLine($"How old is {name}?");
        string? input = Console.ReadLine();
        EnsureStringNotEmpty(input);
        int age;
        if(!Int32.TryParse(input, out age))
        {
            throw new Exception("Invalid input");
        }

        return new Teacher(name, age);
    }

    private void EnsureStringNotEmpty(string? input)
    {
        if (input == null || input.Trim() == "")
        {
            throw new Exception("Invalid input");
        }
    }
}