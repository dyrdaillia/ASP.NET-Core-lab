using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    // Company.cs
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Додайте інші властивості за потребою
    }

    // CompaniesController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private static Company companyInstance = new Company
        {
            Id = 1,
            Name = "Example Company",
            Description = "This is an example company."
            // Ініціалізуйте інші властивості за потребою
        };

        [HttpGet("getCompanyInfo")]
        public IActionResult GetCompanyInfo()
        {
            return Ok(companyInstance);
        }

        [HttpGet("getRandomNumber")]
        public IActionResult GetRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            return Ok(randomNumber);
        }
    }

}
