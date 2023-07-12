namespace AtisStore.Db;

public record Atis 
{
    public string ? Description { get; set; }
    public string ? Icao { get; set; }
}

public class LocalRepository: IAtisRepository
{
    private static List<Atis> _atis = new List<Atis>()
    {
        new Atis { Icao = "KJFK", Description = "Test for KJFK" },
        new Atis { Icao = "KGEG", Description = "Test for KGEG" },
        new Atis { Icao = "KSFO", Description = "Test for KSFO" },
    };

    public List<Atis> GetAtis() 
    {
        return _atis;
    } 

    public Atis ? GetAtis(string icao) 
    {
        // Return the first ATIS that matches the ICAO code, ignore case.
        return _atis.SingleOrDefault(atis => atis.Icao == icao.ToUpperInvariant());
    }
}