using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace taoGioHang.Models
{
    public class CartItem
    {


        public int Id { get; set; }
        [DisplayName("Tên sản phầm")]
        public string Name { get; set; }
        [DisplayName("Giá")]
        public double Price { get; set; }
        [DisplayName("Hình ảnh")]
        public string Photo { get; set; }
        [DisplayName("Số lượng")]
        public int Amount { get; set; }
        [DisplayName("Thành tiền")]
        public double Money
        {
            get
            {
                return Amount * Price;
            }
        }
    }
}