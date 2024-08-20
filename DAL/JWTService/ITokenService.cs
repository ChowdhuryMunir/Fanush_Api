using Fanush.Entities.Administrator;

namespace Fanush.DAL.JWTService
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
