using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IWorkers
    {
       Boolean Work();
       Boolean WorkCompleted();
       Boolean IsWaitingForNewWork();
    }

    class Program
    {
        class Worker: IWorkers {
            private Boolean WorkDone = false;
            public Boolean Work()
            {
                WorkDone = true;
                return false;
            }
            public Boolean WorkCompleted()
            {
                return this.WorkDone;
            }
            public Boolean IsWaitingForNewWork()
            {
                return true;
            }

        }
    static void Main(string[] args)
        {
            Worker jan = new Worker();
            Console.WriteLine("Is jan working : " + jan.Work().ToString());
            Console.WriteLine("Is jan's work completed :" + jan.WorkCompleted().ToString());
            Console.WriteLine("Is jan's waiting for work :" + jan.IsWaitingForNewWork().ToString());
            Console.ReadLine();
        }
    }   
}
