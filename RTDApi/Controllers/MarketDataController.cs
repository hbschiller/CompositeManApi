using Microsoft.AspNetCore.Mvc;

namespace RTDApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarketDataController(RtdManager rtdManager, ILogger<MarketDataController> logger)
    : ControllerBase
{
    [HttpGet("{ticker}/{dataType}")]
    public ActionResult<object> Get(string ticker, string dataType)
    {
        logger.LogInformation($"Requisição para {ticker} - {dataType}");
        string value = rtdManager.GetDataPoint(ticker, dataType);
        return Ok(new { ticker, dataType, value });
    }
}