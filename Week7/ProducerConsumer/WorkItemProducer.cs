using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class WorkItemProducer
    {
        private WorkQueue workQueue;

        public WorkItemProducer(WorkQueue workQueue)
        {
            this.workQueue = workQueue;
        }

        public void ProduceWorkItems()
        {
            Random random = new Random();
            int upperLimit = random.Next(5, 11);
            for (int i = 0; i <= upperLimit; i++)
            {
                Guid jobId = Guid.NewGuid();
                WorkTask wt = new WorkTask(string.Concat("Work with job ID ", jobId), DateTime.UtcNow);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} added work {wt.Description} at {wt.InsertedUtc} to the work queue in iteration {i + 1}.");
                workQueue.AddTask(wt);
                Thread.Sleep(2000);
            }
        }
    }
}
