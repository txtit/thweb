using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2.Models
{
    public interface ICustomerRepository
    {
        // khai báo phương thức lấy danh sách khách hàng
        IList<Customer> GetCustomers();

        //khai báo phương thức lấy khách hầng
        Customer GetCustomer(string customerId);

        // khai báo phương thức thêm khách hàng
        void AddCustomer(Customer cus);

        // khai báo phương thức cập nhật khác hàng
        void UpdateCustomer(Customer cus);

        // khai báo phương thức tìm kiếm khách hàng
        IList<Customer> SearchCustomer(string name);

        // khai báo phương thức xóa khách hàng
        void DeleteCustomer(Customer cus);
    }
   
}
