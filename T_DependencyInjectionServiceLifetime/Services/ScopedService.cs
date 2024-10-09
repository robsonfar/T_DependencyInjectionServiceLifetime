using T_DependencyInjectionServiceLifetime.Services.Interface;

namespace T_DependencyInjectionServiceLifetime.Services
{
    public class ScopedService : IScopedService
    {
        private readonly Guid Value;

        public ScopedService()
        {
            Value = Guid.NewGuid();
        }

        public string GetValue()
        {
            return Value.ToString();
        }
    }
}
