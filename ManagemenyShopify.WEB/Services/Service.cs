using ShopifySharp;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Enums;
using ManagemenyShopify.WEB.Models;
using System.IO;
using Newtonsoft.Json;

namespace ManagemenyShopify.WEB.Services
{
    public class Service
    {
        string _MyShopifyUrl;
        string _accessToken;
        OrderService orderService;

        OrderTestModel testmodel = new OrderTestModel();

        string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB\\");

        public Service(string MyShopifyUrl, string accessToken)
        {
            _MyShopifyUrl = MyShopifyUrl;
            _accessToken = accessToken;
            orderService = new OrderService(_MyShopifyUrl, _accessToken);
#if DEBUG
            jsonPath = @"D:\С# примеры\Работа\Shopify MVC\v1\ManagemenyShopify\DB\";
#endif
            
        }

        public async Task<IEnumerable<Order>> GetOrder(int id)
        {
            try
            {
                var service1 = new CustomerService(_MyShopifyUrl, _accessToken);
                IEnumerable<Order> orders = await service1.ListOrdersForCustomerAsync(Convert.ToInt32(id));
                return orders;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Order> GetOrderById(long? id)
        {
            try
            {
                return await orderService.GetAsync((long)id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> OrdersCount()
        {
            try
            {
                return await orderService.CountAsync();
            }
            catch
            {
                return 0;
            }
        }

        public async Task<string> DeleteOrder(int id)
        {
            try
            {
                await orderService.DeleteAsync(id);
                return "Заказ удален";
            }
            catch
            {
                return "Нет заказа с таким Id";
            }
        }


        private void SerializeOrder(Order order)
        {
            string jsonData = JsonConvert.SerializeObject(order, Newtonsoft.Json.Formatting.None);
            System.IO.File.WriteAllText(jsonPath + order.Id.ToString() + "jsondata.json", jsonData);
        }

        private Order DesirializeOrder(long? id)
        {
            using (StreamReader reader = new StreamReader(jsonPath + id.ToString() + "jsondata.json"))
            {
                Order order = new Order();
                if (reader != null)
                {
                    string text = reader.ReadToEnd();
                    order = JsonConvert.DeserializeObject<Order>(text);                    
                }
                else
                {
                    order = null;
                }
                return order;
            }
        }



        public async Task<string> TestOrder(Order order)
        {
            try
            {
                SerializeOrder(order);
                var getorder = DesirializeOrder(order.Id);
                return "Заказ успешно создан";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }

        public async Task<string> CreateOrder(Order order)
        {
            try
            {
                SerializeOrder(order);
                order = await orderService.CreateAsync(order);    /*закоммичено чтобы не захламлять список левых заказов. Проверено - работает*/

                return "Заказ успешно создан";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }

        public async Task<string> RebornOrder(long? id)
        {
            //входящий параметр id добавлен только для красоты. Будет использоваться потом когда будет реализован поиск по БД
            try
            {
                var GetOrder = DesirializeOrder(id);
                var order = await orderService.CreateAsync(GetOrder);    
                return "Воскрешение выполнено";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }

        public async Task<string> UpdateOrder(long? orderId, Order order)
        {
            try
            {
                var saveorder = await GetOrderById(orderId);
                SerializeOrder(saveorder);  //сохраняем старую версию заказа

                var update = await orderService.UpdateAsync((long)orderId, order);    
                SerializeOrder(update);  //сохраняем новую версию заказа
                return "Обновлени выполнено";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }
    }
}
