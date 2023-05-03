using System.Text.Json.Serialization;
using System.Text.Json;
using Examen.Entities.DbEntities;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;

namespace Examen.WebBlazor.Data
{
	public static class LoginDbService 
	{

		static HttpClient client = new HttpClient();
		static async Task<Usuario> GetProductAsync(string path)
		{
			Usuario product = null;
			HttpResponseMessage response = await client.GetAsync(path);
			if (response.IsSuccessStatusCode)
			{
				//product = await response.Content. .ReadAsAsync<Usuario>();
			}
			return product;
		}

		public static async Task TestAsync()
		{
			using (HttpClient client = new HttpClient())
			{
				StringContent content = new StringContent(JsonConvert.SerializeObject(new { }), Encoding.UTF8, "application/json");
				string endpoint = "" + "/login";
				using (var Response = await client.PostAsync(endpoint, content))
				{
					if (Response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var x = JsonConvert.SerializeObject(new {});
						
					}
					else
					{
						
					}
				}
			}
		}
	}
}
