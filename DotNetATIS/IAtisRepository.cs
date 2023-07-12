namespace AtisStore.Db;

public interface IAtisRepository
{
    public Atis ? GetAtis(string icao);
}