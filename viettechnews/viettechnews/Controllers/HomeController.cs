using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using System.Web.UI.HtmlControls;

namespace viettechnews.Controllers
{
    public class HomeController : Controller
    {
        private viettechnewsDbContext db = new viettechnewsDbContext();
        public ActionResult Index()
        {

            return View();
        }

        [ChildActionOnly]
        public ActionResult MenuMain()
        {
            var model = new DanhmucDao().ListDM_subCN();         
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult TrangNhat()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult SlideNews()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult BreakingNews()
        {
            var model = new TintucDao().ListTop3mn_bRek();
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult News()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Word_News()
        {
            ViewBag.catCN = new DanhmucDao().ListDM_TG();
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TrendingNews()
        {
            ViewBag.trendingnews1 = new TintucDao().TrendingNews1();
            ViewBag.trendingnews2 = new TintucDao().TrendingNews2();
            ViewBag.trendingnews3 = new TintucDao().TrendingNews3();
            ViewBag.trendingnews4 = new TintucDao().TrendingNews4();
            ViewBag.trendingnews5 = new TintucDao().TrendingNews5();
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TrendingNews_Opinion()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Quangcao()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult VideoNews()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Tintuc()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult News_Tech()
        {
            return PartialView();
        }

        //Router Tin
        public ActionResult Detail_News(int id)
        {
            var model = new TintucDao().Detail_News(id);
            new TintucDao().UpdateViewNo(id);
            return View(model);
        }

        //Router Tin liên quan
        public ActionResult Detail_New_LQ(int id)
        {
            var model = new TintucDao().Detail_News(id);
            new TintucDao().UpdateViewNo(id);
            return View(model);
        }

        //Router tin infact
        public ActionResult Detail_inFact(int id)
        {
            var model = new TintucDao().Detail_News(id);
            new TintucDao().UpdateViewNo(id);
            return View(model);
        }
        
        //Chuyên tin giải trí
        public ActionResult Archive_giaitri()
        {
            return View();
        }
        //Chuyên tin công nghệ
        public ActionResult Archive_congnghe()
        {
            return View();
        }
        //Chuyên tin thế giới
        public ActionResult Archive_thegioi()
        {
            return View();
        }
        //Chuyên tin thể thao
        public ActionResult Archive_thethao()
        {
            return View();
        }
        //Chuyên tin gaming
        public ActionResult Archive_gaming()
        {
            return View();
        }
        //Chuyên tin phong thủy
        public ActionResult Archive_kientruc()
        {
            return View();
        }
        //Chuyên tin Infact
        public ActionResult inFact()
        {
            var model = new TintucDao().infact_detailnews();
            return View(model);
        }
        //Chuyên tin tin tức
        public ActionResult Archive_news()
        {
            return View();
        }

        //Chuyên tin lẻ Pc
        public ActionResult Pcs_news()
        {
            return View();
        }
        //Chuyên tin lẻ Mobile
        public ActionResult Mobile_news()
        {
            return View();
        }
        //Chuyên tin lẻ Tablet
        public ActionResult Tablet_news()
        {
            return View();
        }
        //Chuyên tin lẻ Tablet
        public ActionResult Camera_news()
        {
            return View();
        }
        //Chuyên tin lẻ Tablet
        public ActionResult Windows_news()
        {
            return View();
        }

        //Chuyên tin lẻ Sức khỏe
        public ActionResult Suckhoe_news()
        {
            return View();
        }
        //Chuyên tin lẻ movie
        public ActionResult Dulich_news()
        {
            return View();
        }
        //Chuyên tin lẻ Ảnh
        public ActionResult Phongthuy_news()
        {
            return View();
        }
        //Chuyên tin lẻ Ẩm thực
        public ActionResult Amthuc_news()
        {
            return View();
        }
        //Chuyên tin lẻ Phong cách
        public ActionResult Lifestyle_news()
        {
            return View();
        }
        //Chuyên tin lẻ Auto
        public ActionResult Auto_news()
        {
            return View();
        }
        //Chuyên tin lẻ Kinh doanh
        public ActionResult Kinhdoanh_news()
        {
            return View();
        }

        //Infactnews
        public ActionResult infact_news()
        {
            return View();
        }
        
        //Blog
        public ActionResult Blog()
        {
            return View();
        }

    }
}