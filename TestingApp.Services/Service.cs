using TestingApp.Data;

namespace TestingApp.Services
{
    public class Service
    {
        protected TestingAppContext Context;

        public Service()
        {
            this.Context = new TestingAppContext();
        }
    }
}