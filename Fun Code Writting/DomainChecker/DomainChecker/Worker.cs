using DomainChecker.Classes;
using DomainChecker.Helpers;
using DomainChecker.Interfaces;
using Newtonsoft.Json;

namespace DomainChecker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            List<Shop> shops = new List<Shop>(); // Have to change db context later

            shops = JsonConvert.DeserializeObject<List<Shop>>(File.ReadAllText("csvjson.json"));

            List<CheckedLinkResponse> checkedLinks = new List<CheckedLinkResponse>(); // Our bad links list

            using (IServiceScope scope = _serviceProvider.CreateScope())
            {
                List<Task> taskList = new List<Task>();

                ICheckLinkService checkLinkService = scope.ServiceProvider.GetRequiredService<ICheckLinkService>();
                foreach (var shop in shops)
                {
                    taskList.Add(await Task.Factory.StartNew(async () =>
                    {
                        CheckedLinkResponse response = await checkLinkService.Check(shop.Domain, shop.AlwaysRequestFromBrowser);

                        if (response != null)
                        {
                            checkedLinks.Add(response);
                        }
                    }));
                }

                Task.WaitAll(taskList.ToArray());
            }

            // Writting bad links list to the json file
            if (checkedLinks.Count > 0)
            {
                string json = JsonConvert.SerializeObject(checkedLinks);

                File.WriteAllText("checkedLinks.txt", json);
            }

            _logger.LogInformation("Task by checking domeins done!");

            CancellationTokenSource.CreateLinkedTokenSource(stoppingToken).Cancel();
            Environment.Exit(1);
        }
    }
}