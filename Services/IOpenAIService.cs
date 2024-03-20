using Microsoft.Extensions.Primitives;

namespace OpenAIApp.Services
{
    public interface IOpenAIService
    {
        Task<string> CompleteSentence(string text);
    }
}
