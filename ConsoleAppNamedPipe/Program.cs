using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNamedPipe
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost servicehost = new ServiceHost(typeof(WCFNamedPipe.WCFNamedPipe)))
            {
                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior()//Service Behaviour
                {
                    HttpGetEnabled = true,
                };            

                servicehost.Description.Behaviors.Add(serviceMetadataBehavior);
                servicehost.AddServiceEndpoint(typeof(WCFNamedPipe.IWCFNamedPipe), new NetNamedPipeBinding(),"net.pipe://localhost/WCFNamedPipe/");//Binding
                servicehost.Open();
                Console.WriteLine("Host Start Time" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
