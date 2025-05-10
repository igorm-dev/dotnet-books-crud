using ApiLivros.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// ROTA_GET.MapGetRoutes(app);
app.MapGetRoutes();

app.Run();
