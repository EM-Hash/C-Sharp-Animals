using System.Collections;

namespace CSharpAnimals;

public class FileWriter
{
    private StreamWriter _sw;

    public FileWriter(string file)
    {
        _sw = new StreamWriter(file);
    }

    public void PrintOut(ArrayList list)
    {
        foreach(Animal a in list)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(a.Talk());
            _sw.WriteLine(a.Name + " | " + a.Phrase);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(a.Name + " | " + a.Phrase);
        }
    }

    public void Close()
    {
        _sw.Close();
    }
}