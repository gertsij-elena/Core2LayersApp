using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core2LayersApp.DAL.Entities;
using Core2LayersApp.Services.DTO;

namespace Core2LayersApp.Services.Services
{
    public class MappingProfile : Profile
    {
        // Add as many of these lines as you need to map your objects
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Product, ProductDTO>();
           
        }
    }
}
