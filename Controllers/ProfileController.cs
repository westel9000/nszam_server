using ImageWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImageWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        [HttpGet]
        public JsonResult GetProfile()
        {
            return new JsonResult(_profileRepository.Get());
        }
    }
}