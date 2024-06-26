using System.Net;
using System.Linq;
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

    public int AddReservation(int clientId, DateTime dateFrom, DateTime dateTo, int idBoatStandard, int numOfBoats)
    {
        var client = _boatsContext.Clients.Include(c => c.Reservations)
            .FirstOrDefault(c => c.IdClient == clientId);

        if (client == null)
        {
            throw new Exception($"Couldn't find client with Id = {clientId}");
        }

        var activeReservation = client.Reservations.FirstOrDefault(r => r.Fulfilled == null);

        if (activeReservation != null)
        {
            throw new Exception("Client has a pending reservation");
        }

        throw new NotImplementedException();
    }
}