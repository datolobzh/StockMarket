using StockMarket.DTO.Stock;
using StockMarket.Helpers;
using StockMarket.Models;

namespace StockMarket.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExist(int id);
    }
}
