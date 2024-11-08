using StockMarket.Models;

namespace StockMarket.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
