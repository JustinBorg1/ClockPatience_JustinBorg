using System;
using ClockPatience_JB;


public class Program
{
    public static void Main(string[] args)
    {
        Deck deck1 = new Deck();
        deck1.Shuffle();

        for (int i = 0; i < 52; i++)
        {
            Console.Write("{0,-19}",deck1.DealCard());
            if ((i + 1) % 4 == 0)
            {
                Console.WriteLine();
            }

        }

    }
}