using PizzeriaAPI.ApiService;
using PizzeriaAPI.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();
builder.Services.AddAppServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapDefaultEndpoints();
app.MapApiEndpoints();

app.Run();