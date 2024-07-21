using PlataformaAmenazas.API.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureDB(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty; // Set to empty string to serve Swagger UI at the app's root
});

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
