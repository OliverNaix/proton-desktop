using Kernel.BindingModels;
using Kernel.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Kernel
{
    public class Client
    {
        public static HttpClient HttpClient = new HttpClient();
        public static Uri BaseAddress = new Uri("https://localhost:44395/");
        public static void Init()
        {
            HttpClient.BaseAddress = BaseAddress;
        }
    }
}
