using ManagemenyShopify.WEB.Models;
using ShopifySharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagemenyShopify.WEB.Models
{
    public class OrderTestModelOld
    {
        public Order OrderModel()
        {     
            var order = new Order()
            {
                Id = 45454,
                AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                BuyerAcceptsMarketing = true,
                CancelledAt = DateTime.Now,
                ClosedAt = DateTime.Now,
                CurrentSubtotalPrice = 12,
                CreatedAt = DateTime.UtcNow,
                UserId = 1212122121212,
                AppId = 56565656,
                BrowserIp = "192.168.0.0",
                CartToken = "CartToken_TEST",
                CancelReason = "CancelReason_TEST",
                CheckoutId = 5656565656,
                CheckoutToken = "CheckoutToken_TEST",
                Confirmed = true,
                Currency = "USD",
                CurrentTotalDiscounts = 4545454545,
                CurrentTotalPrice = 250,
                CurrentTotalTax = 5,
                CustomerLocale = "CustomerLocale_TEST",
                DeviceId = 767676767,
                EstimatedTaxes = true,
                UpdatedAt = DateTime.Now,
                TotalTax = 4545545,
                //FulfillmentStatus = "1",
                LandingSite = "test test test",
                LocationId = 565656,
                Name = "test test test",
                Number = 2232,
                OrderNumber = 44545,
                OrderStatusUrl = "https://test.com/test",
                Phone = "8912345678",
                PresentmentCurrency = "USD",
                ProcessedAt = DateTime.Now,
                SourceName = "test test test",
                ProcessingMethod = "test test test",
                ReferringSite = "test test test",
                SubtotalPrice = 250,
                Tags = "test test test",
                TaxesIncluded = true,
                Test = true,
                TotalLineItemsPrice = 250,
                TotalDiscounts = 454545454,
                TotalOutstanding = "test test test",
                TotalPriceSet = new PriceSet() { 
                    ShopMoney = new Price() 
                    {
                        Amount = 110,
                        CurrencyCode = "test"
                    },
                    PresentmentMoney = new Price() 
                    {
                        Amount = 110,
                        CurrencyCode = "test"
                    }
                },
                ShippingAddress = new Address()
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
                Customer = new Customer()
                {
                  Id = 45454,
                  AcceptsMarketing = true,
                  AcceptsMarketingUpdatedAt = DateTime.Now,
                  CreatedAt = DateTime.Now,
                  Currency = "USD",
                  Email = "test@example.com",
                  FirstName = "test test test",
                  LastName = "test teset test",
                  LastOrderId = 454545,
                  LastOrderName = "test test test",
                  Note = "test test test",
                  AdminGraphQLAPIId = "test test test",
                  MultipassIdentifier = "tes test test",
                  Phone = "9123456789",
                  State = "test test test",
                  Tags = "test test test",
                  OrdersCount = 3,
                  TaxExempt = true,
                  TotalSpent = 676767,
                  MarketingOptInLevel = "test test test",
                  UpdatedAt = DateTime.Now,
                  VerifiedEmail = true
                },
                BillingAddress = new Address()
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
                                Name = "Test2 Line2 Item2",
                                Title = "Test2 Line2 Item2 Title2",
                                Price = 1100,
                                AdminGraphQLAPIId = "",
                                FulfillableQuantity = 0,
                                Grams = 250,
                                ProductId = 4809489252600,
                                ProductExists = true,
                                Quantity = 1,
                                RequiresShipping = true,
                                Taxable = true,
                                SKU = "",
                                //FulfillmentLineItemId = 1,
                                GiftCard = true,
                                TotalDiscount = 567567,
                                VariantId = 345345345435,
                                //FulfillmentStatus = "1",
                                TipPaymentGatewaySpecified = true,
                                Id = 3453444,
                                TipPaymentGateway = "TipPaymentGateway_TEST",
                                TipPaymentMethod = "TipPaymentMethod_TEST",
                                VariantInventoryManagement = "VariantInventoryManagement_TEST",
                                VariantTitle = "VariantTitle_TEST",
                                Vendor = "Vendor_TEST",
                                DiscountAllocations = new List<DiscountAllocation>()
                                {
                                    new DiscountAllocation()
                                    {
                                        Amount = "Amount_TEST",
                                        DiscountApplicationIndex = 345345345,
                                        AmountSet = new PriceSet()
                                        {
                                            PresentmentMoney = new Price()
                                            {
                                                Amount = 230,
                                                CurrencyCode = "USD"
                                            },
                                            ShopMoney = new Price()
                                            {
                                                Amount = 230,
                                                CurrencyCode = "USD"
                                            }
                                        }
                                    }
                                },
                                PriceSet = new PriceSet()
                                {
                                    PresentmentMoney = new Price(){
                                        Amount = 230,
                                        CurrencyCode = "USD"
                                    },
                                    ShopMoney = new Price(){
                                        Amount = 230,
                                        CurrencyCode = "USD"
                                    }
                                },
                                Properties = new List<LineItemProperty>()
                                {
                                    new LineItemProperty()
                                    {
                                        Name = "Name_TEST",
                                        Value = "Value_TEST",
                                    }
                                },
                                TaxLines = new List<TaxLine>()
                                {
                                    new TaxLine()
                                    {
                                        Price = 13,
                                        Rate = 56456,
                                        Title = "Title_TEST",
                                        PriceSet = new PriceSet()
                                        {
                                             PresentmentMoney = new Price()
                                             {
                                                Amount = 23,
                                                CurrencyCode = "USD"
                                             },
                                            ShopMoney = new Price()
                                            {
                                                Amount = 23,
                                                CurrencyCode = "USD"
                                            }
                                        }
                                    }
                                },
                                OriginLocation = new LineItemOriginLocation()
                                {
                                    Address1 = "123 4th Street",
                                    City = "Minneapolis",
                                    ProvinceCode = "MN",
                                    Zip = "55401",
                                    CountryCode = "US",
                                    Address2 = "Address2_TEST",
                                    AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                                    Name = "Name_TEST"
                                },
                                TotalDiscountSet = new PriceSet()
                                {
                                    PresentmentMoney = new Price()
                                    {
                                        Amount = 66,
                                        CurrencyCode = "USD"
                                    },
                                    ShopMoney = new Price()
                                    {
                                        Amount = 45,
                                        CurrencyCode = "USD"
                                    }
                                },
                                Duties = new List<LineItemDuty>()
                                {
                                    new LineItemDuty()
                                    {
                                        AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                                        CountryCodeOfOrigin = "CountryCodeOfOrigin_TEST",
                                        HarmonizedSystemCode = "HarmonizedSystemCode_TEST",
                                        PresentmentMoney = new Price()
                                            {
                                                Amount = 23,
                                                CurrencyCode = "USD"
                                            },
                                        ShopMoney = new Price()
                                            {
                                                Amount = 23,
                                                CurrencyCode = "USD"
                                            }
                                    }
                                }


                            }
                        },
                FinancialStatus = "paid",
                TotalPrice = 430000,
                Email = "test@example.com",
                Note = "Test note about the customer.",
            };

            return order;
        }
    }
}
