using AutoMapper;
using SchoolS4.Dto;
using SchoolS4.Model;


namespace SchoolS4.Helper
{
    public class Mappingprofile:Profile
    {


        public Mappingprofile()
        {
            //create Hall
            CreateMap<HallCreateDto, Hall>();
            //create movie
            CreateMap<MoiveCreateDto, Movie>();

            //get moive
            CreateMap<Movie, MoiveReturnDto>()
                .ForMember(d => d.Hallname, o => o.MapFrom(s => s.Hall.Name));


            //add cutomer
            CreateMap<ticketCreateDto, Ticket>();
            CreateMap<CustomerCreateDto, Customer>()
                .ForMember(d => d.movies, o => o.Ignore());

            //get all customer

            CreateMap<Ticket, ticketCreateDto>();
            CreateMap<Movie, MoivereturnDtoforcustomer>();
            CreateMap<Customer, CustomerReturnDto>()
                .ForMember(d => d.moviesdto, o => o.MapFrom(s => s.movies));

        }
    }
}
