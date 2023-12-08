using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab4._2.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        //khởi tạo danh sách khách hàng
        static readonly List<Customer> data = new List<Customer>()
        {
        new Customer(){ CustomerID = "KH001",
        FullName = "Trịnh Văn Chung",Address = "Hà Nội",
         Email = "devmaster.founder@gmail.com",
         Phone = "0978.611.889",Balance = 15200000},
         new Customer(){ CustomerID = "KH002",
         FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
         Email = "cucdt@gmail.com",Phone = "0986.767.444",
         Balance = 2200000},
         new Customer(){ CustomerID = "KH003",
         FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
         Email = "thangnt@gmail.com",Phone = "0924.656.542",
         Balance = 1200000},
         new Customer(){ CustomerID = "KH004",
         FullName = "Lê Ngọc Hải",Address = "Hà Nội",
         Email = "hailn@gmail.com",Phone = "0996.555.267",
         Balance = 6200000}
         };
        // thực thi phương thức lấy danh sách khách hàng
        public IList<Customer> Customers()
        {
            return data;
        }
        // thực thi phương thức tìm khách hàng theo tên 
        public IList<Customer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        // thực thi phương thức lấy khách hàng theo id
        public Customer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerID.Equals(customerId));
        }
        // thực thi phương thức thêm khách hàng
        public void AddCustomer(Customer cus)
        {
            data.Add(cus);
        }
        // thực thi phương thức cập nhật khách hàng
        public void UpdateCustomer(Customer cus)
        {
            // lấy khách hàng theo id
            var customer = data.FirstOrDefault(c => c.CustomerID.Equals(cus.CustomerID));
            // nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }
        // thực thi phouwng thức xóa khách hàng
        public void DeleteCustomer(Customer cus)
        {
            data.Remove(cus);
        }

        internal object GetCustomers()
        {
            throw new NotImplementedException();
        }

        IList<Customer> ICustomerRepository.GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
