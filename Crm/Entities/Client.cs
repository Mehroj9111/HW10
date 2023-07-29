namespace Crm.Entities;

public class Client
{
    private string clientId;
    private string name;

    public string ClientId
    {
        get { return clientId; }
        init
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Client ID cannot be null or empty.");

            clientId = value;
        }
    }

    public string Name
    {
        get { return name; }
        init
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be null or empty.");

            name = value;
        }
    }
}
