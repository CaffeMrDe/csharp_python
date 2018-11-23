using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace csharp_python
{
    class demo
    {
        public void run()
        {
            ScriptRuntime pyRuntime = Python.CreateRuntime();
            dynamic obj = pyRuntime.UseFile("debug.py");
            
            int num1, num2;
            Console.Write("num 1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("num 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = obj.add(num1, num2);

            Console.WriteLine("the sum: " + sum);
            Console.ReadKey();
        }

    }
}
