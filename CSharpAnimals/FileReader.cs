namespace CSharpAnimals;

public class FileReader
{
    private StreamReader _sr;

    public FileReader(string file)
    {
        _sr = new StreamReader(file);
    }

    public void ReadFile()
    {
        while (!_sr.EndOfStream)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(_sr.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error reading file: " + e.Message);
            }
        }
    }

    public void Close()
    {
        _sr.Close();
    }
}