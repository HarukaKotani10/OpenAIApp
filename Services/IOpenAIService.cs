using Microsoft.Extensions.Primitives;

namespace OpenAIApp.Services
{
    public interface IOpenAIService
    {
        Task<string> CompleteSentence(string text);
        Task<string> CompleteSentenceAdvance(string text);
        Task<string> CheckProgrammingLanguage(string language);
        Task<string> GetCalories(string food);
    }
}
