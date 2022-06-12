using ManagemenyShopify.WEB.Models;
using ShopifySharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagemenyShopify.WEB.Models
{
    public class OrderTestModel
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
                CurrentSubtotalPrice = 1221,
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
                CurrentTotalPrice = 45666,
                CurrentTotalTax = 565656,
                CustomerLocale = "CustomerLocale_TEST",
                DeviceId = 767676767,
                EstimatedTaxes = true,
                UpdatedAt = DateTime.Now,
                TotalTax = 4545545,
                FulfillmentStatus = "test test test",
                LandingSite = "test test test",
                LocationId = 565656,
                Name = "test test test",
                Number = 2232,
                OrderNumber = 44545,
                OrderStatusUrl = "https://test.com/test",
                Phone = "8912345678",
                PresentmentCurrency = "test test test",
                ProcessedAt = DateTime.Now,
                SourceName = "test test test",
                ProcessingMethod = "test test test",
                ReferringSite = "test test test",
                SubtotalPrice = 454545,
                Tags = "test test test",
                TaxesIncluded = true,
                Test = true,
                TotalLineItemsPrice = 454545,
                TotalDiscounts = 454545454,
                TotalOutstanding = "test test test",
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
                  Currency = "test test test",
                  Email = "test@test.ru",
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
                  OrdersCount = 4545,
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
                                Price = 101,
                                AdminGraphQLAPIId = "",
                                FulfillableQuantity = 0,
                                Grams = 250,
                                ProductId = 4809489252600,
                                ProductExists = true,
                                Quantity = 1,
                                RequiresShipping = true,
                                Taxable = true,
                                SKU = "",
                                FulfillmentLineItemId = 3242342,
                                GiftCard = true,
                                TotalDiscount = 567567,
                                VariantId = 345345345435,
                                FulfillmentStatus = "1",
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
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            },
                                            ShopMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            }
                                        }
                                    }
                                },
                                PriceSet = new PriceSet()
                                {
                                    PresentmentMoney = new Price(){
                                        Amount = 23232323,
                                        CurrencyCode = "CurrencyCode_TEST"
                                    },
                                    ShopMoney = new Price(){
                                        Amount = 23232323,
                                        CurrencyCode = "CurrencyCode_TEST"
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
                                        Price = 3434,
                                        Rate = 56456,
                                        Title = "Title_TEST",
                                        PriceSet = new PriceSet()
                                        {
                                             PresentmentMoney = new Price()
                                             {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                             },
                                            ShopMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
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
                                        Amount = 6666666,
                                        CurrencyCode = "CurrencyCode_TEST"
                                    },
                                    ShopMoney = new Price()
                                    {
                                        Amount = 45454,
                                        CurrencyCode = "CurrencyCode_TEST"
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
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            },
                                        ShopMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            }
                                    }
                                }


                            }
                        },
                FinancialStatus = "paid",
                TotalPrice = 5,
                Email = Guid.NewGuid().ToString() + "@example.com",
                Note = "Test note about the customer.",
            };

            return order;
        }
    }
}
