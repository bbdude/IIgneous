using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IIgneous
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Compile .ii files into .exe");
                return;
            }

            try
            {
                Scanner scanner = null;
                using (TextReader input = File.OpenText(args[0]))
                {
                    scanner = new Scanner(input);
                }
                Parser parser = new Parser(scanner.Tokens);
                CodeGen codeGen = new CodeGen(parser.Result, Path.GetFileNameWithoutExtension(args[0]) + ".exe");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
