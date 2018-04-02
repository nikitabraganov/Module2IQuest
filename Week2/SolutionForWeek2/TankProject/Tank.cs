using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject
{
    public class Tank : IDisposable
    {
        public string TankModel { get; private set; }

        public Tank(string tankModel)
        {
            TankModel = tankModel;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                TankModel = String.Empty;
            }
            // free native resources if there are any.
        }
    }
}
