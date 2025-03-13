using RTDTrading;

namespace RTDApi;

public class RtdUpdateEvent : IRTDUpdateEvent
{
    private long Count { get; set; }
    public int HeartbeatInterval { get; set; } = 100;

    public void Disconnect()
    {
        // Do nothing
    }

    public void UpdateNotify()
    {
        Count++;
    }
}