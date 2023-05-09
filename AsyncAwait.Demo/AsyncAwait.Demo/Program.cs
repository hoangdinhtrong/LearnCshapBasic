using AsyncAwait.Demo.Services;

namespace AsyncAwait.Demo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Driver driver = new Driver();
            LoadVerifier loadVerifier = new LoadVerifier();
            NewLoadAssigner assigner = new NewLoadAssigner();

            DateTime startTime = DateTime.Now;

            var driverTask = driver.ReportToBackoffice();
            var verifierTask = loadVerifier.Verify();

            

            // Main Thread
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }

            //var tasks = new List<Task>() { driverTask, verifierTask };
            //while(tasks.Count  > 0)
            //{
            //    var task = await Task.WhenAny(tasks);
            //    if(task == driverTask)
            //    {
            //        Console.WriteLine("Driver task completed");
            //        Console.WriteLine($"Driver time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verifier task completed");
            //        Console.WriteLine($"Verifier time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            //    }

            //    tasks.Remove(task);
            //}
            //var a = Task.WhenAll(driverTask, verifierTask);
            Task.WaitAll(driverTask, verifierTask);
            if (verifierTask.Result)
            {
                await assigner.Assign();
            }

            Console.WriteLine($"Total time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            Console.ReadLine();
        }
    }
}