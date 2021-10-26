using System;

namespace MyApplication
{
  class Program
  {
    enum Level
    {
      Low,
      Medium,
      High
    }
    static void Main(string[] args)
    {
      bool ttrue = true;
      string myVar = "1";
      

      while(ttrue){
          

      switch(myVar) 
      {
        case "1":
          Console.WriteLine("Low level");
          myVar = Console.ReadLine();
          break;
        case "2":
          Console.WriteLine("Medium level");
          myVar = Console.ReadLine();
          break;
        case "3":
          Console.WriteLine("High level");
          myVar = Console.ReadLine();
          break;
        default:
            Console.WriteLine("Try Again");
            myVar = Console.ReadLine();

            break;

      } 
      }
    }
  }
}
