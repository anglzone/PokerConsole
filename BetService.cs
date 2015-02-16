using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerConsole.Models;

namespace PokerConsole
{
    public class BetService :IBetService
    {
        public  NextBet GetNextBet(CurrentStats stats)
        {
            var nextBet = new NextBet();

            nextBet.Selection = GetSelectionBet(stats);
            nextBet.Stake = GetStakeBet(stats);


            return nextBet;
        }

        private decimal GetStakeBet(CurrentStats stats)
        {
            if (stats.PreviousBetResult == BetResult.Lost)
            {
                
            }
            else
            {
                
            }
        }

        private SelectionBet GetSelectionBet(CurrentStats stats)
        {
            throw new NotImplementedException();
        }
    }
}
