using System.Collections.Generic;
using System.Threading.Tasks;

public interface IDestinationService
{
    Task<IEnumerable<Destination>> GetAllDestinations();
    // Add other methods like AddDestination, UpdateDestination, DeleteDestination as needed
}