﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3.Controllers
{
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult ViewDataTest()
        {
            ViewData["message1"] = "ViewData chỉ tồn tại trong một Request và giá trị trờ về null khi chuyển hướng(Redirect)";
            ViewData["message2"] = "ViewData yêu cầu chuyển kiểu dữ liệu và kiểm tra null để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiên" };
            ViewData["student"] = students;
            return View();  
        }
        public ActionResult ViewBagTest()
        {
            // ViewBag là biến trung gian dùng để truyền dữ liệu từ cont
            ViewBag.message1 = "ViewBag chỉ tồn tại trong một Request và giá trị trở về null khi chuyển hướng(Redirect)";
            ViewBag.message2 = "ViewBag yêu cầu chuyển kiểu dữ liệu và kiểm tra null để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiên" };
            ViewBag.students = students;
            return View();
        }
        public ActionResult TempDataTest()
        {
            TempData["message1"] = "TempData có thể truyền dữ liệu từ request hiện tại tới chuỗi các request con khi sử dụng Redirect";
            TempData["message2"] = "TempData yêu cầu chuyển kiểu dữ liệu và kiểm ta null để tránh lỗi";
            ViewBag.message2 = "Dữ liệu từ ViewBag";
            ViewData["message2"] = "Dữ liệu từ ViewData";
            return Redirect("~/PassingData/About");
        }
        public ActionResult About()
        {
            return View();
        }
    }
}