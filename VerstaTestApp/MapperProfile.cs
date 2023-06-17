using AutoMapper;
using VerstaTestApp.Data.Entities;
using VerstaTestApp.Models;

namespace VerstaTestApp
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<CreateOrderModel, Order>()
				.ForMember(d => d.TakeDate, m => m.MapFrom(s => s.TakeDate.UtcDateTime));

			CreateMap<Order, OrderDTO>();
		}
	}
}
