using AutoMapper;
using HotelMenu.Models;
using HotelMenu.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMenu
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mappingconfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingconfig;
        }
    }
}
