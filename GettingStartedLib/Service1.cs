using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedLib
{
    public class CalculatorService : ICalculator
    {
        //public double Add(double n1, double n2)
        //{
        //    double result = n1 + n2;
        //    Console.WriteLine("Received Add({0},{1})", n1, n2);
        //    // Code added to write output to the console window.
        //    Console.WriteLine("Return: {0}", result);
        //    return result;
        //}

        //public double Subtract(double n1, double n2)
        //{
        //    double result = n1 - n2;
        //    Console.WriteLine("Received Subtract({0},{1})", n1, n2);
        //    Console.WriteLine("Return: {0}", result);
        //    return result;
        //}

        //public double Multiply(double n1, double n2)
        //{
        //    double result = n1 * n2;
        //    Console.WriteLine("Received Multiply({0},{1})", n1, n2);
        //    Console.WriteLine("Return: {0}", result);
        //    return result;
        //}

        //public double Divide(double n1, double n2)
        //{
        //    double result = n1 / n2;
        //    Console.WriteLine("Received Divide({0},{1})", n1, n2);
        //    Console.WriteLine("Return: {0}", result);
        //    return result;
        //}
        
        public async Task<string> SomeTask()
        {
            string result = string.Empty;
            using (var client = new HttpClient())
            {
               // client.BaseAddress = new Uri("http://localhost:7071/api/Function1");
                var reponse = await client.GetAsync("http://localhost:7071/api/Function1?name=sri");
                result = await reponse.Content.ReadAsStringAsync();
                
            }
            return result;
        }

    }

}
