using System;

namespace API.Services
{
    public class LifecycleService : ILifecycleService
    {
        private readonly DateTime date = DateTime.Now;
        public DateTime DataAtual() => date;
    }
}
