namespace bank_2._0
{


    internal class Admin : Privat
    {



        public void inlogg()
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false) 
            {

                Console.Write("Användarnamn Admin : ");
                Inlogg = Console.ReadLine().ToLower();
                Console.Write("Password Admin : ");
                Pass = Console.ReadLine().ToLower();
                num++;
                if (Inlogg == "admin" && Pass == "admin") { admin(); }
                else
                {
                    if (num < 3)
                    {
                        Console.WriteLine("Fel inmatning, försök igen!");
                        gameOver = false;
                        Console.Clear();
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
                        break;

                    }

                }
            }
            nMenu();

        }
        public void admin()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till inloggningen för Admin !!");
            Console.WriteLine("1. Lägga till användare");
            Console.WriteLine("2. Användare ");
            Console.WriteLine("3. Logga ut");
            int adminInput = checkNr();
            if (adminInput == 1) { addUser(); }
            else if (adminInput == 2) { checkUser(); }
            else if (adminInput == 3)
            {
                Console.Clear();
                nMenu();

            }
        }


        public void addUser()
        {
            int total;
            int num = 1;
            Console.Clear();
            try
            {
                Console.Write("Hur många vill du lägga till : ");
                total = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                for (int i = 0; i < total; i++)
                {
                    Console.Write($"Användarnamn {i + 1} : ");
                    string input = Console.ReadLine();
                    if (input.Length < 5)
                    {

                        Console.WriteLine("Minst 5 tecken TACK");
                        Thread.Sleep(5000);
                        addUser();
                    }
                    userList.Add(input);
                }

                Console.WriteLine("-----------------------------------------");
                for (int i = 0; i < total; i++)
                {
                    Console.Write($"PassWord {i + 1} : ");
                    var input = Console.ReadLine();
                    if (input.Length < 5)
                    {
                        Console.WriteLine("Minst 5 tecken TACK");
                        addUser();
                    }
                    passList.Add(input);
                }
                Console.Clear();
                admin();
            }
            catch
            {
                Console.WriteLine("Fel typ av inmatning använd siffror\nTryck enter");
                Console.ReadKey();
            }
            addUser();

        }

        public void checkUser()
        {
            Console.Clear();
            Console.WriteLine("Här kommer alla användare");
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Tryck Enter för att återvända till start");
            Console.ReadKey();
            admin();
        }
        public void nMenu()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Privat");
            Console.WriteLine("3. Logga ut");
            int input = checkNr();
            switch (input)
            {
                case 1:
                    inlogg();
                    break;
                case 2:
                    customerinlog();
                    break;
                case 3:
                    Console.WriteLine("Loggar ut");
                    break;
                default:
                    Console.WriteLine("Fel val av siffra, tryck Enter för att fortsätta");
                    Console.ReadKey();
                    Console.Clear();
                    nMenu();
                    break;
            }

        }

    }
}
