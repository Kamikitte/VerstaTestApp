using AutoMapper;
using VerstaTestApp.Data;
using VerstaTestApp.Data.Entities;
using VerstaTestApp.Models;

namespace VerstaTestApp.Services
{
	public class OrdersService : IOrdersService
	{
		private readonly IMapper _mapper;
        private readonly DataContext _context;

        public OrdersService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

		public OrderDTO CreateOrder(CreateOrderModel newModel)
		{
			var order = _mapper.Map<Order>(newModel);
			_context.Orders.Add(order);
			_context.SaveChangesAsync();

			return _mapper.Map<OrderDTO>(order);
		}

		public OrderDTO GetOrder(int id)
		{
			var order = _context.Orders.Find(id);
			return _mapper.Map<OrderDTO>(order);
		}

		public IEnumerable<OrderDTO> GetOrders()
		{
			var huh = _context.Orders;
			return _mapper.Map<IEnumerable<OrderDTO>>(_context.Orders);
		}
	}
}
