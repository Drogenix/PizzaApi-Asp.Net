using Microsoft.AspNetCore.Mvc;
using PizzaApi.Context;
using PizzaApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaApi.Controllers
{
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private PizzaDbContext _dbContext { get; set; }
        private List<Pizza> _list;
        private List<Order> _orders;
        public PizzaController(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
            _list = _dbContext.Pizzas.ToList();
            _orders = _dbContext.Orders.ToList();

        }
        [Route("api/pizza")]
        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            return _list;
        }
        [Route("api/orders")]
        [HttpGet]
        public IEnumerable<Order> Orders()
        {
            return _orders;
        }
        [Route("api/orders/add")]
        [HttpPost]
        public void AddOrder(List<Order> orders)
        {
            int _orderId = _orders.Last().Id + 1;
            for (int i = 0; i < orders.Count; i++)
            {
                orders[i].OrderId = _orderId;
                _dbContext.Orders.Add(orders[i]);
            }

            _dbContext.SaveChanges();
        }
    }
}
