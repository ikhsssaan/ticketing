using System;
using System.Collections;
using System.Collections.Generic;

namespace ticketing
{
    public class bookHotel
    {

        private string[] hotelList = new string[2];
        private string customerName;
        private int selamaDay, pricePerMalam, totalPrice;

        public void setHotel(string cName, int sDay, int pPerMalam, int tPrice)
        {
            this.customerName = cName;
            this.selamaDay = sDay;
            this.pricePerMalam = pPerMalam;
            this.totalPrice = tPrice;
            // this.eventList[0] = eName;
            // this.eventList[1] = ePrice;
        }

        public void getHotel()
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
            Console.WriteLine("| Cust Name  : {0}", customerName);
            Console.WriteLine("| During     : {0}", selamaDay + " days");
            Console.WriteLine("| Price      : {0}", pricePerMalam);
            Console.WriteLine("| Total      : {0}", totalPrice);
            Console.WriteLine("|_________________________________________");









            // for(int i=0; i<this.eventList.Length; i++){
            //     Console.WriteLine("nama event {0}", eventList[0]);
            //     Console.WriteLine("harga tiket {1}", eventList[1]);
            // }
        }













    }

}