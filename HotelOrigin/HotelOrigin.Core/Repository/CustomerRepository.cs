using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domian;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
using HotelOrigin;


namespace HotelOrigin.Core.Repository
{
    public class CustomerRepository
    {
        private static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        //Create
        
        public static Customer Create (int id, string firstName, string lastName, string email, string telephone)
        {
            Customer customer = new Customer();

            customer.ID = id;
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.EmailAddress = email;
            customer.Telephone = telephone;

            customers.Add(customer);
            return customer;
        }
        public static void Add(Customer customer)
        {
            customers.Add(customer);
        }
        //Read
        public static Customer GetById(int id)
        {
            return customers.FirstOrDefault(c => c.ID == id);
        }
        //Read All
        public static ObservableCollection<Customer> GetAll()
        {
            return customers;
        }
        //Update
        public static void Update(Customer customer, int id, string firstName, string lastName, string email, string telephone)
        {
            customer.ID = id;
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.EmailAddress = email;
            customer.Telephone = telephone;
        }
        //Delete
        public static void Delete(int id)
        {
            var customer = GetById(id);
            customers.Remove(customer);
        }
        //Upload
        public static void Upload()
        {

            if (File.Exists("CustmersList.Json"))
            {
                string JsonCustomersList = File.ReadAllText("CustmersList.Json");
                ObservableCollection<Customer> Customersloaded = JsonConvert.DeserializeObject<ObservableCollection<Customer>>(JsonCustomersList);
                customers = Customersloaded;
            }
        }
        //Save
        public static void Save()
        {
            string JsonCustomersList = JsonConvert.SerializeObject(customers);
             File.WriteAllText("CustmersList.Json", JsonCustomersList);
        }
    }
}
