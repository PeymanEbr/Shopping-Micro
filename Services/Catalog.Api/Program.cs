var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Add Swagger services
builder.Services.AddEndpointsApiExplorer(); // برای پشتیبانی از endpointها
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Catalog.Api", Version = "v1", Description = "Catalog API" });
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(); //فعالسازی swagger
    app.UseSwaggerUI(); // فعال سازی رابط کاربری swagger ui
}

app.UseAuthorization();

app.MapControllers();

app.Run();
