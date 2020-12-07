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
      if (i == 0) {
        numbersList.Add(i.ToString());
      } else if (i % 3 == 0 && i % 5 == 0) {
        numbersList.Add("ping-pong");
      } else if (i % 5 == 0) {
        numbersList.Add("pong");
      } else if (i % 3 == 0) {
        numbersList.Add("ping");
      } else {
        numbersList.Add(i.ToString());
      }

      Console.WriteLine(numbersList[i]);
    }
  }
  
}