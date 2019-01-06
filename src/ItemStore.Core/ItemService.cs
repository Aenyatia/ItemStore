using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemStore.Core
{
	public class ItemService
	{
		private readonly IItemRepository _itemRepository;

		public ItemService(IItemRepository itemRepository)
		{
			_itemRepository = itemRepository;
		}

		public async Task<ItemDto> GetItemById(int id)
		{
			var item = await _itemRepository.GetItemById(id);
			return new ItemDto
			{
				Id = item.Id,
				Name = item.Name
			};
		}

		public async Task<IEnumerable<ItemDto>> GetAll()
		{
			var items = await _itemRepository.GetAll();
			return items.Select(i => new ItemDto
			{
				Id = i.Id,
				Name = i.Name
			});
		}

		public async Task Create(CreateItem command)
		{
			var item = new Item { Name = command.Name };
			await _itemRepository.Add(item);
		}
	}
}
