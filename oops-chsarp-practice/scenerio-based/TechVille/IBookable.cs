public interface IBookable
{
    void Register(int citizenId);
    void Register(string citizenName);
    void Register(Citizen citizen);
}
