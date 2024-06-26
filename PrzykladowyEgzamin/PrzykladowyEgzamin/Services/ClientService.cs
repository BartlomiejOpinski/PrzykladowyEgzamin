using System.Net;
using Microsoft.EntityFrameworkCore;
using PrzykladowyEgzamin.Context;
using PrzykladowyEgzamin.Models;

namespace PrzykladowyEgzamin.Services;

public class ClientService : IClientService
{
    private readonly BoatsContext _boatsContext;

    public ClientService(BoatsContext boatsContext)
    {
        _boatsContext = boatsContext;
    }

    public IEnumerable<Reservation> GetReservationByClientId(int clientId)
    {
        return _boatsContext.Reservations.Where(r => r.IdClient == clientId).ToList();
    }
}