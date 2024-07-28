namespace PizzeriaAPI.ApiService;

public static class ApiEndpoints
{
    public static WebApplication MapApiEndpoints(this WebApplication app)
    {
        app.MapGet("/menu", ApiHandlers.GetMenu);

        return app;
    }
}