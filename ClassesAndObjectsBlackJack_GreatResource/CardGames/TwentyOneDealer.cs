using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.ClassesAndObjectsBlackJack_GreatResource
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get{ return _hand; } set { _hand = value; } }
        public bool Stay { get; set; }// this is boolean proerty that checks whether or not the dealer want to stay 
        public bool isBusted { get; set; }// and is followed by the is Busted which checks if the dealerbusted 

    }
}
