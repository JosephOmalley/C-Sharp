using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGames.Interfaces;

namespace CardGames.ClassesAndObjectsBlackJack_GreatResource
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()// this plays one hand of twenty one 
        {
            Dealer = new TwentyOneDealer();// method Play is called from the while loop in the main method which calls class constructor TwentyOneDealer creating a new dealer 
            foreach (Player player in Players)// does the follow for every player in the list
            {
                player.Hand = new List<Card>();//intializes player's hand with a new deck of cards
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();//intializes dealer's hand with a list of cards 
           
            Dealer.Stay = false;// sets dealers 
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            
            
            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only no decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security kick this person out!");
                }
                
                bool successfullyBet = player.Bet(bet);//This passes the attempted bet to the Bet method in player
                if (!successfullyBet)
                {
                    return;//returns out of the play method 
                }
                Bets[player] = bet;//each iteration of the ask for a bet number every iteration bets int array gets a value. 
            }
                
            
            
            for (int i = 0; i < 2; i++)    
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)//preforms the following actions for every player in the player list 
                {
                    Console.Write("{0}: ", player.Name); //the following wont be on new line
                    Dealer.Deal(player.Hand);//in the dealer class use Deal method with the argument player.Hand(Which is the hand value for each player in the list)
                    if (i == 1)//If it's the 2nd deal it signals to check for black jack
                    {
                        bool blackJack = TwentyOneRules.CheckforBlackJack(player.Hand);// routes program to twentyonerules class and uses checkforblackjack method to see if the boolean is true
                        if (blackJack)//checks for black jack is true
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);//if blackjack
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);//adds players bet * 1.5 to their balence
                            Bets.Remove(player);//removes the players current bet from the Bets dictionary 
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);// calls Dealer classes Deal method and passes in the dealers hand
                if (i == 1)//If it the 2nd deal it signals to check for black jack
                {
                    bool blackJack = TwentyOneRules.CheckforBlackJack(Dealer.Hand);
                    if (blackJack)//Checks if dealer has blackjack 
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;// dealer gets all bets if he get blackjack 
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)//while player is not staying 
                {
                    Console.WriteLine("Your cards are: ");//list current cards 
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());//List current iterations cards 
                    }
                    Console.WriteLine("\n\nHit or Stay");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")//if players answer is stay 
                    {
                        player.Stay = true;//if true skips deal method 
                        break; 
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);//calls deal method to give player another card 
                    }

                    bool busted = TwentyOneRules.IsBusted(player.Hand);//checks if player busted 
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balence is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play agian!");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;//restartes game 
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;//Exits app 
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);//uses is busted method to make sure that dealer isn't busted 
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//adds logic to dealers hit or stay choice
            while (!Dealer.Stay && !Dealer.isBusted)//runs loop as long as dealers is not busted or staying 
            {
                Console.WriteLine("Dealer is hitting...");//following gives dealer their card and checks again for a bust or stay 
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)//tells console is dealer is staying 
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)//tells console if dealer busted 
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);//tells console who won and gives them their winnings 
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true) 
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
          
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
