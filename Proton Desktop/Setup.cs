using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proton_Desktop
{
    public class ProtonCrypto
    {
        public int RsaLength { get; set; }

        public byte[] RsaPublicKey;

        public byte[] RsaPrivateKey;
        public byte[] AesKey { get; set; }
        public byte[] AesIV { get; set; }
    }
    public class NetworkSettings
    { 
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public bool IsEncryptConnection { get; set; }
        public bool IsRsaEnabled { get; set; }
        public bool IsAesEnabled { get; set; }
        public ProtonCrypto ProtonCrypto { get; set; }
    }
    public class Setup
    {
        public Setup()
        { 
            
        }
        public string Path { get; set; } = "json/network_settings.json";
        public NetworkSettings NetworkSettings { get; set; }
        public void SettingsFromJson(string path)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                NetworkSettings = JsonSerializer.Deserialize<NetworkSettings>(json);
            }
        }

        public void SaveSettingsToJson(string path)
        {
            if (NetworkSettings != null)
            {
                string json = JsonSerializer.Serialize(NetworkSettings);

                File.WriteAllText(path, json);
            }
        }

        
    }
}
