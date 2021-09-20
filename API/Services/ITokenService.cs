using Domain;

namespace API.Services
{
    public interface ITokenService
    {
        string CreateToken(Account account);
    }
}