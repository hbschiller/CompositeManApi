namespace RTDApi;

public class RtdLifecycleService(RtdManager rtdManager, ILogger<RtdLifecycleService> logger) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Inicializando serviço RTD Manager");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Terminando serviço RTD Manager");
        rtdManager.Shutdown();
        return Task.CompletedTask;
    }
}