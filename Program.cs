using System;
using System.Collections;

namespace Mobile_Module_1B
{
    class Program
    {
      private static FileOutput outFile;
      private static FileInput inFile;
      public static void Main(string[] args)
      {
          outFile = new FileOutput("animals.txt");

          ArrayList zoo = new ArrayList();

          zoo.Add(new Dog(true, "doggy"));
          zoo.Add(new Cat(9, "kitty"));
          zoo.Add(new Student(20, "Hunter"));
          zoo.Add(new Teacher(44, "Stacy Read"));

          foreach (ITalkable blah in zoo) {
            PrintOut(blah); 
          }

          outFile.FileClose();

          inFile = new FileInput("animals.txt");
          inFile.FileRead();
          inFile.FileClose();

          FileInput indata = new FileInput("animals.txt");
          indata.FileRead();
          indata.FileClose();
      }

      public static void PrintOut(ITalkable p)
      {
          Console.WriteLine($"{p.GetName()} says: {p.Talk()}");
          outFile.FileWrite($"{p.GetName()} | {p.Talk()}");
      }
    }
}