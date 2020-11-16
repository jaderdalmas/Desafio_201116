using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Desafio
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args">Args</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create Host Builder
        /// </summary>
        /// <param name="args">Args</param>
        /// <returns>Host Builder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
