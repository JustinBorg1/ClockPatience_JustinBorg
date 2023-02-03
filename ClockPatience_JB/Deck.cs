using System;
using ClockPatience_JB;
namespace ClockPatience_JB
{
    public class DeckOfCards
    {
        private const int NCARDS = 52;
        private Card[] deckOfCards;
        private int currentCard;
        private Random randNum;
        public DeckOfCards()
        {
            deckOfCards = new Card[NCARDS];
            int i = 0;
            for (int suit = 1; suit <= 4; suit++)
                for (int rank = 1; rank <= 13; rank++)
                    deckOfCards[i++] = new Card(suit, rank);
            currentCard = 0;
        }

        public void shuffle(int n)
        {
            int i, j;
            randNum = new Random();
            for (int k = 0; k < n; k++)
            {
                i = (int)(randNum.Next(NCARDS));
                j = (int)(randNum.Next(NCARDS));
                Card tmp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[j];
                deckOfCards[j] = tmp;
            }

            currentCard = 0;
        }

        public Card deal()
        {
            if (currentCard < NCARDS)
                return (deckOfCards[currentCard++]);
            else
                return (null);
        }
    }
}

