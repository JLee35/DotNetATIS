namespace DotNetATIS.Repositories;

public class PilotEdgeRepository: AtisRepository
{
    public PilotEdgeRepository(HttpClient client) : base(client)
    {
    }
    
    override
    public async Task<string> GetAtis(string icao)
    {
        // Make Http get request to https://www.pilotedge.net/atis/{icao.ToUpperInvariant()}.json;
        var response = await base.Client.GetStringAsync($"https://www.pilotedge.net/atis/{icao.ToUpperInvariant()}.json");
        return response;
    }
}