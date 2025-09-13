using MinimalApi;

var builder = WebApplication.CreateBuilder(args);

// Chama o Startup para registrar os serviços
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Chama o Configure para mapear os endpoints e middlewares
startup.Configure(app, app.Environment);

app.Run();
