using System;
using Xunit;
using System.Linq;
using ManagemenyShopify.WEB.Models;
using ManagemenyShopify.WEB.Services;
using System.Threading.Tasks;

namespace ManagemenyShopify.Test
{
    public class ServiceTest
    {

        [Fact]
        public async void CreateOrderTest()
        {
            Service service = new Service("", "");
            OrderTestModel model = new OrderTestModel();

            var result = await service.CreateOrder(model.OrderModel());
            var check = "";
            var task = new Task(() => check = "Заказ успешно создан");

            Assert.Equal(result, check);
        }


        [Fact]
        public async void RebornOrderTest()
        {
            Service service = new Service("", "");
            OrderTestModel model = new OrderTestModel();

            var result = await service.RebornOrder(model.OrderModel().Id);
            var check = "";
            var task = new Task(() => check = "Воскрешение выполнено");

            Assert.Equal(result, check);
        }

        [Fact]
        public async void UpdateOrderTest()
        {
            Service service = new Service("", "");
            OrderTestModel model = new OrderTestModel();

            var result = await service.UpdateOrder(model.OrderModel().Id, model.OrderModel());
            var check = "";
            var task = new Task(() => check = "Воскрешение выполнено");

            Assert.Equal(result, check);
        }
    }
}
