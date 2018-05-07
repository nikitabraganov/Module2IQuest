using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkQueue workQueue = new WorkQueue(new ConcurrentQueue<WorkTask>());
            WorkItemProducer producerOne = new WorkItemProducer(workQueue);
            WorkItemProducer producerTwo = new WorkItemProducer(workQueue);
            WorkItemProducer producerThree = new WorkItemProducer(workQueue);

            Task producerTaskOne = Task.Run(() => producerOne.ProduceWorkItems());
            Task producerTaskTwo = Task.Run(() => producerTwo.ProduceWorkItems());
            Task producerTaskThree = Task.Run(() => producerThree.ProduceWorkItems());
            Task consumerTaskOne = Task.Run(() => workQueue.MonitorWorkQueue());
            Task consumerTaskTwo = Task.Run(() => workQueue.MonitorWorkQueue());
            Task.WaitAll(producerTaskOne, producerTaskThree, producerTaskTwo);
            workQueue.AllItemsAdded();
            Task.WaitAll(consumerTaskOne, consumerTaskTwo);
            Console.WriteLine("Tasks finished...");
            Console.ReadKey();
        }
    }
}
