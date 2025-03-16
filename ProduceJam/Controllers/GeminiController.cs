using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Threading.Tasks;

[ApiController]
[Route("gemini")]
public class GeminiController : ControllerBase
{
    //private readonly GeminiService _geminiService;

    //public GeminiController(GeminiService geminiService)
    //{
    //    _geminiService = geminiService;
    //}

    [HttpPost("ask")]
    public async Task<IActionResult> AskGemini()
    {

        return Ok("Unfortunately, Gemini is Not Available at this time. Please try again later.");

    }
}

//public class PromptRequest
//{
//    public string? Prompt { get; set; }
//    public List<string> Items { get; set; }

//    public PromptRequest()
//    {
//        Prompt = "Hey Gemini. Make me a recipe that includes the following ingredients: Tomato, Potato";
//    }