using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class WorkTask
    {
        public WorkTask(string description, DateTime insertedUtc)
        {
            Description = description;
            InsertedUtc = insertedUtc;
        }

        public string Description { get; set; }
        public DateTime InsertedUtc { get; set; }
    }
}
