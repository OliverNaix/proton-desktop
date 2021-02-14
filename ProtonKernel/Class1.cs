using ProtonKernel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProtonKernel
{
    public static class Client
    {
        private static TcpClient Tcp { get; set; } = new TcpClient();

        public static NetworkStream NetworkStream
        {
            get => Tcp.GetStream();
        }

        public static async Task ConnectAsync(IPEndPoint endPoint) => 
            await Tcp.ConnectAsync(endPoint.Address, endPoint.Port);

        public static async Task WriteAsync(object value)
        {
            var json = JsonSerializer.Serialize(value);

            var data = Encoding.UTF8.GetBytes(json);

            await NetworkStream.WriteAsync(data, 0, data.Length);
        }

        public static async Task<Update> ReadAsync()
        {
            byte[] buffer = new byte[256];

            using (MemoryStream memory = new MemoryStream())
            {
                while (!NetworkStream.DataAvailable)
                    await Task.Delay(50);

                do
                {
                    int received = await NetworkStream.ReadAsync(buffer, 0, 256);

                    await memory.WriteAsync(buffer, 0, received);

                } while (NetworkStream.DataAvailable);

                var update = new Update();

                try
                {
                    update = JsonSerializer.Deserialize<Update>(Encoding.UTF8.GetString(memory.ToArray()));
                }
                catch(Exception e)
                {
                    File.WriteAllText("exceptions-logs.log", e.ToString());
                }

                return update;
            }
        }
    }
    public class Dialogs
    {
        public static async Task<List<Dialog>> GetDialogsAsync()
        {
            var update = new Update()
            {
                Type = "Dialogs-Get"
            };

            await Client.WriteAsync(update); 

            update = await Client.ReadAsync();

            return update.Object as List<Dialog>;
        }
    }
    public static class Registration
    {
        public static async Task<Update> CreateAccountAsync(string passwordHash)
        {
            var update = new Update()
            {
                Type = "Registration",
                Object = passwordHash,
            };

            await Client.WriteAsync(update);

            update = await Client.ReadAsync();

            return update;
        }
    }
    public static class Authorization
    {
        public static async Task<Update> EmailCheckAsync(string email)
        {
            var update = new Update()
            {
                Type = "Auhtorization-Email",
                Object = email,
            };

            await Client.WriteAsync(update);

            update = await Client.ReadAsync();

            return update;
        }

        public static async Task<Update> PasswordCheckAsync(string password)
        {
            var update = new Update()
            {
                Type = "Auhtorization-Password",
                Object = password,
            };

            await Client.WriteAsync(update);

            update = await Client.ReadAsync();

            return update;
        }
    }
    public class Messages
    {
        public static async Task<List<Message>> GetMessagesAsync(Dialog dialog)
        {
            var update = new Update()
            {
                Type = "Messages-Get",
                Object = dialog
            };

            await Client.WriteAsync(update);

            update = await Client.ReadAsync();

            return update.Object as List<Message>;
        }

        public static async Task SendMessageAsync(Message message)
        {
            var update = new Update()
            {
                Type = "Messages-Send",
                Object = message
            };

            await Client.WriteAsync(update);
        }

        public static async Task SendMessageAsync(string text, string to)
        {
            var message = new Message()
            {
                Text = text,
                Time = DateTime.UtcNow.ToString(),
                To = new User()
                {
                    Username = to
                }
            };

            var update = new Update()
            {
                Type = "Messages-Send",
                Object = message,
            };

            await Client.WriteAsync(update);
        }
    }
    public static class Search
    {
        public static async Task<User> User(string username)
        {
            var update = new Update()
            {
                Type = "Search-User",
                Object = new User()
                {
                    Username = username,
                }
            };

            await Client.WriteAsync(update);

            update = await Client.ReadAsync();

            return update.Object as User;
        }

        public static async Task<List<User>> UserList(string username)
        {
            var update = new Update()
            {
                Type = "Search-UserList",
                Object = new User()
                {
                    Username = username,
                }
            };

            await Client.WriteAsync(update);

            update = await Client.ReadAsync();

            return update.Object as List<User>;
        }
    }
}
