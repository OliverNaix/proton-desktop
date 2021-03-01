using Kernel.BindingModels;
using Kernel.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kernel
{
    public static class Registration
    {
        public static HttpResponseMessage Response { get; set; }
        public static string Request
        {
            get => "registration";
        }

        public async static Task<Update> SignUp(RegisterBindingModel registrBindingModel)
        {
            Response = await Client.HttpClient.PostAsJsonAsync($"{Request}", registrBindingModel);

            return await Response.Content.ReadAsAsync<Update>();
        }
    }
}
