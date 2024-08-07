using Microsoft.AspNetCore.Mvc;
using PrzykladowyEgzamin.Context;
using PrzykladowyEgzamin.Models;
using PrzykladowyEgzamin.Services;

namespace PrzykladowyEgzamin.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{

    private readonly ClientService _clientService;

    public ClientController(ClientService clientService)
    {
        _clientService = clientService;
    }
    
    [HttpGet("{idClient}/reservations")]
    public async Task<IActionResult> GetReservationByClientId(Client idClient)
    {
        var result = _clientService.GetReservationByClientId(idClient.IdClient);

        result = result.OrderByDescending(r => r.DateTo).ToList();
        
        return Ok(result);
    }
    
    [HttpPost("{idClient}/reservations/create")]
    public async Task<IActionResult> AddReservation(Client idClient, [FromBody] DateTime dateFrom, [FromBody] DateTime dateTo, [FromBody] int idBoatStandard, [FromBody] int numOfBoats)
    {
        throw new NotImplementedException();
    }
    
    
}