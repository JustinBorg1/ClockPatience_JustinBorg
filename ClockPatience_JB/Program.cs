using System;
using System.Text.RegularExpressions;
using ClockPatience_JB;


public class Program
{
    public static void Main()
    {
        var channels = new int[13];
        channels[0] = 0;    //A
        channels[1] = 0;    //2
        channels[2] = 0;    //3
        channels[3] = 0;    //4
        channels[4] = 0;    //5
        channels[5] = 0;    //6
        channels[6] = 0;    //7
        channels[7] = 0;    //8
        channels[8] = 0;    //9
        channels[9] = 0;    //T
        channels[10] = 0;   //J
        channels[11] = 0;   //Q
        channels[12] = 0;   //K


        DeckOfCards deck;
        deck = new DeckOfCards();
        deck.shuffle(100);


        Console.WriteLine("Choose a specific rank and you will be outputed with the amount of cards that had to be dealt before all of your rank's cards were collected.");


        Console.WriteLine("Enter Desired Rank to Collect:");
        string userInp = Console.ReadLine().ToUpper();


        if (userInp == "A" || userInp == "2" || userInp == "3" || userInp == "4" || userInp == "5" || userInp == "6" || userInp == "7" || userInp == "8" || userInp == "9" || userInp == "T" || userInp == "J" || userInp == "Q" || userInp == "K")
        {

            for (int i = 0; i < 52; i++)
            {

                Card newCard = deck.deal();
                Console.Write(newCard.toString());

                //add space between each card
                Console.Write(" ");

                //move to a new line every 13 cards
                if ((i + 1) % 13 == 0)
                {
                    Console.WriteLine();
                }


                //card counter for each channel
                if (newCard.toString().Contains("A") && channels[0] != 4 && userInp == "A")
                {
                    channels[0]++;
                }
                else if (channels[0] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("A rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("2") && channels[1] != 4 && userInp == "2")
                {
                    channels[1]++;
                }
                else if (channels[1] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("1 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("3") && channels[2] != 4 && userInp == "3")
                {
                    channels[2]++;
                }
                else if (channels[2] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("2 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("4") && channels[3] != 4 && userInp == "4")
                {
                    channels[3]++;
                }
                else if (channels[3] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("4 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("5") && channels[4] != 4 && userInp == "5")
                {
                    channels[4]++;
                }
                else if (channels[4] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("5 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("6") && channels[5] != 4 && userInp == "6")
                {
                    channels[5]++;
                }
                else if (channels[5] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("6 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("7") && channels[6] != 4 && userInp == "7")
                {
                    channels[6]++;
                }
                else if (channels[6] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("7 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("8") && channels[7] != 4 && userInp == "8")
                {
                    channels[7]++;
                }
                else if (channels[7] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("8 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("9") && channels[8] != 4 && userInp == "9")
                {
                    channels[8]++;
                }
                else if (channels[8] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("9 rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("T") && channels[9] != 4 && userInp == "T")
                {
                    channels[9]++;
                }
                else if (channels[9] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("T rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("J") && channels[10] != 4 && userInp == "J")
                {
                    channels[10]++;
                }
                else if (channels[10] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("J rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("Q") && channels[11] != 4 && userInp == "Q")
                {
                    channels[11]++;
                }
                else if (channels[11] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Q rank fully collected after " + i.ToString() + " cards.");
                    break;
                }


                if (newCard.toString().Contains("K") && channels[12] != 4 && userInp == "K")
                {
                    channels[12]++;
                }
                else if (channels[12] == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("K rank fully collected after " + i.ToString() + " cards.");
                    break;
                }

            }

        }
        else
        {
            Console.WriteLine("Incorrect Input");
        }

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