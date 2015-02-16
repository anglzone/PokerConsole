using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerConsole.Models
{
    public class SelectionBet
    {
        public SelectionBetName Name  { get; set; }
        public SelectionBetType Type { get; set; }
       
    }
    public enum SelectionBetType
    {
        Back = 0, Lay = 1
    }
    public enum SelectionBetName
    {
        Player1 = 0, Player2 = 1, Player3 = 2, Player4 = 3
    }
}
