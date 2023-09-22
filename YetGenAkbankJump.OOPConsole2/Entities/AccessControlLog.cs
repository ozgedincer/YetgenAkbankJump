using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.OOPConsole2.Common;
using YetGenAkbankJump.OOPConsole2.Enums;

namespace YetGenAkbankJump.OOPConsole2.Entities
{
    public class AccessControlLog : EntityBase<Guid>
    {

        public long PersonId { get; set; }
        public string DeviceSerialNo { get; set; }
        public AccessType AccessType { get; set; }
        public DateTime LogTime { get; set; }


        public static AccessType ConvertStringToAccessType(string accessType)
        {
            switch (accessType)
            {
                case "FP":
                    return AccessType.FingerPrint;

                case "FACE":
                    return AccessType.Face;

                case "CARD":
                    return AccessType.Card;

                default:
                    throw new Exception("CiYuAydi");
            }
        }
    }
}
