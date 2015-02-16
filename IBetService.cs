using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerConsole.Models;

namespace PokerConsole
{
    public interface IBetService
    {
        NextBet GetNextBet(CurrentStats stats);
    }
}
