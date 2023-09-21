using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Teacher:PersonBase //polimorfizm-kalıtım
    {
        public DateTimeOffset RegistrationDate { get; set; }
        public string FullName => $"{FirstName} {LastName}"; //sağ tarafı sola atar diye düşün - get olarak kullandık
        public void SayMyName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
