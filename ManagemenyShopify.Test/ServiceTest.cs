using System;
using System.Linq;
using Xunit;
using ManagemenyShopify.WEB.Models;
using ManagemenyShopify.WEB.Services;
using System.Threading.Tasks;

namespace ManagemenyShopify.Test
{
    public class ServiceTest
    {
        string MyShopifyUrl = "";
        string accessToken = "";

        [Fact]
        public async void CreateOrderTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            OrderTestModelNew model = new OrderTestModelNew();

            var result = await service.CreateOrder(model.order());
            bool check = (result.Contains("Error")) ? false : true;

            Assert.Equal(check, true);
        }


        [Fact]
        public async void RebornOrderTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            int id = -1;

            var result = await service.RebornOrder(id);
            var check = "¬оскрешение выполнено";

            Assert.Equal(result, check);
        }

        [Fact]
        public async void UpdateOrderTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            OrderTestModelNew model = new OrderTestModelNew();
            int id = -1;

            var result = await service.UpdateOrder(id, model.order());
            var check = "ќбновлени выполнено";

           Assert.Equal(result, check);
        }


        [Fact]
        public async void GeneralTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            OrderTestModelNew model = new OrderTestModelNew();
            var check = "¬оскрешение выполнено";

            var resultId = await service.CreateOrder(model.order());    //создаем новый заказ, получаем его Id и сохран€ем в json
            var result = await service.DeleteOrder(Convert.ToInt64(resultId));  // удал€ем созданный заказ
            var reborn = await service.RebornOrder(Convert.ToInt64(resultId));  // восстанавливаем его

            Assert.Equal(reborn, check);
        }


        [Fact]
        public async void RebornRealTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            var check = "¬оскрешение выполнено";

            var resultId = -1;    //–уками в браузере создаем новый заказ и копируем его Id (не удобно, id одноразовый)
            var result = await service.DeleteOrder(Convert.ToInt64(resultId));  // удал€ем созданный заказ. ¬ метод добавил получение инфы о заказе как имитаци€ обращени€ в Ѕƒ
            var reborn = await service.RebornOrder(Convert.ToInt64(resultId));  // восстанавливаем его

            Assert.Equal(reborn, check);
        }
    }
}
