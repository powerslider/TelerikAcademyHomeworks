using System;
using System.Collections.Generic;

class GSMTest
{
    static void Main()
    {
        GSM nokia = new GSM("N73", "Nokia", "Pesho", 360,
            new Battery("BP-6M", 370, 6, BatteryType.LiIon), new Display(2.4, 243000));

        GSM samsung = new GSM("GalaxyS III", "Samsung", "Gosho", 819,
            new Battery("HR32", 790, 50, BatteryType.LiIon), new Display(4.8, 16000000));

        GSM sonyEricsson = new GSM("Xperia Z", "Sony Ericsson", "Kiro", 864,
            new Battery("PM63", 550, 40, BatteryType.LiIon), new Display(5, 16000000));

        GSM vertu = new GSM("Ascent", "Vertu", "Dimcho", 10400,
            new Battery("RP-M4", 150, 4, BatteryType.LiIon), new Display(0.87, 6));
        

        GSM[] mobilePhones = { nokia, samsung, sonyEricsson, vertu, GSM.IPhone4S };

        foreach (var phone in mobilePhones)
	    {
		    Console.WriteLine(phone);
            Console.WriteLine("------------------------------");
	    }

        Call callOne = new Call("0885131618", 125);
        Call callTwo = new Call("0886933601", 563);
        Call callThree = new Call("0886948266", 256);
            
        vertu.AddCall(callOne);
        vertu.AddCall(callTwo);
        vertu.AddCall(callThree);

        Console.WriteLine("Total price of all calls: {0}", vertu.CalcPriceOfCalls(0.37));

        double maxDuration = 0;
        string number = "";

        foreach (var call in vertu.CallHistory)
        {
            if (maxDuration < call.Duration)
            {
                maxDuration = call.Duration;
                number = call.DialedPhoneNumber;
            }
        }

        Call longestCall = new Call(number, maxDuration);
        
        Console.WriteLine("The longest call lasted {0} seconds and it is made with number {1}.", maxDuration, number);
        vertu.DeleteCall(longestCall);
        Console.WriteLine("Now the longest call is removed from the call history.");
        Console.WriteLine("New total price of all calls: {0}", vertu.CalcPriceOfCalls(0.37));
        vertu.ClearCallHistory();
        Console.WriteLine("Call history is now cleared!!!");
    }
}

