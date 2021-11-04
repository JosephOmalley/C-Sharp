using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    public class Deck
    {   
        public Deck() // a class constructor for the class Deck
        {   
            Cards = new List<Card>();//constructor makes an empty list cards
            
            for (int i = 0; i < 13; i++ )
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)//this randomizes the order of the card s
        {
            //here is our pre-instatiated int varible "timesShuffled" we assigned a value of 0
            for (int i = 0; i < times; i++)// takes in times parameter and does the shuffle function the amount of times defined in the times varible
            {
                // every time the deck is shuffled/every iteration of the for loop timesShuffled counter is incremented
                List<Card> TempList = new List<Card>();//create empty list which will hold shuffled cards when the method is finished
                Random random = new Random();//creates a new random varible 

                while (Cards.Count > 0)//this loop runs until every card is processed && creates a new random int each time thats in range of the cards yet to be processed
                {
                    int randomIndex = random.Next(0, Cards.Count); //this creates a random int called randomIndex that creates a random number in the range of the amount of cards yet to be processed
                    TempList.Add(Cards[randomIndex]);//picks a random card by using random numbers as its index and adds it to the holder list 
                    Cards.RemoveAt(randomIndex);//removes the card form the previous step so it wont be added again a
                }
                Cards = TempList;//this puts the holder list called temp list back into the deck class's created cards 

            }
            

        }
    }
}
