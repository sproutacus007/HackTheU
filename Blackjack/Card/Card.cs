using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author: Michael Rapley
/// 
/// General card class
/// 
/// Created for Blackjack game
/// 
/// </summary>
namespace Card
{
    public class Card
    {
        // Variables
        private Value value;//Face value
        private Suit suit;//Cards Suit
        private bool flipped;//If card should appear flipped to user

        // Methods

        /// <summary>
        /// Initializes a new card
        /// </summary>
        /// <param name="aValue"></param>
        /// <param name="aSuit"></param>
        public Card(Value aValue, Suit aSuit)
        {
            value = aValue;
            suit = aSuit;
            flipped = true;
        }

        /// <summary>
        /// Sends & gets the face value of the card to the user
        /// </summary>
        public Value FaceValue { get => value;}

        /// <summary>
        /// Sends & gets the Suit value of the card to the user
        /// </summary>
        public Suit SuitValue { get => suit;}

        /// <summary>
        /// Tells user whether or not the card is face up(true)
        /// </summary>
        public bool Flipped { get => flipped;}

        /// <summary>
        /// Returns an integer value for card value
        /// </summary>
        /// <param name="high"></param>
        /// <returns></returns>
        public int GetIntValue(bool high)
        {
            int returnVal;
            switch (value)
            {
                case Value.TWO:
                    returnVal = 2;
                    break;
                case Value.THREE:
                    returnVal = 3;
                    break;
                case Value.FOUR:
                    returnVal = 4;
                    break;
                case Value.FIVE:
                    returnVal = 5;
                    break;
                case Value.SIX:
                    returnVal = 6;
                    break;
                case Value.SEVEN:
                    returnVal = 7;
                    break;
                case Value.EIGHT:
                    returnVal = 8;
                    break;
                case Value.NINE:
                    returnVal = 9;
                    break;
                case Value.TEN:
                    returnVal = 10;
                    break;
                case Value.JACK:
                    returnVal = 10;
                    break;
                case Value.QUEEN:
                    returnVal = 10;
                    break;
                case Value.KING:
                    returnVal = 10;
                    break;
                default:
                    if (high)
                        returnVal = 1;
                    else
                        returnVal = 11;
                    break;
            }

            return returnVal;
        }

        /// <summary>
        /// Flips the card
        /// </summary>
        public void FlipCard()
        {
            if (flipped)
            {
                flipped = false;
            }
            else if (!flipped)
            {
                flipped = true;
            }
        }
    }

    public enum Value
    {
        ACE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }

    public enum Suit
    {
        SPADE,
        CLUB,
        HEART,
        DIAMOND
    }

}
