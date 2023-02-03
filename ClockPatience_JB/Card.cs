using System;
using ClockPatience_JB;
namespace ClockPatience_JB
{
    public class Card
    {
        public static readonly String[] Rank = { "*", "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
        private static readonly String[] Suit = { "*", "D", "C", "H", "S" };
        private byte cardSuit;
        private byte cardRank;
        public Card(int suit, int rank)
        {
            if (rank == 1)
                cardRank = 14;
            else
                cardRank = (byte)rank;
            cardSuit = (byte)suit;
        }

        public int suit()
        {
            return (cardSuit);
        }

        public int rank()
        {
            return (cardRank);
        }

        public String toString()
        {
            return (Rank[cardRank] + Suit[cardSuit]);
        }
    }
}

