using System;
using System.Collections.Generic;


namespace Sphinx 
{
  public class Project
  {
    public static void Main()
    {
      bool answer = true;
      string finalAnswer;
      while (answer == true)

//       Console.WriteLine("\n20 random integers from -100 to 100:");
// for (int ctr = 1; ctr <= 20; ctr++)
// {
//    Console.Write("{0,6}", rnd.Next(-100, 101));
//    if (ctr % 5 == 0) Console.WriteLine();
// }
      {
        Console.WriteLine("What is long, brown and sticky?");
        string userResponse1 = Console.ReadLine().ToLower();
        string answer1 = "stick";
        
        if (userResponse1.Contains(answer1))
        {
          Console.WriteLine("Congratulations! Here is your next riddle:");
        }
        else
        {
          Console.WriteLine("The Sphinx ate you!");
          Console.WriteLine("Would you like to restart? (y or n)");
          finalAnswer = Console.ReadLine();

          if(finalAnswer == "n")
          {
            Console.WriteLine("Thank you for playing. You are dead.");
            break;
          }
          else
          {
            Main();
          }
        }
        
        Console.WriteLine("You live in a one story house made entirely of redwood. What color would the stairs be?");
        string userResponse2 = Console.ReadLine().ToLower();
        string answer2 = "no stairs in a one story house.";

        if (userResponse2.Contains(answer2))
        {
          Console.WriteLine("Congratulations! Here is your next riddle:");
        }
        else
        {
          Console.WriteLine("The Sphinx ate you!");
          Console.WriteLine("Would you like to restart? (y or n)");
          finalAnswer = Console.ReadLine();

          if(finalAnswer == "n")
          {
            Console.WriteLine("Thank you for playing. You are dead.");
            break;
          }
          else
          {
            Main();
          }
        }

        Console.WriteLine("When I am filled, I can point the way; When I am empty, nothing moves me. I have two skins, one without and one within. What am I?");
        string userResponse3 = Console.ReadLine().ToLower();
        string answer3 = "glove";

        if (userResponse3.Contains(answer3))
        {
          Console.WriteLine("Congratulations! Here is your next riddle:");
        }
        else
        {
          
          Console.WriteLine("The Sphinx ate you!");
            Console.WriteLine("Would you like to restart? (y or n)");
          finalAnswer = Console.ReadLine();

          if(finalAnswer == "n")
          {
            Console.WriteLine("Thank you for playing. You are dead.");
            break;
          }
          else
          {
            Console.WriteLine("Congrats! You beat the Sphinx!");
            answer = false;
          }
        }
      }
    }
  }
}
