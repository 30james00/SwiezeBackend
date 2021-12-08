using System.Threading.Tasks;
using Stripe;

namespace Application.Interfaces
{
    public interface IPaymentsAccessor
    {
        Task<string> Pay(int value);
    }
}