using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authours;
using TaskAPI.Services.Models;


namespace WebApplication3.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthoursController : ControllerBase
    {
        private readonly IAuthourRepository _service;
        private readonly IMapper _mapper;
        public AuthoursController(IAuthourRepository service, IMapper mapper)
        {
            _service= service;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthourDto>> GetAuthours() { 
            var authours = _service.GetAllAuthours();
            var authoursDto = new List<AuthourDto>();

            var mappedAuthours = _mapper.Map<ICollection<AuthourDto>>(authours);
            return Ok(mappedAuthours);
        }

        [HttpGet("{id}")]  
        public IActionResult GetAuthour(int id)
        {
            var authour = _service.GetAuthour(id);

            if (authour is null)
            {
                return NotFound();
            }

            var mappedAuthour = _mapper.Map<AuthourDto>(authour);
            return Ok(mappedAuthour);
        }
    }
}
