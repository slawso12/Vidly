using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isSubscribedToNewsletter { get; set; }

        /* MembershipType is used as a navigation type; 
         it allows us to navigate from customer to membershiptype */
        public MembershipType MembershipType { get; set; }

        // this property is treated as a foreign key
        public byte MembershipTypeId { get; set; }

    }
}