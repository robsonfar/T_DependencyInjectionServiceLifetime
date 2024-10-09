using T_DependencyInjectionServiceLifetime.Services.Interface;

namespace T_DependencyInjectionServiceLifetime.Services
{
    public class TransientService : ITransientService
    {
        private readonly Guid Value;

        public TransientService()
        {
            Value = Guid.NewGuid();
        }

        public string GetValue()
        {
            return Value.ToString();
        }
    }
}
