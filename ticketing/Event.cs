using System;
namespace ticketing
{

    class Event
    {
        private string JenisEvent, eventName, eventPrice;

        public void dataevent(string JenisEvent)
        {
            string[,] events = new string[,]{
                {"Seminar Nasional Narkoba" , "50.000" },
                {"Working With MERN Stack" , "450.000" },
                {"Getting Started with GO" , "free" },
                {"Branding and Copywriting" , "70.000" },
                {"Understanding the weid parts of Javascript" , "180.000" },
            };

            for (int i = 0; i <= events.GetUpperBound(0); i++)
            {
                this.eventName = events[i, 0];
                this.eventPrice = events[i, 1];

                Console.WriteLine(" ");
                Console.WriteLine(" _________________________________________");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|             AVAILABLE EVENTS            |");
                Console.WriteLine("|_________________________________________|");
                Console.WriteLine("|                                         ");
                Console.WriteLine("| Event Name  : {0}", eventName);
                Console.WriteLine("| Event Price : {0}", eventPrice);
                Console.WriteLine("|_________________________________________");

            }

            Console.Read();
        }
        public string getJenisEvent()
        {
            return this.JenisEvent;
        }
    }

}