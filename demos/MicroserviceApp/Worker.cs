using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ApiClient.Abstractions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;

namespace MicroserviceApp
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IApiClient _apiClient;

        public Worker(ILogger<Worker> logger, IApiClient apiClient)
        {
            _logger = logger;
            _apiClient = apiClient;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            IEnumerable<User> users = await _apiClient.UserClient.GetAll();
            Group group = await _apiClient.GroupClient.GetById(2);

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
