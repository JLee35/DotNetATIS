namespace DotNetATIS.Repositories;

public abstract class AtisRepository : IAtisRepository
{
    protected HttpClient Client { get; }
    
    protected AtisRepository(HttpClient client)
    {
        Client = client;
    }
    
    public abstract Task<string> GetAtis(string icao);
}