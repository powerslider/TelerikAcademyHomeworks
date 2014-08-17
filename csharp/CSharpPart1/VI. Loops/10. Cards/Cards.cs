using System;

class Cards
{
    static void Main()
    {
        string[] cards = new string [13] 
        {"Two", "Three", "Four", "Five","Six",
         "Seven", "Eight", "Nine", "Ten", "Jack", 
         "King", "Queen", "Ace"};
        string[] paint = new string [4] 
        { "clubs", "diamonds", "hearts", "spades" };

        for (int i = 1; i < paint.Length; i++)
		{
			for (int j = 1; j < cards.Length; j++)
			{
			    Console.WriteLine("\n{0} of {1}\n", cards[j], paint[i]);
			} 
		}
    }
}

