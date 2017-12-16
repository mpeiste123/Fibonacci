using FibonacciClient.MyService;
using System;


namespace FibonacciClient
{
    class Program
    {

       



        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            log4net.ILog log  = log4net.LogManager.GetLogger(typeof(Program));

            log.Debug("Debug Message");
            log.Info("Info Message");
            log.Warn("Warn Message");
            log.Error("Error Message");
            log.Fatal("Fatal Message");

            MyService.FibonacciSoapClient proxy =new FibonacciSoapClient();

            int fibonacciResult = proxy.FibonacciSeries(32);

            Console.WriteLine(fibonacciResult);

            Console.ReadLine();

        }
    }
}
