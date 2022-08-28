using Microsoft.EntityFrameworkCore;
using ������Ŀ.API.DataBase;
using ������Ŀ.API.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        _ = builder.Services.AddControllers();
        _ = builder.Services.AddEndpointsApiExplorer();
        _ = builder.Services.AddSwaggerGen();
        _ = builder.Services.AddTransient<ITouristRouteRespository, MockTouristRouteRespository>();
        _ = builder.Services.AddDbContext<AppDBContext>(options =>
        {
            var ConnectionString = builder.Configuration.GetConnectionString("ConnectionString");

            _ = options.UseSqlite(ConnectionString);
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI();
        }

        _ = app.UseHttpsRedirection();

        _ = app.UseAuthorization();

        _ = app.MapControllers();

        app.Run();
    }
}