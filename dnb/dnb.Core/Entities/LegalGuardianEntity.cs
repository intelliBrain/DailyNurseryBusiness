using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnb.Core.Entities
{
    public enum LegalGardianTypeEnum
    {
        Undefined = 0,
        Parent,
        GrandParent,
    }

    public enum AddressTypeEnum
    {
        Undefined = 0,
        Home,
        Business,
    }

    public enum EmailTypeEnum
    {
        PhoneHandy,
        PhoneBusiness,
    }

    public enum PhoneTypeEnum
    {
        General = 1,
        Handy,
        Home,
        Business,
    }

    public class LegalGuardianEntity
    {
        public int Id { get; private set; }
        public LegalGardianTypeEnum Role { get; private set; }
        public string Name { get; private set; }
        public string FirstName { get; private set; }
    }

    public class AddressEntity
    {
        public int Id { get; private set; }
        public AddressTypeEnum AddressType { get; private set; }
        public bool BillingRelated { get; private set; }
        public string Street { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
    }

    public class PhoneInfoEntity
    {
        public int Id { get; private set; }
        public PhoneTypeEnum ContactType { get; private set; }
        public bool Emergency { get; private set; }
        public bool BillingRelated { get; private set; }
        public string Description { get; private set; }
    }

    public class EmailInfoEntity
    {
        public int Id { get; private set; }
        public EmailTypeEnum ContactType { get; private set; }
        public bool Emergency { get; private set; }
        public bool BillingRelated { get; private set; }
        public string Description { get; private set; }
    }
}
