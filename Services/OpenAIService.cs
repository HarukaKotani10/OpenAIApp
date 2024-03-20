using Microsoft.Extensions.Options;
using OpenAIApp.Configuration;

namespace OpenAIApp.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly OpenAIConfig _config;

        public OpenAIService(IOptionsMonitor<OpenAIConfig> optionsMonitor)
        {
            _config = optionsMonitor.CurrentValue;
        }
        public async Task<string> CompleteSentence(string text)
        {
            var api = new OpenAI_API.OpenAIAPI(_config.Key);
            var result = await api.Completions.GetCompletion(text);
            return result;
        }
    }
}
