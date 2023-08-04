using Microsoft.AspNetCore.Mvc;
using PasswordGeneratorProject;

namespace YourWebAppNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordGeneratorController : ControllerBase
    {
        [HttpGet("GeneratePassword")]
        public IActionResult GeneratePassword(int length, bool includeNumbers, bool includeSpecialChars)
        {
            string generatedPassword = PasswordGenerator.GeneratePassword(length, includeNumbers, includeSpecialChars);
            return Ok(new { password = generatedPassword });
        }
    }
}
