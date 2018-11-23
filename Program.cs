using System;
using IronPython.Hosting;////导入IronPython库文件
using Microsoft.Scripting.Hosting; ////导入微软脚本解释库文件
using System.Windows.Forms;

namespace csharp_python
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    

}
