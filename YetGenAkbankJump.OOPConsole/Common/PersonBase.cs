using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Common
{
    public class PersonBase
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
