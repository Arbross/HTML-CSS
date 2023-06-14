using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using AdminPanel.Infrastructure;
using System;
using System.Linq;

namespace AdminPanel.Service
{
    public class ParserService
    {
        private static Task Parser { get; set; }
        private static CancellationTokenSource CancelTokenSource { get; set; }
        public static CancellationToken Token { get; set; }
        private List<string> Links { get; set; }
        private int Interval { get; set; }

        public ParserService(List<string> links, int interval)
        {
            try
            {
                CancelTokenSource = new CancellationTokenSource();
                Token = CancelTokenSource.Token;
                Links = links;
                Interval = interval;

                Parser = new Task(() => Execute(), CancelTokenSource.Token);
            }
            catch (OperationCanceledException)
            {

            }
        }

        private async void Execute()
        {
            var proxy = Database.GetProxies().Select(x => x.Host).ToList();
            ManagerWeb managerWeb = new ManagerWeb();
            while (true)
            {
                foreach (var link in Links)
                {
                    try
                    {
                        if (Token.IsCancellationRequested)
                        {
                            Token.ThrowIfCancellationRequested();

                        }
                    }
                    catch (OperationCanceledException)
                    {
                        CancelTokenSource.Dispose();
                        return;
                    }

                    try
                    {
                        string proxy2 = "";
                        if (proxy.Count > 0)
                        {
                            proxy2 = proxy[0];
                            proxy.RemoveAt(0);
                        }
                        else if (proxy.Count == 0)
                        {
                            proxy = Database.GetProxies().Select(x => x.Host).ToList();
                            proxy2 = proxy[0];
                            proxy.RemoveAt(0);
                        }
                        await managerWeb.CheckUrlAsync(link, proxy2);
                    }
                    catch (Exception ex)
                    {

                    }
                    Thread.Sleep(Interval);
                }
            }
        }

        public void Start()
            => Parser.Start();

        public void Stop()
            => CancelTokenSource.Cancel();
    }
}
