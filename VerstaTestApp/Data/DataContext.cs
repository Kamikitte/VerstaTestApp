using Microsoft.EntityFrameworkCore;
using VerstaTestApp.Data.Entities;

namespace VerstaTestApp.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		public DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>().HasData(
				new Order
				{
					Id = 1,
					SenderCity = "Архангельск",
					SenderAddress = "Комсомольская ул., 96",
					RecipientCity = "Санкт-Петербург",
					RecipientAddress = "Пушкина ул., 124",
					Weight = 0.45,
					TakeDate = new DateTime(2023, 6, 22)
				},
				new Order
				{
					Id= 2,
					SenderCity = "Нижний Новгород",
					SenderAddress = "Пионерская ул., 180",
					RecipientCity = "Краснодар",
					RecipientAddress = "Северная ул., 6",
					Weight = 5.5,
					TakeDate = new DateTime(2023, 9, 3)
				},
				new Order
				{
					Id = 3,
					SenderCity = "Омск",
					SenderAddress = "Фрунзе ул. 67",
					RecipientCity = "Казань",
					RecipientAddress = "Саид-Галеева ул., 203",
					Weight = 3.68,
					TakeDate = new DateTime(2023, 7, 31)
				}
			);
		}		
	}
}
