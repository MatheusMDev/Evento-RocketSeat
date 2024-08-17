using Microsoft.AspNetCore.Mvc;
using RocketseatAuctionAPI.UseCases.Auctions.GetCurrent;

namespace RocketseatAuctionAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
	[HttpGet]
	public IActionResult GetCurrentAuction()
	{ 
		var useCase = new GetCurrentAuctionUseCase();

		var result = useCase.Execute();

		return Ok("Teste");
	}
}
