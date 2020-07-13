using system;
using System.Collections.Generic;

namespace Sphinx
{
  public class Riddles
  {
    // collect three random numbers
    // make sure they're all unique
    // assign a number to each of the riddles
    // display riddles in that order
    public static void RandomIntegers()
    {
      List<int> randInts = new List<int> {};
      for (int i = 0; i < 4; i++)
      {
        if (randInts.Count == 0)
        {
          randInts.Add(Random.Next(1, 4));
        }
        else
        {
          if (randInts[i] == randInts[i - 1])
          {
            continue;
          }
          else
          {
            randInts.Add(Random.Next(1, 4));
          }
        }
      }
    }
  }
}

// > Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };
// >  Dictionary<string, int> cupcakeOrder = new Dictionary<string, int>() { {"vanilla", 12}, {"chocolate", 24}, {"raspberry", 6}, {"caramel apple", 36} };