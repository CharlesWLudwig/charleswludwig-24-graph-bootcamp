using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using Neo4j.Driver;
  
namespace Neoflix
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // load config from appsettings.json
            var (uri, user, password) = Config.UnpackNeo4jConfig();

            // connect to Neo4J and Verify Connectivity
            await Neo4j.InitDriverAsync(uri, user, password);

            // configure and run website
            await CreateHostBuilder(args).Build().RunAsync();
        }

        var cypherQuery =
        @"
        MATCH (m:Movie {title:$movie})<-[:RATED]-(u:User)-[:RATED]->(rec:Movie)
        RETURN distinct rec.title AS recommendation LIMIT 20
        ";

        var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
        var result = await session.ReadTransactionAsync(async tx => {
        var r = await tx.RunAsync(cypherQuery, 
                new { movie="Crimson Tide"});
        return await r.ToListAsync();
        });

        await session?.CloseAsync();
        foreach (var row in result)
        Console.WriteLine(row["recommendation"].As<string>());

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }
    }
}