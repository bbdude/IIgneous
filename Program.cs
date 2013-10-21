using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
using System.Threading;

namespace IIgneous
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Compile .ii files into .exe");
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                Thread.Sleep(1000);
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                Thread.Sleep(1000);
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                Thread.Sleep(1000);
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
=======
                System.Threading.Thread.Sleep(1000);
>>>>>>> 33fc1f70a3dc2c697a1b3a5ce274f49c68371023
            }
        }
    }
}
