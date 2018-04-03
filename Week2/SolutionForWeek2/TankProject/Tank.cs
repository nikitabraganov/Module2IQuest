using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject
{
    public class Tank : IDisposable
    {
        public Stack<int> ammunition = new Stack<int>();

        public string TankModel { get; private set; }

        public Tank(string tankModel)
        {
            TankModel = tankModel;
        }

        public Tank()

        {
        }

        ~Tank()
        {
            Dispose();
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

                while (ammunition.Count > 0)
                {
                    ammunition.Pop();
                }
                TankModel = String.Empty;
            }
            // free native resources if there are any.
        }
    }
}
