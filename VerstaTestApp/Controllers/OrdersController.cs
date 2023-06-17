using Microsoft.AspNetCore.Mvc;
using VerstaTestApp.Models;
using VerstaTestApp.Services;

namespace VerstaTestApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrdersService _ordersService;

		public OrdersController(IOrdersService ordersService)
		{
			_ordersService = ordersService;
		}

		[HttpPost]
		public ActionResult Create(CreateOrderModel newOrder)
		{
			_ordersService.CreateOrder(newOrder);
			return Ok();
		}

		[HttpGet]
		public ActionResult<IEnumerable<OrderDTO>> GetOrders()
		{
			var orders = _ordersService.GetOrders();
			return Ok(orders);
		}

		[HttpGet("{id}")]
		public ActionResult<IEnumerable<OrderDTO>> GetOrder(int id)
		{
			var order = _ordersService.GetOrder(id);
			if (order == null)
			{
				return NotFound();
			}
			return Ok(order);
		}
	}
}
