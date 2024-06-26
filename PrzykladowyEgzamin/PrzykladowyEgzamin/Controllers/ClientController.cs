using Microsoft.AspNetCore.Mvc;
using PrzykladowyEgzamin.Context;
using PrzykladowyEgzamin.Models;

namespace PrzykladowyEgzamin.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{

    private readonly BoatsContext _boatsContext;

    public ClientController(BoatsContext boatsContext)
    {
        _boatsContext = boatsContext;
    }
    
    /*[HttpGet("{idClient}")]
    public async Task<IActionResult> GetClientReservations(Client idClient)
    {
        var result = _
    }*/
}