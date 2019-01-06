using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItemStore.Core
{
	public interface IItemRepository
	{
		Task<Item> GetItemById(int id);
		Task<IEnumerable<Item>> GetAll();
	}
}
