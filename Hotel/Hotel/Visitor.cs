using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Visitor
    {
        public string FIO
        {
            get
            {
                string fio = $"{sorname} {name} {lastname}";
                return fio;
            }
            set
            {
                string[] fio = value.Split();                
                sorname = fio[0];
                name = fio[1];
                lastname = fio[2];

            }
        }
        string name;
        string sorname;
        string lastname;
        public Gender Gender;
    }
}
