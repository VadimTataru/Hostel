using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Record
    {
        public Room _room;
        public Guest _guest;
        public DateTime date = DateTime.Now;
        public decimal _cost;
        public string approval = "не смогли снять";

        public Record(Guest guest, Room room, decimal cost)
        {
            if(guest.balance >= cost)
            {
                guest.balance -= cost;
                approval = "сняли";
            }
            _guest = guest;
            _room = room;
            _cost = cost;
        }
    }
}
