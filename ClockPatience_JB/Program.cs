using System;
using System.Text.RegularExpressions;
using ClockPatience_JB;


public class Program
{
    public static void Main()
    {
        int c = 0;
        DeckOfCards deck;
        deck = new DeckOfCards();
        deck.shuffle(100);


        for (int i = 0; i < 52; i++)
        {
            Card newCard = deck.deal();
            Console.WriteLine(newCard.toString());

            if(newCard.toString().Contains("2"))
            {
                c++;
            }
        }
        Console.WriteLine(c);

    }

    public static string PadNumbers(string input)
    {
        return Regex.Replace(input, "[0-9]+", match => match.Value.PadLeft(2, '0'));
    }

    public static int FaceValue(string input)
    {
        return input.Substring(0, 1) == "A" ? 14 : input.Substring(0, 1) == "K" ? 13 : input.Substring(0, 1) == "Q" ? 12 : input.Substring(0, 1) == "J" ? 11 : 0;
    }
}