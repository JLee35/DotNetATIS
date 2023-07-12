namespace DotNetATIS.Repositories;

public interface IAtisRepository
{
    public Task<string> GetAtis(string icao);
}