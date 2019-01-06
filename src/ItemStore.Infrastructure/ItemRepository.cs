using ItemStore.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItemStore.Infrastructure
{
	public class ItemRepository : IItemRepository
	{
		private readonly AppDbContext _context;
		private static int Index = 10;

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

		public async Task Add(Item item)
		{
			item.Id = Index++;
			await _context.Items.AddAsync(item);
			await _context.SaveChangesAsync();
		}
	}
}
