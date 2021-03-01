using Kernel.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kernel
{
    public static class Messages
    {
        public static HttpResponseMessage Response { get; set; }
        public static string Request
        {
            get => "messages";
        }

        public async static Task<Update> Send(Message message, string token)
        {
            Update update = new Update();

            update.Token = token;

            update.Object = message;

            Response = await Client.HttpClient.PostAsJsonAsync($"{Request}", update);

            return await Response.Content.ReadAsAsync<Update>();
        }
    }
}
