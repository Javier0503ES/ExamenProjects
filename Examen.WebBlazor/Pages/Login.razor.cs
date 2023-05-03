using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen.WebBlazor.Pages
{
    partial class Login 
    {

        public Login()
        {

        }
        protected override async Task OnInitializedAsync()
        {

        }
		//[BindProperty(SupportsGet = true)]
		public string UserName;
		public string Password;
		private async Task Aceptar()
		{
			if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
			{
				await sLogin.GetUserAsync("", "");
			}
		}

	}
}
