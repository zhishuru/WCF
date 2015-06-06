using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfService2;

namespace WCFConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           //ServiceHost.IService1 client = new ServiceHost.Service1Client();
           //new EndpointAddress("http://localhost:81/Service1.svc?wsdl");
           // Console.WriteLine(client.Add(1, 2));
           // //Console.WriteLine(client.Factorial(-1));

           // Console.WriteLine(client.FactorialMyNumber(new ServiceHost.Number()));

            ServiceHost.IService1 client = ChannelFactory<ServiceHost.IService1>.CreateChannel(new BasicHttpBinding(),
           new EndpointAddress("http://localhost:81/Service1.svc?wsdl"));
            //Console.WriteLine(client.Add(1, 2));
            //Console.WriteLine(client.Factorial(4));
            //int i = new test(22).dd;
            Console.WriteLine(client.FactorialMyNumber(new ServiceHost.Number1()));


            Console.ReadKey();

            //ServiceHost host = new ServiceHost(typeof(WCF.Service.HelloWorldService));

            //host.AddServiceEndpoint(typeof(ICalculateService), new BasicHttpBinding(), "cal");
            //host.Opened += new EventHandler((obj, arg) =>
            //{
            //    Console.WriteLine("Service Started,Press Enter Stop Service");
            //});
            //host.Open();

            //Console.ReadLine();
            //host.Closed += new EventHandler((obj, arg) =>
            //{
            //    Console.WriteLine("Service Stopped");
            //});
            //host.Close();
          //  Console.WriteLine(client.FactorialMyNumber(new Number(5)));
        }
       
    }
    public class test
    {
        public int dd;
        public test(int mm)
        {
            dd = mm;
        }
    }
    

   
}
