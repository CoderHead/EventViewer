using System;
using System.IO;
using com.WillisWare.EventViewer.Models;
using com.WillisWare.EventViewer.Repository.Interfaces;
using com.WillisWare.EventViewer.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace com.WillisWare.EventViewer.WebApi.Controllers
{
    [Route("")]
    public sealed class EventsController : Controller
    {
        private readonly AppSettings _appSettings;
        private readonly ILogger<EventsController> _logger;
        private readonly IRepository<EventLog> _repository;

        public EventsController(IRepository<EventLog> repository, ILogger<EventsController> logger, IOptionsMonitor<AppSettings> options)
        {
            _appSettings = options.CurrentValue;
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult GetEvents()
        {
            _logger.LogInformation($"Entered {nameof(GetEvents)} at {DateTime.UtcNow}");

            var filePath = $"{_appSettings.LogFilesDirectory}{Path.DirectorySeparatorChar}Events.xml";
            try
            {
                var eventLog = _repository.LoadFromFile(filePath);

                return Ok(eventLog);
            }
            catch (Exception ex)
            {
                var message = $"{nameof(GetEvents)} handled an exception from {nameof(IRepository<EventLog>)} at {DateTime.UtcNow}";
                _logger.LogError(ex, message);

                return StatusCode(500, message);
            }
        }

        [HttpPost]
        [Produces("application/json")]
        public IActionResult QueryEvents([FromBody]object query)
        {
            _logger.LogInformation($"Entered {nameof(QueryEvents)} at {DateTime.UtcNow}");

            return Ok();
        }
    }
}
