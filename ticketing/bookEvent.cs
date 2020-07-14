using System;
using System.Collections;
using System.Collections.Generic;

namespace ticketing
{
    public class bookEvent
    {

        private string[] eventList = new string[2];
        private string eventName, eventPrice, customer, customerPhone;

        public void setEvent(string eName, string ePrice, string eCust, string ePhone)
        {
            this.eventName = eName;
            this.eventPrice = ePrice;
            this.customer = eCust;
            this.customerPhone = ePhone;
            // this.eventList[0] = eName;
            // this.eventList[1] = ePrice;
        }

        public void getEvent()
        {
            // Console.WriteLine("Event yang di pesan {0}", eventName);
            // Console.WriteLine("Harga Tiket {0}", eventPrice);
            // Console.WriteLine("Nama Pemesan {0}", customer);
            // Console.WriteLine("Telp Pemesan {0}", customerPhone);

            Console.WriteLine(" ");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|               YOUR TICKET               |");
            Console.WriteLine("|_________________________________________|");
            Console.WriteLine("|                                         ");
            Console.WriteLine("| Event Name  : {0}", eventName);
            Console.WriteLine("| Event Price : {0}", eventPrice);
            Console.WriteLine("| Cust Name   : {0}", customer);
            Console.WriteLine("| Cust Phone  : {0}", customerPhone);
            Console.WriteLine("|_________________________________________");









            // for(int i=0; i<this.eventList.Length; i++){
            //     Console.WriteLine("nama event {0}", eventList[0]);
            //     Console.WriteLine("harga tiket {1}", eventList[1]);
            // }
        }













    }

}