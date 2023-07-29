using Crm.Entities;

namespace Crm.Services;

public sealed class ClientService
{
    public Client CreateClient(
        string clientId,
        string name
    )
    {
        return new()
        {
            ClientId = clientId,
            Name = name
        };
    }
}
   