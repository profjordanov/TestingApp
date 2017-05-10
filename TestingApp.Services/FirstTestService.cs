using TestingApp.Models;
using TestingApp.Models.BindingModels;
using AutoMapper;
namespace TestingApp.Services
{
    public class FirstTestService : Service
    {
        public void AddTest(FirstTestBM bind)
        {
            FirstTest test = Mapper.Map<FirstTestBM, FirstTest>(bind);
            this.Context.FirstTests.Add(test);
            this.Context.SaveChanges();
        }
    }
}