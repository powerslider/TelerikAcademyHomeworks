using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter unsigned integer: ");
        uint unNum = uint.Parse(Console.ReadLine());

        Console.WriteLine("Input number in decimal format: {0}", Convert.ToString(unNum, 10));
        Console.WriteLine("Input number in binary format: {0}", Convert.ToString(unNum, 2).PadLeft(32, '0'));

        uint bitThree = (unNum & (1 << 3)) >> 3;
        uint bitFour = (unNum & (1 << 4)) >> 4;
        uint bitFive = (unNum & (1 << 5)) >> 5;
        uint bitTwentyFour = (unNum & (1 << 24)) >> 24;
        uint bitTwentyFive = (unNum & (1 << 25)) >> 25;
        uint bitTwentySix = (unNum & (1 << 26)) >> 26;
        uint question;
        uint answer;

        question = ((bitThree == 0) ? (question = unNum & ~((uint)(1 << 24))) : (question = unNum | (1 << 24)));
        answer = question;
        question = ((bitFour == 0) ? (question = answer & ~((uint)(1 << 25))) : (question = answer | (1 << 25)));
        answer = question;
        question = ((bitFive == 0) ? (question = answer & ~((uint)(1 << 26))) : (question = answer | (1 << 26)));
        answer = question;
        question = ((bitTwentyFour == 0) ? (question = answer & ~((uint)(1 << 3))) : (question = answer | (1 << 3)));
        answer = question;
        question = ((bitTwentyFive == 0) ? (question = answer & ~((uint)(1 << 4))) : (question = answer | (1 << 4)));
        answer = question;
        question = ((bitTwentySix == 0) ? (question = answer & ~((uint)(1 << 5))) : (question = answer | (1 << 5)));
        answer = question;

        Console.WriteLine("Output number in binary format: {0}", Convert.ToString(answer, 2).PadLeft(32, '0'));
        Console.WriteLine("Output number in decimal format: {0}", Convert.ToString(answer, 10));
    }
}

