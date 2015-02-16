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
           //Start, set initial Stats
            var currentStats = GetInitialStats();
            
            //get current stats
            currentStats = GetCurrentStats();


            var betService = new BetService();

            //set details for next bet
            var nextBet = betService.GetNextBet(currentStats);
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
