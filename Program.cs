using MongoCrudApp.Models;
using MongoCrudApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection(nameof(MongoDbSettings)));
builder.Services.AddSingleton<BookService>();

// Add controllers and Swagger/OpenAPI services.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // For minimal APIs
builder.Services.AddSwaggerGen(); // For generating Swagger documentation

// Build the app.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Detailed error pages for development environment.
    app.UseSwagger();                // Enable Swagger in development.
    app.UseSwaggerUI();              // Swagger UI to explore APIs.
}

app.UseHttpsRedirection(); // Middleware for redirecting HTTP to HTTPS.

app.UseAuthorization(); // Middleware for authorization checks.

app.MapControllers(); // Map controllers for MVC/API controllers.

