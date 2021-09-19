using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;

namespace GithubWebhookCatcher.Controllers
{
    /// <summary>
    /// Controller to accept webhooks from the github service.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class GithubController : ControllerBase
    {
        private readonly ILogger<GithubController> _logger;

        public GithubController(ILogger<GithubController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns if the service is on.
        /// </summary>
        /// <returns>Status of the service.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var healthCheck = new HealthCheckResult(HealthStatus.Healthy);

            return Ok(healthCheck);
        }

        /// <summary>
        /// Accepts github.
        /// </summary>
        /// <param name="body">The body of the webhook.</param>
        /// <returns>Always Ok result.</returns>
        [HttpPost]
        public IActionResult Post([FromBody] JsonElement body)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(body);
            System.Console.WriteLine($"Serialized: {json}");
            return Ok();
        }
    }
}
