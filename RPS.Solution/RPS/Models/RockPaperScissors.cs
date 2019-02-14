using System;

namespace RSP
{
  public class Game
  {
    public bool IsWinner(int input1, int input2)
    {
      int result = (3 + input1 - input2) % 3;
      if(result == 1)
      {
        return true;
      }
      else if(result == 2)
      {
        return false;
      }
      else{
        return false;
      }
    }

    public bool IsDraw(int input1, int input2)
    {
      int result = (3 + input1 - input2) % 3;
      if(result == 1)
      {
        return false;
      }
      else if(result == 2)
      {
        return false;
      }
      else{
        return true;
      }
    }

  }
}
