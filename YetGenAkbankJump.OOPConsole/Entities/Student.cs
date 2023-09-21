using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Student:PersonBase
    {
        public int No { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
