using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Backend_Service.AccountService);
            Uri http = new Uri("http://localhost:8080/Account_Service");
            ServiceHost host = new ServiceHost(t, http);
            host.Open();
            Console.WriteLine("Published");
            Console.ReadLine();
            host.Close();
        }
    }
}
