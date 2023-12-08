using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab4.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/CustomerDetauk action trả về thông tin 
        // chi tiết 1 khách hàng cho view CustomerDetail
        public ActionResult CustomerDetail()
        {
            Customer cus = new Customer()
            {
                CustomerID = "KH001",
                FullName ="Trần Xuân Thao",
                Address = "Tp.HCM",
                Email = "thao16068@gmail.com",
                Phone = "0988.611.899",
                Balance = 15200000
            };
            //cách 1 gán dữ liệu vào ViewBaf để chuyển tới view
            //viewbag.customer = cus;
            // return View();
            // có thể truyền dữ liệu qua dối tượng model để chuyển tới View
            return View(cus);
        }

        // GET / Product/CustomerList(action trả về danh sách khách hàng cho view customerLisst) 
        public ActionResult CustomerList()
        {
            // tạo một danh sách khách hàng
            List<Customer> listcustomer = new List<Customer>()
            {
                new Customer()
                {
                    CustomerID = "KH001",
                FullName ="Trần Xuân Thao",
                Address = "Tp.HCM",
                Email = "thao16068@gmail.com",
                Phone = "0988.611.899",
                Balance = 15200000
                },
                 new Customer()
                {
                    CustomerID = "KH002",
                FullName ="Trần Xuân Thao",
                Address = "Tp.HCM",
                Email = "thao16068@gmail.com",
                Phone = "0988.611.899",
                Balance = 15200000
                },
                  new Customer()
                {
                    CustomerID = "KH003",
                FullName ="Trần Xuân Thao",
                Address = "Tp.HCM",
                Email = "thao16068@gmail.com",
                Phone = "0988.611.899",
                Balance = 15200000
                },
                   new Customer()
                {
                    CustomerID = "KH004",
                FullName ="Trần Xuân Thao",
                Address = "Tp.HCM",
                Email = "thao16068@gmail.com",
                Phone = "0988.611.899",
                Balance = 15200000
                }
            };
            // gán dữ liệu vào ViewBag để chuyerne qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}