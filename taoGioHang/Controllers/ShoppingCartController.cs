using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using taoGioHang.Models;

namespace taoGioHang.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            List<CartItem> ShoppingCart = Session["ShoppingCart"] as List<CartItem>;
            return View(ShoppingCart);
        }

        public RedirectToRouteResult AddToCart(int ProductId)
        {
            ProductModel db = new ProductModel();
            if (Session["ShoppingCart"]==null) // nếu giỏ hàng chưa được khởi tạo
            {
                // khởi tạo Sesion["giohang"] là 1 List<CartItem>
                Session["ShoppingCart"] = new List<CartItem>();
            }
            List<CartItem> ShoppingCart = Session["ShoppingCart"] as List<CartItem>;
            // kiếm tra xem sản phẩm khách đang chọn đã có trong giỏ hàng hay chưa
            if(ShoppingCart.FirstOrDefault(m=>m.Id==ProductId)==null)
            {
                // nếu không có sp này trong giỏ hàng
                CartItem product = db.FindProduct(ProductId);
                // Tạo ra 1 CartItem mới
                CartItem newItem = new CartItem()
                {
                    Id = ProductId,
                    Name = product.Name,
                    Amount =1 ,
                    Photo = product.Photo,
                    Price = product.Price
                };
                // thêm CartItem vào giỏ
                ShoppingCart.Add(newItem);
            }
            else
            {
                // nếu SP khách chọn đã có trong giỏ hàng
                // thì không thêm vào giỏ nữa mà tăng SL lên
                CartItem cardItem =
                    ShoppingCart.FirstOrDefault(m => m.Id == ProductId);
                cardItem.Amount++;
            }
            // Action này sẽ chuyển hướng về trang chi tiết sp
            // Khi khách hàng đặt vào giỏ thành công.

            //Bạn có thể chuyển về chính trang khách hàng vừa đứng
            //bằng lệnh return Redirect(Request.UrlReferrer.ToString()); nếu muốn
            return RedirectToAction("Index", "ShoppingCart");
        }

        public RedirectToRouteResult UpdateAmount(int ProductId, int newAmount)
        {
            // Tìm carditem muốn sửa
            List<CartItem> ShoppingCart = Session["ShoppingCart"] as List<CartItem>;
            CartItem EditAmount = ShoppingCart.FirstOrDefault(m => m.Id == ProductId);
            if(EditAmount!=null)
            {
                EditAmount.Amount = newAmount;
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult RemoveItem(int ProductId)
        {
            List<CartItem> shoppingCart = Session["ShoppingCart"] as List<CartItem>;
            CartItem DelItem = shoppingCart.FirstOrDefault(m => m.Id == ProductId);
            if(DelItem != null)
            {
                shoppingCart.Remove(DelItem);
     
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult CartIsNull()
        {
            List<CartItem> shoppingCart = Session["ShoppingCart"] as List<CartItem>;
            return RedirectToAction("Index");
        }
    }
}