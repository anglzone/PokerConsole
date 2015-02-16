using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerConsole.Models
{
    public class CurrentStats
    {
        public decimal InitialStake { get; set; }
        public decimal PreviousStake { get; set; }
        public int BetNumber { get; set; }
        public BetResult PreviousBetResult { get; set; }
        public SelectionBetType PreviousBetType { get; set; }
        public int CurrentResultStreak { get; set; }
        public SelectionBetName Player { get; set; }

        public BetModeType BetMode { get; set; }
    }
    public enum BetResult
    {
        Won=0,Lost=1,Tied=2
    }
    public enum BetModeType
    {
        Passive=0,Switch=1
    }
}
