using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    public class Player
    {
        public Player(string name, int beginningBalence)//Player class constructor with 2 required parameters
        {
            Hand = new List<Card>();
            Balance = beginningBalence;
            Name = name;

        }
        private List<Card>  _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)//a method that checks if the user has that much money to bet 
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }

        }
        public static Game operator +(Game game, Player player)// overloaded The + operator to add the player object to a list of players
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)//Another overloaded operator that removes a player object 
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
