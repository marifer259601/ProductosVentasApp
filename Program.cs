var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return """
    PRODUCTOS MÁS VENDIDOS 

    1. Leche  - 150 ventas
    2. Mouse  - 120 ventas
    3. Yogurt - 100 ventas
    """;
});

app.Run();