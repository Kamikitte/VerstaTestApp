using VerstaTestApp.Models;

namespace VerstaTestApp.Services
{
	public interface IOrdersService
	{
		OrderDTO CreateOrder(CreateOrderModel newModel);
		OrderDTO GetOrder(int id);
		IEnumerable<OrderDTO> GetOrders();
	}
}
