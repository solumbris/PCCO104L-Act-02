using System;

class Program {
  public static void Main (string[] args) {
    for (int i = 1; i <= 30; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine($"{i} - FooBar");	
        }
      else if (i % 5 == 0)
        {
          Console.WriteLine($"{i} - Bar");
        }
      else if (i % 3 == 0)
        {
          Console.WriteLine($"{i} - Foo");
        }
      else
        {
          Console.WriteLine(i);
        }
    }
  }
}