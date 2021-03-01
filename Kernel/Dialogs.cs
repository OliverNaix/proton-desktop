using Kernel.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kernel
{
    public static class Dialogs
    {
        public static HttpResponseMessage Response { get; set; }
        public static string Request
        {
            get => "dialogs";
        }

        public async static Task<Update> GetDialogs(string token)
        {
            Response = await Client.HttpClient.PostAsJsonAsync($"{Request}", token);

            return await Response.Content.ReadAsAsync<Update>();
        }
    }
}
