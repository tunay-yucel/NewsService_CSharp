using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NewsService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(NewsServiceWCF)))
            {
                host.Open();

                foreach (var ep in host.Description.Endpoints)
                {
                    Console.WriteLine(ep.Address);
                }

                Console.WriteLine("Press a key to terminate the service ...");

                Console.ReadKey();
            }
        }
    }
}
