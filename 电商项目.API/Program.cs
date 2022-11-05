using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using 电商项目.API.DataBase;
using 电商项目.API.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        _ = builder.Services.AddControllers(setupAction =>
        {
            setupAction.ReturnHttpNotAcceptable = true;
        })
            .AddXmlDataContractSerializerFormatters();

        _ = builder.Services.AddEndpointsApiExplorer();
        _ = builder.Services.AddSwaggerGen();
        _ = builder.Services.AddTransient<ITouristRouteRespository, TouristRouteRespository>();

        _ = builder.Services.AddLogging(loginbuild => 
        {
            _ = loginbuild.AddConsole();
        });

        _ = builder.Services.AddDbContext<AppDBContext>(options =>
        {
            var ConnectionString = builder.Configuration.GetConnectionString("ConnectionString");

            _ = options.UseSqlite(ConnectionString);
        });
        _ = builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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