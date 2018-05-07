using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class FileDataSource: IDataSource
    {
        public List<Customer> LoadCustomers()
        {
            using (StreamReader readJson = new StreamReader(@"DataSource\customers.json"))
            {
                string input = readJson.ReadToEnd();
                readJson.Close();
                dynamic listFound = JsonConvert.DeserializeObject<List<Customer>>(input);
                return listFound;
            }
        }

        public List<Reservation> LoadReservation()
        {
            throw new NotImplementedException();
        }
    }
}
