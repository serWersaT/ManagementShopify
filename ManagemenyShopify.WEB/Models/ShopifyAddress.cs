using ShopifySharp;

namespace ManagemenyShopify.WEB.Models
{
    internal class ShopifyAddress : Address
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ProvinceCode { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public bool Default { get; set; }
    }
}