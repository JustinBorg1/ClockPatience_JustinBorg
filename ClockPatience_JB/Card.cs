using System;
namespace ClockPatience_JB
{
    public class Card
    {

        private string face;
        private string suit;

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return face + suit;
        }
    }
}

