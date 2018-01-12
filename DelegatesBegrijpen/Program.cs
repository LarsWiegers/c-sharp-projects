using System;

delegate void WorkStarted();
delegate void WorkProgressing();
delegate int WorkCompleted();

class Worker
{
    public WorkStarted Started;
    public WorkProgressing Progressing;
    public WorkCompleted Completed;

    public void DoWork()
    {
        Console.WriteLine("Worker: work started");
        if (this.Started != null) this.Started();

        Console.WriteLine("Worker: work progressing");
        if (this.Progressing != null) this.Progressing();

        Console.WriteLine("Worker: work completed");
        if (this.Completed != null)
        {
            int grade = this.Completed();
            Console.WriteLine("Worker grade = {0}", grade);
        }
    }
}

class Boss
{
    public int WorkCompleted()
    {
        Console.WriteLine("Boss : It's about time!");
        return 4; // out of 10
    }
}

class Universe
{
    static void Main()
    {
        Worker peter = new Worker();
        Boss boss = new Boss();
        Universe Universe = new Universe();

        // NOTE: We've replaced the Advise method with the assignment operation
        peter.Started += new WorkStarted(Universe.WorkerStarted);
        peter.Progressing += new WorkProgressing(Universe.WorkerProgressing);
        peter.Completed += new WorkCompleted(boss.WorkCompleted);
        peter.Completed += new WorkCompleted(Universe.WorkerCompleted);
        peter.DoWork();

        Console.WriteLine("Main: worker completed work");
        Console.ReadLine();
    }
    public void WorkerStarted()
    {
        Console.WriteLine("Universe : That is the first step!");
    }
    public void WorkerProgressing()
    {
        Console.WriteLine("Universe : Worker is doing good!");
    }
    public int WorkerCompleted()
    {
        Console.WriteLine("You did it!");
        return 7;
    }
}