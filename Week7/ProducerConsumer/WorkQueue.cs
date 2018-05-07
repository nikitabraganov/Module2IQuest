using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class WorkQueue
    {
        private BlockingCollection<WorkTask> workQueue;

        public WorkQueue(IProducerConsumerCollection<WorkTask> workTaskCollection)
        {
            workQueue = new BlockingCollection<WorkTask>(workTaskCollection);
        }

        public void AddTask(WorkTask workTask)
        {
            workQueue.Add(workTask);
        }

        public void AllItemsAdded()
        {
            workQueue.CompleteAdding();
        }

        public void MonitorWorkQueue()
        {
            while (true)
            {
                try
                {
                    WorkTask wt = workQueue.Take();
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} processing work task {wt.Description}, entered on {wt.InsertedUtc}");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Work queue on thread {Thread.CurrentThread.ManagedThreadId} has been closed.");
                    break;
                }
            }
        }
    }
}
