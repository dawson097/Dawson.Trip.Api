var builder = WebApplication.CreateBuilder(args);

// Add web controller support
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();