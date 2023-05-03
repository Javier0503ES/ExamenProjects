using Examen.WebBlazor.Service.Interface;

namespace Examen.WebBlazor.Service
{
    public class LoginService : ILogin
    { 
        public LoginService() {

        }

        public async Task<bool> GetUserAsync(string username, string password)
        {
            return true;
        }
    }
}
