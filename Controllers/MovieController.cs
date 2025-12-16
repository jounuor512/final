using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolS4.Dto;
using SchoolS4.Generic;
using SchoolS4.Model;
using SchoolS4.Specifications;

namespace SchoolS4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IgenericRepository<Movie> movierepo;
        private readonly IgenericRepository<Hall> hallrepo;
        private readonly IMapper mapper;

        public MovieController(IgenericRepository<Movie>movierepo,IgenericRepository<Hall>hallrepo,IMapper mapper)
        {
            this.movierepo = movierepo;
            this.hallrepo = hallrepo;
            this.mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult> addmoive(MoiveCreateDto dto) {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }


            var spec = new Hallspec(dto.HallId);

            var hall = await hallrepo.getbyid(spec);

            if (hall == null) { 
            return NotFound("hall is not found");
            }

            var movie = mapper.Map<MoiveCreateDto, Movie>(dto);

            await movierepo.AddItemd(movie);
            return Ok("movie added");
        
        
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getmoive(int id)
        {


            var spec = new MovieSpec(id);
            var moive = await movierepo.getbyid(spec);
            if (moive == null)
            {
                return NotFound("Moive not found");
            }

            var moivedto = mapper.Map<Movie, MoiveReturnDto>(moive);
            return Ok(moivedto);


        }

    }
}
