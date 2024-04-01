using Microsoft.Extensions.Options;
using OpenAI_API.Models;
using OpenAIApp.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace OpenAIApp.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly OpenAIConfig _config;

        public OpenAIService(IOptionsMonitor<OpenAIConfig> optionsMonitor)
        {
            _config = optionsMonitor.CurrentValue;
        }

        public async Task<string> CheckProgrammingLanguage(string language)
        {
            var api = new OpenAI_API.OpenAIAPI(_config.Key);

            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("You are a teacher who help new programmers understand things are programming language or not. " +
                "If the user tells you a programming language, respond with yes, if a user tells you something which is not a programming language," +
                " responsd with no. You wil only respond with yes or no. You don't say anything else.");

            chat.AppendUserInput(language);
            var response = await chat.GetResponseFromChatbotAsync();

            return response;
        }

        public async Task<string> CompleteSentence(string text)
        {
            var api = new OpenAI_API.OpenAIAPI(_config.Key);
            var result = await api.Completions.GetCompletion(text);

            return result;
        }

        public async Task<string> CompleteSentenceAdvance(string text)
        {
            var api = new OpenAI_API.OpenAIAPI(_config.Key);

            var result = await api.Completions.CreateCompletionAsync(
                new OpenAI_API.Completions.CompletionRequest(text, model: Model.CurieText, temperature: 0));

            return result.Completions[0].Text;
        }

        public async Task<string> GetCalories(string food)
        {

            var api = new OpenAI_API.OpenAIAPI(_config.Key);
            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("You are a calorie counter. Provide the calories of the given food per 100 grams. " +
                            "If the user asks for calories of a specific food, respond with the corresponding calorie value per 100 grams. " +
                            "You will only provide calorie values and will not engage in other conversations.");
            chat.AppendUserInput(food);
            var response = await chat.GetResponseFromChatbotAsync();

            return response;

        }
    }
}
