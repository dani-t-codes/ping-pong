using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will return all numbers up to the number you provide, in ping-pong format.");
    string yourStringNumber = Console.ReadLine();
    int yourNumberToInt = int.Parse(yourStringNumber);

    List<int> numbersList = new List<int> {};

    for (int i = 0; i <= yourNumberToInt; i++)
    {
      numbersList.Add(i);
    }
    
    Console.WriteLine(numbersList[3]);

  // use a list or array 
  // if (yourNumberToInt % 3)
  // foreach (3 --> ping)

  // if (yourNumberToInt % 5)
  // foreach (5 --> pong)

  // if (yourNumberToInt % 3 && 5)
  // foreach 
  }

}