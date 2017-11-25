using System;
using System.IO;

namespace Euler
{
    class Solve
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Usage(Console.Error);
                Environment.Exit(1);
            }

            var solutionNumber = args[0];
            var solutionArguments = new string[args.Length - 1];

            Array.Copy(args, 1, solutionArguments, 0, solutionArguments.Length);

            var typeName = "Euler.Problem" + solutionNumber;
            var type = Type.GetType(typeName);
            var method = type.GetMethod("Solve");
            var result = method.Invoke(null, new Object[] { solutionArguments });

            Console.WriteLine(result);
        }

        private static void Usage(TextWriter output)
        {
            output.WriteLine("usage: dotnet run <problem number> <extra arguments>");
        }
    }
}
