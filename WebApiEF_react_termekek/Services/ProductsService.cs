using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEF_react_termekek.Models;

namespace WebApiEF_react_termekek.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDbContext _context;

        public ProductsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Termekek>> GetAllProductsAsync() => await _context.Termekek.ToListAsync();

        public async Task<Termekek> GetOneProductByIdAsync(int productId)
        {
            var result = await _context.Termekek.Where(p => p.Id == productId).FirstOrDefaultAsync();

            if (result is not null)
            {
                return result;
            }
            return null;
        }

        public async Task<int> AddProductAsync(TermekekVM termekekVM)
        {
            var _product = new Termekek()
            {
                Név = termekekVM.Név,
                Leírás = termekekVM.Leírás,
                Kép = termekekVM.Kép,
                Ár = termekekVM.Ár
            };

            await _context.Termekek.AddAsync(_product);
            return await _context.SaveChangesAsync();
        }
    }
}
