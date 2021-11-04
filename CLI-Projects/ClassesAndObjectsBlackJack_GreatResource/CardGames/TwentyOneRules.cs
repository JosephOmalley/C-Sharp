using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.ClassesAndObjectsBlackJack_GreatResource
{

    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //use of a private class 
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//lambda that checks how many aces the hand has
            int[] result = new int[aceCount + 1];//since there is 3 possible out comes we declare the size of this int array as result 
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;//checks if you have more than one ace
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;// assigns value of 10 to each result
            }
            return result;
        }
        public static bool CheckforBlackJack(List<Card> Hand)//checks if the hand of the player has blackjack 
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);//gets all possible values from the method in this class 
            int value = possibleValues.Max();//Sets the max value of possibleValues to the int value 
            if (value == 21) return true;// 
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();//this compares to see of the value is over 21 to see if busted 
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)//this allows the dealer to decide if they should stay 
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);//gets result for player and dealer Results -
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);//from GetAllPossibleHandValues 

            int playerScore = playerResults.Where(x => x < 22).Max();//
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
