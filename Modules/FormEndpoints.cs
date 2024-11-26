namespace WebApi.Modules;

public static class FormEndpoints
{
    public static RouteGroupBuilder RegisterFormEndpoints(this RouteGroupBuilder app)
    {

        app.MapGet("/", () => "Hello World");

        app.MapPost("/", () => "Hello World");

        app.MapPut("/{formId}", (int formId) => "Hello World!");

        return app;
    }
}
