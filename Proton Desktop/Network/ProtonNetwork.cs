using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proton_Desktop.Network
{
    public class NetworkSettings
    {
        public IPAddress IPAddress { get; set; }
        public UInt16 Port { get; set; }
    }

    public class ProtonNetwork
    {
        private readonly Logger _logger;

        private TcpClient _tcpClient;
        private byte[] LastBuffer { get; set; }
        public NetworkSettings NetworkSettings { get; set; }
        public NetworkStream NetworkStream {
            get => _tcpClient.GetStream();
        }

        public ProtonNetwork(NetworkSettings networkSettings)
        {
            this.NetworkSettings = networkSettings;

            this._logger = LogManager.GetCurrentClassLogger();
        }

        public void Disconnect()
        {
            _tcpClient.Client.Disconnect(false);
        }
        public async Task<bool> ConnectAsync()
        {
            if (NetworkSettings.IPAddress == null)
            {
                throw new ArgumentNullException(nameof(NetworkSettings.IPAddress), "Is null or empty");
            }

            try
            {
                _tcpClient = new TcpClient();

                await _tcpClient.ConnectAsync(NetworkSettings.IPAddress, NetworkSettings.Port);

                return true;
            }
            catch (SocketException e)
            {
                this._logger.Info(e, "Не удалось подключиться к серверу");

                return false;
            }
        }
        public async Task<byte[]> ReceiveAsync()
        {
            byte[] buffer = new byte[256];

            using (MemoryStream ms = new MemoryStream())
            {
                do
                {
                    int received = await NetworkStream.ReadAsync(buffer, 0, buffer.Length);

                    ms.Write(buffer, 0, received);

                } while (_tcpClient.Available > 0);

                return ms.ToArray();
            }
        }
        public async Task<bool> SendAsync(byte[] buffer)
        {
            LastBuffer = buffer;

            try
            {
                await NetworkStream.WriteAsync(buffer, 0, buffer.Length);

                return true;
            }
            catch (Exception e)
            {
                this._logger.Info(e, "Пакет с данными не отправлен");

                return false;
            }
        }
    }
}
