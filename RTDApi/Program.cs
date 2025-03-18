using RTDTrading;

namespace RTDApi;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        // Register Services
        builder.Services.AddSingleton<IRtdServer>(_ => new RtdServer());
        builder.Services.AddSingleton<RtdUpdateEvent>();
        builder.Services.AddSingleton<RtdManager>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHostedService<RtdLifecycleService>();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapControllers();
        app.Run();
    }
}