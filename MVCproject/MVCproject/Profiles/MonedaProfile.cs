using ApiJsonBiblioteca;
using AutoMapper;
using MVCproject.Models;

namespace MVCproject.Profiles
{
    public class MonedaProfile : Profile
    {
        public MonedaProfile()
        {
            CreateMap<MonedaJson, Moneda>();
        }
    }
}
