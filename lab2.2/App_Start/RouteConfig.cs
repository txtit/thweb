﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace lab2._2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
           
            routes.MapRoute(
                name: "Show Product",
                url:"SanPham/Danh-Sach-San-Pham",
                defaults: new {controller = "Product", action = "ShowProduct"}
                );
            
            routes.MapRoute(
                name: "Product",
                url : "San-Pham",
                defaults: new {controller = "Product",action="ShowProduct"}
                );
           
            routes.MapRoute(
                name:"Edit Product",
                url: "San-Pham/Sua/{productId}",
                defaults: new {controller="Product",action="EditProduct",productId=@"\d{1,4}"}
                );
            
            routes.MapRoute(
                name: "Details Product",
                url: "SanPham/{productName}/{productId}",
                defaults: new {controller = "Product",action ="DetailsProduct",productName = (string)null,productId = @"d{1,4}"}
                );
        }
    }
}
