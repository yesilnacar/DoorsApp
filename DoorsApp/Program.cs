using DoorsApp.Core.Interfaces;
using Microsoft.Practices.Unity;
using System;

namespace DoorsApp
{
    static class ProgramEntry
    {
        static void Main(string[] args)
        {
            var unity = new UnityContainer();
            UnityConfig.RegisterTypes(unity);

            var program = unity.Resolve<Program>();
            program.Run();
        }
    }

    public class Program : IProgram
    {
        private readonly IVisitorService _visitorService;

        public Program(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public void Run()
        {
            var result = _visitorService.VisitDoors();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
