using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StoreDataProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public Order(string orderName, int customerId, int employeeId)
        {
            OrderName = orderName;
            CustomerId = customerId;
            EmployeeId = employeeId;
        }

        public override string ToString()
        {
            return $"ID: {Id} | OrderName: {OrderName} | CustomerId: {CustomerId} | EmployeeId: {EmployeeId}";
        }
    }
}
