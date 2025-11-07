// Create a WebApplication builder with command-line arguments
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register controller services for handling HTTP requests
builder.Services.AddControllers();
// Register OpenAPI/Swagger services for API documentation
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Build the WebApplication instance
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable OpenAPI/Swagger UI only in development environment
    app.MapOpenApi();
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Enable authorization middleware
app.UseAuthorization();

// Map controller endpoints to routes
app.MapControllers();

// Run the application
app.Run();
