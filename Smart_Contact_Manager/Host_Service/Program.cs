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
            using (ServiceHost accountServiceHost = new ServiceHost(typeof(Backend_Service.AccountService)))
            using (ServiceHost contactServiceHost = new ServiceHost(typeof(Backend_Service.ContactService)))
            using (ServiceHost groupServiceHost = new ServiceHost(typeof(Backend_Service.GroupService)))
            {
                accountServiceHost.Open();
                Console.WriteLine("Account Service Published");

                contactServiceHost.Open();
                Console.WriteLine("Contact Service Published");

                groupServiceHost.Open();
                Console.WriteLine("Group Service Published");

                Console.ReadLine();
            }
        }
    }
}
