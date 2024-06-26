using PrzykladowyEgzamin.Models;

namespace PrzykladowyEgzamin.Services;

public interface IClientService
{
    public IEnumerable<Reservation> GetReservationByClientId(int clientId);

    public int AddReservation(int clientId, DateTime dateFrom, DateTime dateTo, int idBoatStandard, int numOfBoats);
    
    

}