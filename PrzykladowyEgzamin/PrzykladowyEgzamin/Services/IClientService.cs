using PrzykladowyEgzamin.Models;

namespace PrzykladowyEgzamin.Services;

public interface IClientService
{
    public IEnumerable<Reservation> GetReservationByClientId(int clientId);

}