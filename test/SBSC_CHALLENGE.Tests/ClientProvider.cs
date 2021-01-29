using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using SBSC_Challenge;

namespace SBSC_CHALLENGE.Tests{
     public class ClientProvider : IDisposable
    {
        private TestServer Server;
        public HttpClient Client { get; private set; }
        public ClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }

        public void Dispose()
        {
            Server?.Dispose();
            Client?.Dispose();
        }
    }
}