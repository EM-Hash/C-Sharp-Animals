using System.Collections;
using CSharpAnimals;

FileWriter fw = new FileWriter("animals.txt");
ConsoleAnimalReader consoleReader = new ConsoleAnimalReader();

ArrayList animals = new ArrayList();

string[] animalNames = {"Dog", "Cat", "Teacher"};
consoleReader.getAnimals(animals, animalNames);

Console.ForegroundColor = ConsoleColor.White;
fw.PrintOut(animals);
fw.Close();

Console.ForegroundColor = ConsoleColor.White;
FileReader fr = new FileReader("animals.txt");
fr.ReadFile();
fr.Close();