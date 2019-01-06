using ItemStore.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItemStore.Infrastructure
{
	public class ItemRepository : IItemRepository
	{
		private readonly AppDbContext _context;

		public ItemRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<Item> GetItemById(int id)
		{
			return await _context.Items.SingleOrDefaultAsync(i => i.Id == id);
		}

		public async Task<IEnumerable<Item>> GetAll()
		{
			return await _context.Items.ToListAsync();
		}
	}
}
