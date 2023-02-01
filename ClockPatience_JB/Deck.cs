using System;
namespace ClockPatience_JB
{
    public class Deck
    {
        private Card[] deck;
        private int CurrentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randNum;


        public Deck()
        {
            string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };

            string[] suits = { "H", "C", "D", "S" };

            deck = new Card[NUMBER_OF_CARDS];

            CurrentCard = 0;
            randNum = new Random();

            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 11], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            CurrentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randNum.Next(NUMBER_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (CurrentCard < deck.Length)
            {
                return deck[CurrentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}

