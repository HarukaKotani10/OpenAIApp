using Microsoft.AspNetCore.Mvc;
using OpenAIApp.Services;
using System.Xml.Linq;

namespace OpenAIApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenAIController : ControllerBase
    {
        private readonly ILogger<OpenAIController> _logger;
        private readonly IOpenAIService _openAIService;

        public OpenAIController(ILogger<OpenAIController> logger, IOpenAIService openAIService)
        {
            _logger = logger;
            _openAIService = openAIService;
        }

        [HttpPost()]
        [Route("CompleteSentence")]
        public async Task<IActionResult> CompleteSentence(string text)
        {
            var result = await _openAIService.CompleteSentenceAdvance(text);
            return Ok(result);
        }


        [HttpPost()]
        [Route("AskQuestion")]
        public async Task<IActionResult> AskQuestion(string text)
        {
            var result = await _openAIService.CheckProgrammingLanguage(text);
            return Ok(result);
        }
    }
}
