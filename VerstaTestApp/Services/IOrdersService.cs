using VerstaTestApp.Models;

namespace VerstaTestApp.Services
{
	public interface IOrdersService
	{
		void CreateOrder(CreateOrderModel newModel);
		OrderDTO GetOrder(int id);
		IEnumerable<OrderDTO> GetOrders();
	}
}
