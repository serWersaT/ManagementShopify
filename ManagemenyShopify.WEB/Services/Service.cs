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

        OrderTestModelOld testmodel = new OrderTestModelOld();

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
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<string> DeleteOrder(long id)
        {
            try
            {
                var order = await GetOrderById(id);
                await orderService.DeleteAsync(id);                
                SerializeOrder(order);
                return "Заказ удален";
            }
            catch(Exception ex)
            {
                return "Нет заказа с таким Id";
            }
        }


        public void SerializeOrder(Order order)
        {
            string jsonData = JsonConvert.SerializeObject(order, Newtonsoft.Json.Formatting.None);
            System.IO.File.WriteAllText(jsonPath + order.Id.ToString() + "jsondata.json", jsonData);
        }

        private OrderTestModelNew DesirializeOrder(long? id)
        {            
            using (StreamReader reader = new StreamReader(jsonPath + id.ToString() + "jsondata.json"))
            {
                //Order order = new Order();
                OrderTestModelNew order = new OrderTestModelNew();
                if (reader != null)
                {
                    string text = reader.ReadToEnd();
                    order = JsonConvert.DeserializeObject<OrderTestModelNew>(text);                    
                }
                else
                {
                    order = null;
                }
                return order;
            }
        }



        public async Task<string> CreateOrder(Order order)
        {
            try
            {               
                order = await orderService.CreateAsync(order);    /*закоммичено чтобы не захламлять список левых заказов. Проверено - работает*/
                SerializeOrder(order);
                return order.Id.ToString();
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
                var order = await orderService.CreateAsync(GetOrder.order());    
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
