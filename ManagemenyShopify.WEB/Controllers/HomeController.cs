using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagemenyShopify.WEB.Services;
using ManagemenyShopify.WEB.Models;
using ShopifySharp;
using ManagemenyShopify.WEB.Models;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace ManagemenyShopify.WEB.Controllers
{

    public class HomeController : Controller
    {
        
        Service service = new Service("", "");
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult PostTest([FromBody] string id)
        {
            return Json(id);
        }


        [HttpPost]
        public JsonResult GetOrder([FromBody] string id)    //получить информацию о заказе
        {
            if(service.GetOrder(Convert.ToInt32(id)) != null)
                return Json(service.GetOrder(Convert.ToInt32(id)));
            else
                return Json("Нет данных");            
        }


        [HttpPost]
        public JsonResult OrdersCount()    //получить количество заказов
        {
            return Json(service.OrdersCount());
        }

        [HttpPost]
        public JsonResult GetOrderById(int id)    //получить количество заказов
        {
            return Json(service.GetOrderById(id));
        }

        [HttpPost]
        public JsonResult DeleteOrder(int id)    //получить количество заказов
        {
            return Json(service.GetOrderById(id));
        }



        [HttpPost]
        public JsonResult CreateAddress()    //создаем заказ в shopisy и сохраняем его у себя в json
        {
            var model = new OrderTestModelOld();
            return Json(service.CreateOrder(model.OrderModel()));
        }


        [HttpPost]
        public JsonResult RebornOrder(int id)    //Воскрешаем заказ
        {
            var model = new OrderTestModelOld();
            return Json(service.RebornOrder(id));
        }

        [HttpPost]
        public JsonResult UpdateOrder(int orderId)    //Обновить заказ
        {
            var model = new OrderTestModelOld();
            return Json(service.UpdateOrder(orderId, model.OrderModel()));
        }

    }
}
