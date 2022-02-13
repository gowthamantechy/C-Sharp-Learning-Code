using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace CSharpFeatures.CSharp7._0
{
    public class AsynchronousMainEx
    {

        async static Task Main(string[] args)
        {
            Task<int> result =  Show();
            Console.WriteLine("length: {0}", result.Result);

            Console.ReadKey();
        }

        async static Task<int> Show()
        {
            Task<string> TaskUrl = new HttpClient().GetStringAsync("http://www.javatpoint.com");
            string result = await TaskUrl; // Using await to suspand task  
            return result.Length;
        }

    }
}
