using System;
using System.Security.Principal;
using System.Threading;

namespace bank_2._0
{
    internal class Privat
    {
        string inlogg;
        string pass;

        Random randomAc = new Random();
        public int number3;

        public List<string> userList = new List<string>();
        public List<string> passList = new List<string>();
        public List<int> bankList = new List<int>();

        public string Pass { get => pass; set => pass = value; }
        public string Inlogg { get => inlogg; set => inlogg = value; }

        public void customerinlog()
        {
            bool check = false;
            int num = 0;
            while (check == false)
            {
                Console.Write("Användarnamn privatperson : ");
                Inlogg = Console.ReadLine();
                Console.Write("Password privatkund : ");
                Pass = Console.ReadLine();
                num++;


                var userfound = userList.Find(i => i.Equals(Inlogg));
                var userfound1 = passList.Find(i => i.Equals(Pass));
                

                if (userfound == Inlogg && userfound1 == Pass)
                {
                    usermeny();

                }
                else if (userfound != Inlogg && userfound1 != Pass)
                {
                    Console.WriteLine("Fel inmatning, försök igen!");
                    Console.Clear();

                }
                if (num < 3)
                {
                    Console.WriteLine("Fel inmatning igen, skärp dig!");
                }
                else if (num == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Nu har du ett försök kvar!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Va fan, jag sa ju till dig!!. Nu loggas du ut!");
                    check = true;
                }


            }

        }
        public void usermeny()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till din användarmenyn");
            Console.WriteLine("1. Skapa nytt bankkonto");
            Console.WriteLine("2. Valuta ");
            Console.WriteLine("3. Se mina bankkonton");
            Console.WriteLine("4. Logga ut");
            int adminInput = checkNr();
            switch (adminInput)
            {
                case 1:
                    addAccount();
                    break;
                case 2:
                    valuta();
                    break;
                case 3:
                    banksaldo();
                    break;
                case 4:
                    valuta();
                    Console.Clear();
                    Console.WriteLine("Tack för idag");
                    break;
                default:
                    break;
            }

        }
        public void banksaldo()
        {
            Random random = new Random();

            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Lista över dina kontonummer");
            Console.WriteLine("-----------------------------------------------");
            foreach (var item1 in bankList)
            {
                
                Console.WriteLine("Kontonummer:"+item1 +",  Banksaldo:" + (random.Next(0, 1000000)) +"kr");
                Console.WriteLine("-----------------------------------------------");
            }
           
            Console.ReadKey();
            usermeny();
           
        }

        public void valuta()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Euro : 10.82 skr\n" +
                              "USD : 10.43 skr\n" +
                              "GBP : 12.41 skr\n" +
                              "NOK : 1.05 skr\n" +
                              "JPY : 7.49 skr");
            Console.WriteLine("----------------------------");

            Thread.Sleep(4000);
            usermeny();

        }

        public int checkNr()
        {
            int nr;
            while (!int.TryParse(Console.ReadLine(), out nr))
            {
                Console.WriteLine("inmatnings fel");
            }

            return nr;
        }
        public void addAccount()
        {
          
            Console.Clear();
            number3 = randomAc.Next(1111111, 9999999);
            try
            {
                Console.WriteLine("Vill du skapa ett nytt bankkonto tryck enter.\nAnnars vänta kvar så skickas du automatsikt tillbaka till huvudmenyn");
                Console.WriteLine("--------------------------------------------");
                Console.ReadKey();
                Console.WriteLine("Ditt nya kontonummer är : " + number3);
                bankList.Add(number3);
                
                Console.ReadKey();
                usermeny();

            }
            catch
            {
                Console.WriteLine("Fel typ av inmatning använd siffror\nTryck enter");
                Console.ReadKey();
            }
            addAccount();
        }
    }
}
