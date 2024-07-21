using Microsoft.EntityFrameworkCore;

namespace PlataformaAmenazas.API.Infraestructure
{
    public static class ServiceExtension
    {
        public static void ConfigureDB(this IServiceCollection services, IConfiguration configuration)
        {
            Console.WriteLine("[ConfigureDB] CONFIGURANDO CONEXION A LA BASE DE DATOS");
            string connectionDB = configuration.GetConnectionString("plataformaConnectionString");
            Console.WriteLine(connectionDB);

            services.AddDbContext<PlataformaContext>(options => options.UseSqlServer(connectionDB));
        }
    }
}
