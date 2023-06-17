using Microsoft.EntityFrameworkCore;
using VerstaTestApp.Data;
using VerstaTestApp.Services;

namespace VerstaTestApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			//В рамках тестового задания была использована виртуальная БД в памяти
			builder.Services.AddDbContext<DataContext>
				(o => o.UseInMemoryDatabase("VerstaDB"));

			builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

			builder.Services.AddScoped<IOrdersService, OrdersService>();


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}