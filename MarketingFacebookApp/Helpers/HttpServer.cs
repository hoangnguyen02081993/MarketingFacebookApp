using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Helpers
{
    public class HttpServer
    {
        #region Fields

        private int Port;
        private TcpListener Listener;
        private HttpProcessor Processor;
        private bool IsActive = true;

        #endregion

        //private static readonly ILog log = LogManager.GetLogger(typeof(HttpServer));

        #region Public Methods
        public HttpServer(int port, List<Route> routes)
        {
            this.Port = port;
            this.Processor = new HttpProcessor();

            foreach (var route in routes)
            {
                this.Processor.AddRoute(route);
            }
        }

        public void Listen()
        {
            new Thread(() =>
            {
                this.Listener = new TcpListener(IPAddress.Any, this.Port);
                this.Listener.Start();
                while (this.IsActive)
                {
                    TcpClient s = this.Listener.AcceptTcpClient();
                    Thread thread = new Thread(() =>
                    {
                        this.Processor.HandleClient(s);
                    });
                    thread.Start();
                    Thread.Sleep(1);
                }
            }).Start();
        }
        #endregion
    }
}
