using Catalogo.WebAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<APICatalogoContext>(options =>
                options.UseSqlServer(mySqlConnection)
            );


            var app = builder.Build();

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
