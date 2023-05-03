namespace Examen.WebBlazor.Service.Interface
{
    public interface ILogin
    {
        Task<bool> GetUserAsync(string username, string password);
    }
}
