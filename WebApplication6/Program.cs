using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace WebApplication6
{ 
public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
        IConfiguration configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .Build();
        var myClass = new MyClass(configuration);
        myClass.MyMethod();
    }
    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true,
    reloadOnChange: true)
     .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
     .AddEnvironmentVariables();
    })
    .UseStartup<Startup>();
}
}