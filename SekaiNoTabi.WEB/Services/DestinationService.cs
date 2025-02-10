using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

public class DestinationService : IDestinationService
{
    private readonly IMongoCollection<Destination> _destinations;

    public DestinationService(IMongoDatabase database)
    {
        _destinations = database.GetCollection<Destination>("Destinations");
    }

    public async Task<IEnumerable<Destination>> GetAllDestinations()
    {
        return await _destinations.Find(destination => true).ToListAsync();
    }

    // Implement other CRUD operations here
}