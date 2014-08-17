using System;

    class PrintBankAccount
    {
        static void Main()
        {
            string firstName = "Tsvetan";
            string middleName = "Todorov";
            string lastName = "Dimitrov";
            decimal balance = 10256.98m;
            string bankName = "Postbank";
            string IBAN = "BG60BPBI18956708275015";
            string BIC = "BPBIBGSF";
            long creditCardNo1 = 4790840501584764;
            long creditCardNo2 = 4856965423517569;
            long creditCardNo3 = 4785632984512358;

            Console.WriteLine("Client: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Balance: {0}$", balance);
            Console.WriteLine("Bank Name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("BIC: {0}", BIC);
            Console.WriteLine("Credit Card Numbers: {0}", creditCardNo1);  // aligning the second and the third credit card number 
            Console.WriteLine("{0,37}", creditCardNo2);                    // to be printed right under the first using an alignment 
            Console.WriteLine("{0,37}\n", creditCardNo3);                  //string component in the placeholder
                                                            
        }
    }

