using System;
using System.Collections.Generic;
using System.Linq;

namespace rpsGame{
  public class Program
  {
    public static void Main()
    {

     Console.WriteLine("====================================");
     Console.WriteLine("ROCK PAPER SCISSORS");
     Console.WriteLine("1 for scissors, 2 for rock, 3 for paper!");
     Console.WriteLine("First player, enter a number: ");
     int player1 =  int.Parse(Console.ReadLine());
     Console.WriteLine("Second player, enter a number: ");
     int player2 =  int.Parse(Console.ReadLine());
     Game newGame = new Game();

     Console.WriteLine(newGame.FindWinner(player1, player2));

     Console.WriteLine("Another game? [y/n]");
     string answer = Console.ReadLine();
     if(answer == "y" || answer == "Y")
     {
       Main();
     }

    }
  }
}

// int scissors = 1;
// int rock = 2;
// int paper = 3;
