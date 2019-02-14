using System;
using System.Collections.Generic;
using System.Linq;

namespace rpsGame
{
  public class Game {
    // scissors < rock < paper < scissors
    // 1 2 3 1
    public string FindWinner(int input1, int input2)
    {
      int result = (3 + input1 - input2) % 3;
      if(result == 1)
      {
        return "Player 1 wins!";
      }
      else if(result == 2)
      {
        return "Player 2 wins!";
      }
      else{
        return "draw";
      }
    }
  }
}
