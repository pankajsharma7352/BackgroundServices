
using BackGroundService.Data.DatabaseContext;
using BackGroundService.Model.Models;
using System;

namespace BackGroundService.Web
{
    public class MybackgroundServices : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public MybackgroundServices(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<BackgroundContext>();

                    var tempData = dbContext.TempData.Where(td => !td.IsSent).ToList();
                    foreach (var item in tempData)
                    {
                        dbContext.ActualData.Add(new ActualData
                        {
                            Name = item.Name,
                            CreatedAt = DateTime.UtcNow
                        });

                        item.IsSent = true;
                    }

                    await dbContext.SaveChangesAsync();
                }

                await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken);
            }
        }
    }
}
