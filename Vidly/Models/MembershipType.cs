using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        // byte is used because there only a couple of membership types
        public byte Id { get; set; }
        
        // short is for values under 32k
        public short SignupFee { get; set; }

        // byte is used because the largest number will not exceed 12
        public byte DurationInMonths { get; set; }

        // byte is used the DisountRate will represent a % between 0-100
        public byte DiscountRate { get; set; }



    }
}