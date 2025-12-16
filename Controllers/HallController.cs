using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolS4.Dto;
using SchoolS4.Generic;
using SchoolS4.Model;

namespace SchoolS4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallController : ControllerBase
    {
        private readonly IgenericRepository<Hall> hallrepo;
        private readonly IMapper mapper;

        public HallController(IgenericRepository<Hall>hallrepo,IMapper mapper)
        {
            this.hallrepo = hallrepo;
            this.mapper = mapper;
        }

        [HttpPost]

        public async Task<ActionResult> addHall(HallCreateDto dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            var Hall = mapper.Map<HallCreateDto, Hall>(dto);

            await hallrepo.AddItemd(Hall);



            return Ok("add hall");
        }

   
    }
}
