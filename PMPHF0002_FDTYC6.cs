using System;

namespace Pmphf
{
  public class Program
  {
    static void Main()
    {
      int size = int.Parse(Console.ReadLine());
      string character = Console.ReadLine();

      for (int i = 0; i < size; i++)
      {
        if (i == 0 || i == size - 1)
        {
          for (int j = 0; j < size; j++)
          {
            Console.Write(character);
          }
          Console.WriteLine("");
        }
        else
        {
          Console.Write(character);
          for (int j = 0; j < size - 2; j++)
          {
            Console.Write(" ");
          }
          Console.WriteLine(character);
        }
      }
    }
  }
}
