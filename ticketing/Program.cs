using System;

namespace ticketing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________________________");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|                       WELCOME                     |");
            Console.WriteLine("|                    Ticketing App                  |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|___________________________________________________|");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| 1.HOME |  2.BOOK | 3.EVENT LIST | 4.BOOKING HOTEL |");
            Console.WriteLine("|___________________________________________________|");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    bookEvents();
                    return true;
                case "3":
                    eventList();
                    return true;
                case "4":
                    bookHotel();
                    return true;
                default:
                    return true;
            }
        }

        private static void bookEvents()
        {
            Console.Write("For how many people : ");
            int size = Convert.ToInt32(Console.In.ReadLine());
            string name, price, cust, phone;
            string[] mhs = new string[size];

            bookEvent e = new bookEvent();

            for (int i = 0; i < mhs.Length; i++)
            {
                Console.Write("Event Name    : ");
                name = Console.ReadLine();

                Console.Write("Event Prive   : ");
                price = Console.ReadLine();

                Console.Write("Cust Name     : ");
                cust = Console.ReadLine();

                Console.Write("Cust Phone    : ");
                phone = Console.ReadLine();

                e.setEvent(name, price, cust, phone);
            }

            e.getEvent();

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        private static void bookHotel()
        {
            Console.Write("For how many people : ");
            int size = Convert.ToInt32(Console.In.ReadLine());
            string name;
            int day, permalam, price;
            string[] mhshotel = new string[size];

            bookHotel e = new bookHotel();

            for (int i = 0; i < mhshotel.Length; i++)
            {
                Console.Write("Costumer Name        : ");
                name = Console.ReadLine();

                Console.Write("For how many days    : ");
                day = int.Parse(Console.ReadLine());

                Console.Write("Price per night      : ");
                permalam = int.Parse(Console.ReadLine());

                price = day * permalam;

                Console.WriteLine("Total Price          : " + price);

                e.setHotel(name, day, permalam, price);
            }

            e.getHotel();

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }


        public static void eventList()
        {
            Console.WriteLine("|---------------|------------|");
            Console.WriteLine("|-----EVENT-----|----HARGA---|");
            Console.WriteLine("|---------------|------------|");
            Event eve = new Event();
            eve.dataevent("");
            Console.WriteLine(eve.getJenisEvent());
            Console.ReadKey();
        }



        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"{message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
