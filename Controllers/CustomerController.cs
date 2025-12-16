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
    public class CustomerController : ControllerBase
    {
        private readonly IgenericRepository<Customer> customerrepo;
        private readonly IgenericRepository<Movie> moiverepo;
        private readonly IMapper mapper;

        public CustomerController(IgenericRepository<Customer> customerrepo, IgenericRepository<Movie> moiverepo, IMapper mapper)
        {
            this.customerrepo = customerrepo;
            this.moiverepo = moiverepo;
            this.mapper = mapper;
        }



        [HttpPost]

        public async Task<ActionResult> addCustomer(CustomerCreateDto dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = mapper.Map<CustomerCreateDto, Customer>(dto);

            if (dto.Moiveid != null)
            {


                foreach (var id in dto.Moiveid)
                {
                    var spec = new MovieSpec(id);
                    var moive = await moiverepo.getbyid(spec);
                    if (moive != null)
                    {
                        customer.movies.Add(moive);

                    }


                }


            }


            await customerrepo.AddItemd(customer);
            return Ok("customer Added");

        }


        [HttpGet]

        public async Task<ActionResult> getcustomer()
        {


            var spec = new CustomerSpec();
            var customers = await customerrepo.GetAllWithspec(spec);
            var customerdto = mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerReturnDto>>(customers);

            return Ok(customerdto);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult>update(int id ,CustomerCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var spec = new CustomerSpec(id);
            var customer = await customerrepo.getbyid(spec);
            if (customer == null) {

                return NotFound("customer  not found");
            }
            mapper.Map(dto, customer);

            if (dto.Moiveid != null)
            {

                customer.movies = new List<Movie>();

                foreach (var Mid in dto.Moiveid)
                {

                    var Mspec = new MovieSpec(Mid);
                    var moive = await moiverepo.getbyid(Mspec);
                    if (moive != null)
                    {
                        customer.movies.Add(moive);
                    }


                }
            }




            await customerrepo.updateitem(customer);
            return Ok(" done");








        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> delete(int id)
        {
            var spec = new CustomerSpec(id);
            var customer = await customerrepo.getbyid(spec);

            if (customer == null)
            {
                return NotFound("customer not found");

            }

            await customerrepo.DeleteItemd(customer);
            return Ok("Deleted");


        }
    }
}
