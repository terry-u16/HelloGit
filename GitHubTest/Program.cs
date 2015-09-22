using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GitHub!");
            var taro = new Person() { Age = 24, Name = "Taro" };
            var json = JsonConvert.SerializeObject(taro);
            Console.WriteLine(json);
        }
    }
}
