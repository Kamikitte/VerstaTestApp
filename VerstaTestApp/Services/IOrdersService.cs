using VerstaTestApp.Models;

namespace VerstaTestApp.Services
{
	/// <summary>
	/// Интерфейс с набором методов для работы с моделями заказов.
	/// </summary>
	public interface IOrdersService
	{
		/// <summary>
		/// Сохраняет новый заказ на основании модели создания заказа.
		/// </summary>
		/// <param name="newModel">Модель нового заказа.</param>
		/// <returns>Модель заказа, сохранённая в базе данных.</returns>
		OrderDTO CreateOrder(CreateOrderModel newModel);
		/// <summary>
		/// Получает заказ из базы данных по его id.
		/// </summary>
		/// <param name="id">Идентификатор заказа</param>
		/// <returns>Модель заказа.</returns>
		OrderDTO GetOrder(int id);
		/// <summary>
		/// Получает список всех заказов из базы данных.
		/// </summary>
		/// <returns>Список всех заказов из базы данных.</returns>
		IEnumerable<OrderDTO> GetOrders();
	}
}
