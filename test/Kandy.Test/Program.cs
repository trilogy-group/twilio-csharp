using System;
using System.Reflection;
using NUnitLite;

namespace Kandy.Tests
{
    class Program
    {
        static int Main(string[] args)
        {
#if NET35
            return new AutoRun(typeof(KandyTest).Assembly).Execute(args);
#else
            return new AutoRun(typeof(KandyTest).GetTypeInfo().Assembly).Execute(args);
#endif
        }
    }
}
