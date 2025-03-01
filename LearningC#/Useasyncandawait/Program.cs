
using System.Diagnostics;
using System.Threading.Tasks;

const int repetitions = 1000;
//UseSystemThreading();
// UseSystemThreadingTasks();
 UseAsync();


//static void UseSystemThreading()
//{
//    // Create thread and associate method
//    ThreadStart threadStart = DoWork;
//    // ThreadStart Delegate
//    Thread plusThread = new Thread(threadStart);
//    // Start thread
//    plusThread.Start();
//    for (int count = 0; count < repetitions; count++)
//    {
//        Console.Write('-');
//    }

//    // Wait for plusThread to terminate
//    plusThread.Join();
//}

//static void DoWork()
//{
//    for (int count = 0; count < repetitions; count++)
//    {
//        Console.Write('+');
//    }
//}

static void UseSystemThreadingTasks()
{
    Task plusTask = Task.Run(() =>
    {
        for (int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }
    }
    );
    Debug.WriteLine("Plus Task status: " + plusTask.Status);

    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('-');
    }

    plusTask.Wait();
    Debug.WriteLine("Plus Task status: " + plusTask.Status);

}

static void UseAsync()
{
    Task task = DoWorkAsync();


    //2 Print minuses

    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('-');
    }
    task.Wait();
    Debug.WriteLine("Task status: " + task.Status);
}

static async Task DoWorkAsync()
{
      await Task.Run(() =>
    {
        for (int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }

    }
  
    );
    Debug.WriteLine("DoWorkAsync completed");
}

