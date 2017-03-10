using Catapult;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CatapultB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IUtil, Util>()
                .BuildServiceProvider();
        }
    }
}