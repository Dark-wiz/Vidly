using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            //Mapper.CreateMap<Rental, NewRentalDto>();

            //Domain to Dto
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c=>c.Id, opt=>opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            //Mapper.CreateMap<NewRentalDto, Rental>().ForMember(r => r.Id, opt => opt.Ignore());
        }
    }
} 