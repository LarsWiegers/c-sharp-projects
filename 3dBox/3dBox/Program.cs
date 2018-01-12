using Components;
using System;

namespace _3dBox
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            new MainWindow().Run(60);
        }
    }
}