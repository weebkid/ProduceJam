using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class GeminiService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public GeminiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["Gemini:ApiKey"]; // Store API key in appsettings.json
    }

    public async Task<string> GetGeminiResponse(string prompt)
    {
        var requestBody = new
        {
            messages = new[] { new { role = "user", content = prompt } }
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=${_apiKey}",
            requestBody);

        if (!response.IsSuccessStatusCode)
        {
            return $"Error: {response.StatusCode}";
        }

        var result = await response.Content.ReadFromJsonAsync<GeminiResponse>();
        return result?.candidates?[0]?.content ?? "No response";
    }
}

public class GeminiResponse
{
    public Candidate[] candidates { get; set; }
}

public class Candidate
{
    public string content { get; set; }
}