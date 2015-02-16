using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerConsole.Models;

namespace PokerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var betService = new BetService();
           //Start, set initial Stats
            var currentStats = GetInitialStats();


            if (currentStats.BetNumber > 1)
            {
                //Get Results
                
                //update stats
                currentStats = GetCurrentStats();

                //set details for next bet
                var nextBet = betService.GetNextBet(currentStats);
                
                var placeBet = betService.PlaceBet(nextBet);

            }

        }

        private static CurrentStats GetInitialStats()
        {
            return new CurrentStats
            {
                InitialStake = 5,
                Player =SelectionBetName.Player1
            };
        }

        private static CurrentStats GetCurrentStats()
        {
            return new CurrentStats
            {
                BetNumber = 2,
                PreviousBetResult=BetResult.Lost,
                PreviousBetType =SelectionBetType.Back
            };
        }
    }
}
