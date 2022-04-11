using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiEF_react_termekek.Models;

namespace WebApiEF_react_termekek.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Termekek>> GetAllProductsAsync();
        Task<Termekek> GetOneProductByIdAsync(int productId);
        Task<int> AddProductAsync(TermekekVM termekekVM);
    }
}