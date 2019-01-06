using ItemStore.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ItemStore.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ItemsController : ControllerBase
	{
		private readonly ItemService _itemService;

		public ItemsController(ItemService itemService)
		{
			_itemService = itemService;
		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await _itemService.GetItemById(id);
			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var result = await _itemService.GetAll();
			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> Post(CreateItem command)
		{
			await _itemService.Create(command);

			return Created(string.Empty, null);
		}
	}
}
