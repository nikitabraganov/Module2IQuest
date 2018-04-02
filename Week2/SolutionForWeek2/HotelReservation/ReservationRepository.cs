using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class ReservationRepository : IRepositoryPattern<Customer>
    {
        private List<Customer> hotelCustomers = new List<Customer>();

        public void Add(Customer customerToAdd)
        {
            hotelCustomers.Add(customerToAdd);
        }

        public List<Customer> ReturnAllCustomers()
        {
            JsonSerializer serializer = new JsonSerializer();
            StreamReader readJsonData = new StreamReader(@"customerData.json");
            string inputData = readJsonData.ReadToEnd();
            readJsonData.Close();
            hotelCustomers = JsonConvert.DeserializeObject<Customer[]>(inputData).ToList();
            return hotelCustomers;
        }
    }
}
