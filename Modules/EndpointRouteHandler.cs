namespace WebApi.Modules;

public static class EndpointRouteHandler
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MapGroup("/form").RegisterFormEndpoints();
        return app;
    }
}
