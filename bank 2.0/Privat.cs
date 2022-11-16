namespace bank_2._0
{
    internal class Privat
    {
        string inlogg;
        string pass;

        Random random = new Random();
        public int number1;
        public int number2;


        public List<string> userList = new List<string>();
        public List<string> passList = new List<string>();

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
            Console.WriteLine("1. Se mina bankkonton");
            Console.WriteLine("2. Valuta ");
            Console.WriteLine("3. Logga ut");
            int adminInput = checkNr();
            switch (adminInput)
            {
                case 1:
                    banksaldo();
                    break;
                case 2:
                    valuta();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Tack för idag");
                    break;
                default:
                    break;
            }

        }
        public void banksaldo()
        {
            number1 = random.Next(1111111, 9999999);
            number2 = random.Next(0, 1000000);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Kontonummer : " + number1);
            Console.WriteLine("Banksaldo : " + number2 + " kr");
            Console.WriteLine("------------------------------------------------");

            Thread.Sleep(4000);
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
    }
}
