using Museumify.DAL.Models;

namespace Museumify.BL.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
        bool ValidateToken(string token);
    }
}

