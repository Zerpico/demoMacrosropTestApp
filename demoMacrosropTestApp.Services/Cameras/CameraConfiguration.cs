using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;
using demoMacrosropTestApp.Common;
using Flurl;

namespace demoMacrosropTestApp.Services.Cameras
{
    public class CameraConfiguration : ICameraConfiguration
    {
        private HttpClient client;
        private string baseUrl = @"http://demo.macroscop.com:8080";
        public CameraConfiguration()
        {
            client = CreateHttpClient();
        }

        public async Task<IEnumerable<Camera>> GetConfigurationAsync()
        {
            var response = await client.GetAsync(Url.Combine(baseUrl,"/configex?login=root"));
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsByteArrayAsync();               
                using (var stream = new MemoryStream(content))
                {
                    var serializer = new XmlSerializer(typeof(Configuration));
                    var deliciousSuggest = (Configuration)serializer.Deserialize(stream);
                    IEnumerable<ServerInfo> servers = deliciousSuggest.Servers.Select(d => new ServerInfo()
                    {
                        Id = Guid.Parse(d.Id),
                        Name = d.Name,
                        PrimaryIp = d.PrimaryIp,
                        PrimaryPort = (short)d.PrimaryPort,
                        PrimarySslPort = (short)d.PrimarySslPort,
                        SecondaryIp = d.SecondaryIp,
                        SecondaryPort = d.SecondaryPort,
                        SecondarySslPort = d.SecondarySslPort,
                        Url = d.Url
                    });
                    var answer = deliciousSuggest.Channels.Select(d => new Camera()
                    {
                        Id = Guid.Parse(d.Id),
                        Name = d.Name,                       
                        Description = d.Description,
                        DeviceInfo = d.DeviceInfo,
                        IsDisabled = d.IsDisabled,
                        IsSoundOn = d.IsSoundOn,
                        AllowedRealtime = d.AllowedRealtime,
                        IsArchivingEnabled = d.IsArchivingEnabled,
                        Server = servers.FirstOrDefault(s => s.Id == Guid.Parse(d.AttachedToServer))
                    });
                    return await Task.FromResult(answer);
                }
            }
            throw new NullReferenceException();
        }

        #region Http
        private HttpClient CreateHttpClient()
        {
            var proxy = new System.Net.WebProxy
            {
                BypassProxyOnLocal = true,
                UseDefaultCredentials = true
            };
           
            var httpClientHandler = new HttpClientHandler
            {
                Proxy = proxy,
            };

            return new HttpClient(handler: httpClientHandler, disposeHandler: true) { Timeout = TimeSpan.FromSeconds(5) };
        }
        #endregion
    }
}
