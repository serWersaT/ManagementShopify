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
            var check = "Воскрешение выполнено";

            Assert.Equal(result, check);
        }

        [Fact]
        public async void UpdateOrderTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            OrderTestModelNew model = new OrderTestModelNew();
            int id = -1;

            var result = await service.UpdateOrder(id, model.order());
            var check = "Обновлени выполнено";

           Assert.Equal(result, check);
        }


        [Fact]
        public async void GeneralTest()
        {
            Service service = new Service(MyShopifyUrl, accessToken);
            OrderTestModelNew model = new OrderTestModelNew();
            var check = "Воскрешение выполнено";

            var resultId = await service.CreateOrder(model.order());

            var result = await service.DeleteOrder(Convert.ToInt64(resultId));

            var reborn = await service.RebornOrder(Convert.ToInt64(resultId));

            Assert.Equal(reborn, check);
        }
    }
}
