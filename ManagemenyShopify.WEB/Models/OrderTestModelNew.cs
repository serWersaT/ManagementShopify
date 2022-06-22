using ManagemenyShopify.WEB.Models;
using ShopifySharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagemenyShopify.WEB.Models
{
    public class OrderTestModelNew
    {
        public Order order()
        {
            return new Order()
            {
                CreatedAt = DateTime.UtcNow,
                SubtotalPrice = 0,
                SubtotalPriceSet = new PriceSet() 
                {
                    PresentmentMoney = new Price()
                    {
                        Amount = 21,
                        CurrencyCode = "AUD"
                    },
                    ShopMoney = new Price()
                    {
                        Amount = 21,
                        CurrencyCode = "AUD"
                    }
                },
                TotalTaxSet = new PriceSet() 
                {
                    PresentmentMoney = new Price()
                    {
                        Amount = 0,
                        CurrencyCode = "AUD"
                    },
                    ShopMoney = new Price()
                    {
                        Amount = 0,
                        CurrencyCode = "AUD"
                    }
                },
                TotalDiscountsSet = new PriceSet() 
                {
                    PresentmentMoney = new Price()
                    {
                        Amount = 0,
                        CurrencyCode = "AUD"
                    },
                    ShopMoney = new Price()
                    {
                        Amount = 0,
                        CurrencyCode = "AUD"
                    }
                },
                TotalPriceSet = new PriceSet() 
                {
                    PresentmentMoney = new Price()
                    {
                        Amount = 21,
                        CurrencyCode = "AUD"
                    },
                    ShopMoney = new Price()
                    {
                        Amount = 21,
                        CurrencyCode = "AUD"
                    }
                },
                ShippingAddress = new Address()
                {
                    Phone = "555-555-5555",
                    Address1 = "123 4th Street",
                    Address2 = "123 4th Street",
                    City = "Minneapolis",
                    Country = "United States",
                    CountryName = "United States",
                    Company = "StarCompany",
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Zip = "55416",
                    Province = "Minnesota",
                    ProvinceCode = "MN",
                    CountryCode = "US",
                    Default = true
                },
                BillingAddress = new ShopifyAddress()
                {
                    Address1 = "123 4th Street",
                    City = "Minneapolis",
                    Province = "Minnesota",
                    ProvinceCode = "MN",
                    Zip = "55401",
                    Phone = "555-555-5555",
                    FirstName = "John",
                    LastName = "Doe",
                    Company = "Tomorrow Corporation",
                    Country = "United States",
                    CountryCode = "US",
                    Default = true,
                },
                
                LineItems = new List<LineItem>()
                {                   
                    new LineItem()
                    {                       
                        ProductId = 333222111,
                        Quantity = 3,
                        Price = 21,
                        RequiresShipping = false,
                        Taxable = true,
                        SKU = null,
                        ProductExists = null,
                        VariantTitle = null,                                 
                       PriceSet = new PriceSet()
                       {
                          PresentmentMoney = new Price()
                            {
                                Amount = 7,
                                CurrencyCode= "AUD"
                            },
                            ShopMoney = new Price()
                            {
                                Amount = 7,
                                CurrencyCode= "AUD"
                            }
                       },
                        TotalDiscountSet = new PriceSet()
                        {
                            PresentmentMoney = new Price()
                            {
                                Amount = 21, 
                                CurrencyCode= "AUD"
                            },
                            ShopMoney = new Price()
                            {
                                Amount = 21,
                                CurrencyCode= "AUD"
                            }
                        },
                        Name = "Test Line Item",
                        Title = "Test Line Item Title"
                    }
                },
                FinancialStatus = "paid",
                TotalPrice = 5,
                Email = "Test@example.com",
                //Phone = "555-555-5555",
                Note = "Test note about the customer.",
            };
        }
    }
}

