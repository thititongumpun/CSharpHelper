using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CustomerOrderViewer.Models;
using CustomerOrderViewer.Repository;

namespace CustomerOrderViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomerOrderDetailRepo customerRepo = new CustomerOrderDetailRepo(@"Data Source=localhost;Initial Catalog=CustomerOrderViewer;Integrated Security=True;");
                IList<CustomerOrderDetail> customerOrderDetails = customerRepo.GetList();

                if (customerOrderDetails.Any())
                {
                    foreach(CustomerOrderDetail customerOrderDetail in customerOrderDetails)
                    {
                        Console.WriteLine("{0}: FullName: {1} {2} (Id: {3}) Purchased {4} For {5} (Id: {6})",
                            customerOrderDetail.CustomerOrderId, 
                            customerOrderDetail.FirstName,
                            customerOrderDetail.LastName,
                            customerOrderDetail.CustomerId,
                            customerOrderDetail.Description,
                            customerOrderDetail.Price,
                            customerOrderDetail.ItemId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SHIT!!!!!!!!!!", ex.Message);
                Debug.WriteLine(ex.Message);
            }
            

        }
    }
}
