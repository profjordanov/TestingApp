using AutoMapper;
using TestingApp.Models;
using TestingApp.Models.BindingModels;

namespace TestingApp.Services
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<FirstTestBM, FirstTest>();
            });
        }
    }
}