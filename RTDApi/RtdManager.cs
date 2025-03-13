using RTDTrading;

namespace RTDApi;

public class RtdManager
{
    private readonly IRtdServer _rtdServer;
    private int _serverState;
    private int _nextTopicId = 901;

    public RtdManager(IRtdServer rtdServer, RtdUpdateEvent updateEvent)
    {
        _rtdServer = rtdServer;

        // Start RTD server
        _serverState = _rtdServer.ServerStart(updateEvent);
    }

    public string GetDataPoint(string ticker, string dataType)
    {
        int topicId = _nextTopicId++;
        Array topic = new object[] { ticker, dataType };

        // Get data from RTD server
        dynamic? result = _rtdServer.ConnectData(topicId, topic, false);
        string value = result?.ToString() ?? "Indisponível";

        // Immediately disconnect to free up resources
        _rtdServer.DisconnectData(topicId);

        return value;
    }

    public void Shutdown()
    {
        if (_serverState != 1) return;

        _rtdServer.ServerTerminate();
        _serverState = 0;
    }
}