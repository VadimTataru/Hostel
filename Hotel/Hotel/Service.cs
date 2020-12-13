using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Service
    {
        public Guest _guest;
        public Services _services;
        public Room _room;
        public decimal _cost;
        public DateTime date;
        public string approval = "не смогли заказать";


        public Service(Services services, Guest guest, Room room, decimal cost) 
        {
            if (guest.balance >= cost)
            {
                guest.balance -= cost;
                approval = "заказали";
            }            
            _services = services;
            _guest = guest;
            _room = room;
            _cost = cost;
            date = DateTime.Now;

        }
    }
}
