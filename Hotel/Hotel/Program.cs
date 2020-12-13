using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            room.number = 1;
            Services dinner = new Services()
            {
                name = "Dinner"
            };

            Guest guest = new Guest();
            Console.WriteLine("Введите ФИО: ");
            guest.FIO = Console.ReadLine();
            Console.WriteLine("Введите Ваш первоночальный баланс: ");
            guest.balance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"{guest.FIO} Ваш первоночальный баланс: {guest.balance}");

            Record _record = new Record(guest, room, 600m);

            Service _service = new Service(dinner, guest, room, 200m);

            Console.WriteLine($"Вы {_record.approval} комнату №{room.number} стоимостью {_record._cost}");
            Console.WriteLine($"Вы {_service.approval} услугу {dinner.name} стоимостью {_service._cost}");
            Console.WriteLine($"{guest.FIO} Ваш баланс составляет {guest.balance} {_service.date}");
        }

    }
}
