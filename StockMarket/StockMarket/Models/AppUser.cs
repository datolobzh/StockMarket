using Microsoft.AspNetCore.Identity;

namespace StockMarket.Models
{
    public class AppUser : IdentityUser
    {
        public List<Portfolio> Potfolios { get; set; } = new List<Portfolio>();
    }
}
