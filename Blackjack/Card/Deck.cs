using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Card
{
    public class Deck
    {
        //Variables
        private Stack<Card> deck; //ArrayList of cards

        //Public Methods

        /// <summary>
        /// Initializes new deck of cards
        /// </summary>
        /// <param name="shuffle">Whether or not the deck should be shuffled</param>
        public Deck(bool shuffle)
        {
            //Creates a single deck of Cards
            deck = new Stack<Card>();
            CreateDeck(deck);

            if (shuffle)
            {
                ShuffleDeck();
            }
        }


        /// <summary>
        /// Initializes new deck of cards with user specified number of decks
        /// </summary>
        /// <param name="numOfDecks"></param>
        /// <param name="shuffle">Whether or not the deck should be shuffled</param>
        public Deck(int numOfDecks, bool shuffle)
        { //Creates x amount of decks of Cards
            deck = new Stack<Card>();

            for (int x = numOfDecks; x > 0; x--)
            {
                CreateDeck(deck);
            }

            if (shuffle)
            {
                ShuffleDeck();
            }
        }

        /// <summary>
        /// Returns count
        /// </summary>
        public int Count {get; set;}

        /// <summary>
        /// Draws a card from the deck removing it from the deck
        /// </summary>
        /// <returns></returns>
        public Card DrawCard()
        {
            try
            {
                return deck.Pop();
            }
            catch
            {
                throw new IndexOutOfRangeException("No Cards to Left to Draw");
            }
            finally
            {
                Count = deck.Count;
            }
        }

        //Private Methods

        /// <summary>
        /// Shuffles deck
        /// </summary>
        private void ShuffleDeck()
        {
            Random rnd = new Random();
            var values = deck.ToArray();
            deck.Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
                deck.Push(value);
        }

        /// <summary>
        /// Creates a deck
        /// </summary>
        /// <param name="deck"></param>
        private void CreateDeck(Stack<Card> deck)
        {
            foreach (Suit s in Suits())
            {
                foreach (Value v in Values())
                {
                    deck.Push(new Card(v, s));
                }
            }
            Count = deck.Count;
        }

        private IEnumerable<Suit> Suits()
        {
            yield return Suit.CLUB;
            yield return Suit.DIAMOND;
            yield return Suit.SPADE;
            yield return Suit.HEART;
        }

        private IEnumerable<Value> Values()
        {
            yield return Value.ACE;
            yield return Value.TWO;
            yield return Value.THREE;
            yield return Value.FOUR;
            yield return Value.FIVE;
            yield return Value.SIX;
            yield return Value.SEVEN;
            yield return Value.EIGHT;
            yield return Value.NINE;
            yield return Value.TEN;
            yield return Value.JACK;
            yield return Value.QUEEN;
            yield return Value.KING;
        }
    }
}
