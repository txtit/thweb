using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3.Controllers
{
    public class RazorViewController : Controller
    {
        // GET: RazorView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Variable_If_Else_Switch()
        {
            return View();
        }
        public ActionResult Array_Loop()
        {
            return View();
        }
        public ActionResult SoNguyenTo()
        {
            List<int> lsnt = new List<int>();
            for ( int i = 0; i <= 100; i++)
            {
                if(ktsnt(i))
                {
                    lsnt.Add(i);

                };

            }
            ViewBag.songuyento = lsnt;
            return View();
        }
        public ActionResult GiaiThua()
        {
            List<float?> lgt = new List<float?>();
            for(float i = 1; i <= 10; i++)
            {
                lgt.Add(giaithuaso(i));

            }
            ViewBag.Result = lgt;
            return View();
        }

        public ActionResult BangCuuChuong()
        {
        //    List<int> bangcuuchuong = new List<int>();
        //    for (int i = 2; i <= 9; i++)
        //    {

        //        for (int j = 1; j <= 10; j++)
        //        {
        //            bangcuuchuong.Add(i * j);
        //        }
        //    }
        //    ViewBag.bangcuuchuong = bangcuuchuong;
            return View();
        }


        private float? giaithuaso(float so) 
        {
           
            float result = 1;
            while (so >= 1)
            {
                result *= so;
                so--;
            }
            return result  ;
        }

        private bool ktsnt(int? so)
        {
            if (so < 2)
            {
                return false;
            }else if (so > 2)
            {
                if(so %2 ==0)
                {
                    return false;
                } 
                for(int i = 3; i < Math.Sqrt((float)so); i += 2)
                {
                    if (so % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}