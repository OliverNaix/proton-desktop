using Kernel.BindingModels;
using Kernel.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kernel
{
    public static class Authorization
    {
        public static HttpResponseMessage Response { get; set; }
        public static string Request
        {
            get => "authorization";
        }
        public async static Task<Update> SignIn(LoginBindingModel loginBindingModel)
        {
            Response = await Client.HttpClient.PostAsJsonAsync($"{Request}", loginBindingModel);

            return await Response.Content.ReadAsAsync<Update>();
        }
    }
}
