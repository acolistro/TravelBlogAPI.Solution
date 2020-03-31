using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TravelBlog
{
  public class Program
  {
    public static void Main(string[] args)
    {
        BuildWebHost(args).Run();
    }

    //from https://stackoverflow.com/questions/57745481/unable-to-create-an-object-of-type-mycontext-for-the-different-patterns-suppo
    public static IWebHost BuildWebHost(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
      .UseStartup<Startup>()
      .UseUrls("http://localhost:5004/");
  }
}
