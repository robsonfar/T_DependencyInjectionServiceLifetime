using T_DependencyInjectionServiceLifetime.Services.Interface;

namespace T_DependencyInjectionServiceLifetime.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid Value;

        public SingletonService()
        {
            Value = Guid.NewGuid();
        }

        public string GetValue()
        {
            return Value.ToString();
        }
    }
}
