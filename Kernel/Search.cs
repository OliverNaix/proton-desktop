using Kernel.BindingModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kernel
{
    public static class Search
    {
        public static HttpResponseMessage Response { get; set; }
        public static string Request
        {
            get => "search";
        }

        public async static Task<List<Account>> GetUsersByEmail(SearchBindingModel searchBindngModel)
        {
            Response = await Client.HttpClient.PostAsJsonAsync($"{Request}", searchBindngModel);

            return await Response.Content.ReadAsAsync<List<Account>>();
        }
    }
}
