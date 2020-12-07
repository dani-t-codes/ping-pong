using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will return all numbers up to the number you provide, in ping-pong format.");
    string yourStringNumber = Console.ReadLine();
    int yourNumberToInt = int.Parse(yourStringNumber);

    List<string> numbersList = new List<string> {};

    for (int i = 0; i <= yourNumberToInt; i++)
    {
      numbersList.Add(i);
    }

    // convert i back to string when adding to list
    // make sure to use "== 0" in if statements
    // add i only if isn't % 3, % 5, or % 3 & 5


  // if (yourNumberToInt % 3)
  // foreach (3 --> "ping")

  // if (yourNumberToInt % 5)
  // foreach (5 --> "pong")

  // if (yourNumberToInt % 3 && 5)
  // foreach (3 && 5 --> "ping-pong")
  }

}