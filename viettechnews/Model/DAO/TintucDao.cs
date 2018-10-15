using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class TintucDao
    {
        viettechnewsDbContext db = null;
        public TintucDao()
        {
            db = new viettechnewsDbContext();
        }

        //Lấy tin trang nhất
        public List<Tintuc> Tintrangnhat()
        {
            return db.Tintucs.Where(x => x.Tags=="index" && x.Status == true).ToList();
        }

        //Lấy danh sách danh mục tin thế giới. Chỉ lấy 1 tin đầu tiên
        public List<Tintuc> Tinword(int catid)
        {
            return db.Tintucs.Where(x => x.CategoryId == 3 && x.Status==true).OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }

        //Lấy danh sách danh mục tin thế giới. 
        public List<Tintuc> Tinwordright(int catid)
        {
            return db.Tintucs.Where(x => x.CategoryId == catid && x.Status == true).OrderByDescending(x => x.CreateDate).Skip(1).Take(3).ToList();
        }
        //Lấy danh sách danh mục tin công nghệ. 
        public List<Tintuc> Tincongnghe3(int catid)
        {
            return db.Tintucs.Where(x => x.CategoryId == catid && x.Status == true).OrderByDescending(x => x.CreateDate).Skip(2).Take(1).ToList();
        }
        //Lấy danh sách danh mục tin công nghệ. 
        public List<Tintuc> Tincongnghe4(int catid)
        {
            return db.Tintucs.Where(x => x.CategoryId == catid && x.Status == true).OrderByDescending(x => x.CreateDate).Skip(3).Take(1).ToList();
        }

        //Lấy tin cho trang News Index
        //Lấy 4 tin top
        public List<Tintuc> Tintopnghop()
        {
            return db.Tintucs.Where(x => x.Status == true && x.CategoryId != 22 && x.CategoryId != 1 && x.CategoryId != 23).OrderByDescending(x => x.CreateDate).Skip(2).Take(4).ToList();
        }

        // Lấy ra tin breaking
        public List<Tintuc> ListTop3mn_bRek()
        {
            return db.Tintucs.Where(x => x.Status == true).OrderByDescending(x => x.ViewNo).Take(5).ToList();
        }

        // Lấy ra 3 tin mới nhất trong chuyên mục Công nghệ
        public List<Tintuc> ListTop3mn_CN(int catid)
        {
            return db.Tintucs.Where(x => x.CategoryId == catid && x.Status == true).OrderByDescending(x => x.ViewNo).Take(3).ToList();
        }

        // Lấy ra 3 tin mới nhất trong chuyên mục Công nghệ
        public List<Tintuc> ListTop3mn()
        {
            return db.Tintucs.Where(x =>x.Status == true).OrderByDescending(x => x.ViewNo).Take(3).ToList();
        }

        //Lấy ra tin cho Slide
        //Lấy 3 tin công nghệ mới nhất
        public List<Tintuc> ListTop1cm2()
        {
            return db.Tintucs.Where(x => x.Status == true && x.Tags != "index" && x.CategoryId != 22 && x.CategoryId != 23).OrderByDescending(x => x.CreateDate).Take(3).ToList();
        }

        //Tin phổ biến
        //Lấy tin top view 
        public List<Tintuc> TrendingNews1()
        {
            return db.Tintucs.Where(x => x.Status == true).OrderByDescending(x => x.ViewNo).Take(1).ToList();
        }
        public List<Tintuc> TrendingNews2()
        {
            return db.Tintucs.Where(x => x.Status == true).OrderByDescending(x => x.ViewNo).Skip(1).Take(1).ToList();
        }
        public List<Tintuc> TrendingNews3()
        {
            return db.Tintucs.Where(x => x.Status == true).OrderByDescending(x => x.ViewNo).Skip(2).Take(1).ToList();
        }
        public List<Tintuc> TrendingNews4()
        {
            return db.Tintucs.Where(x => x.Status == true).OrderByDescending(x => x.ViewNo).Skip(3).Take(1).ToList();
        }
        public List<Tintuc> TrendingNews5()
        {
            return db.Tintucs.Where(x => x.Status == true).OrderByDescending(x => x.ViewNo).Skip(4).Take(1).ToList();
        }

        //Lấy tin đầu tiên và mới nhất cho chuyên tin giải trí
        public List<Tintuc> Tintop1Giaitri()
        {
            return db.Tintucs.Where(x => x.CategoryId == 2 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }
        //Lấy 3 tin giải trí
        public List<Tintuc> Tintop3Giaitri()
        {
            return db.Tintucs.Where(x => x.CategoryId == 2 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).Take(3).ToList();
        }

        //Lấy tin đầu tiên và mới nhất cho chuyên tin thể thao
        public List<Tintuc> Tintop1Sport()
        {
            return db.Tintucs.Where(x => x.CategoryId == 4 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }
        //Lấy 3 tin thể thao
        public List<Tintuc> Tintop3Sport()
        {
            return db.Tintucs.Where(x => x.CategoryId == 4 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).Take(3).ToList();
        }

        //Lấy tin đầu tiên và mới nhất cho chuyên tin thể thao
        public List<Tintuc> Tintop1gaming()
        {
            return db.Tintucs.Where(x => x.CategoryId == 5 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }
        //Lấy 3 tin thể thao
        public List<Tintuc> Tintop3gaming()
        {
            return db.Tintucs.Where(x => x.CategoryId == 5 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).Take(3).ToList();
        }

        //Lấy tin cho view Tintuc
        //Lấy tin số 1 cho phần bên trái
        public List<Tintuc> tintuctrai1()
        {
            return db.Tintucs.Where(x => x.CategoryId == 7 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }
        //Lấy tin số 234 cho phần bên trái
        public List<Tintuc> tintuctrai234()
        {
            return db.Tintucs.Where(x => x.CategoryId == 7 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).Take(3).ToList();
        }
        //Lấy tin số 1 cho phần bên phải
        public List<Tintuc> tintucphai1()
        {
            return db.Tintucs.Where(x => x.CategoryId == 7 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(4).Take(1).ToList();
        }
        //Lấy tin số 234 cho phần bên trái
        public List<Tintuc> tintucphai234()
        {
            return db.Tintucs.Where(x => x.CategoryId == 7 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(5).Take(3).ToList();
        }

        //Lấy tin cho view Tin công nghệ
        //Lấy tin số 1 cho phần bên trái
        public List<Tintuc> tintuctrai1_cn()
        {
            return db.Tintucs.Where(x => x.CategoryId == 1 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }
        //Lấy tin số 234 cho phần bên trái
        public List<Tintuc> tintuctrai234_cn()
        {
            return db.Tintucs.Where(x => x.CategoryId == 1 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).Take(3).ToList();
        }
        //Lấy tin số 1 cho phần bên phải
        public List<Tintuc> tintucphai1_cn()
        {
            return db.Tintucs.Where(x => x.CategoryId == 1 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(4).Take(1).ToList();
        }
        //Lấy tin số 234 cho phần bên trái
        public List<Tintuc> tintucphai234_cn()
        {
            return db.Tintucs.Where(x => x.CategoryId == 1 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(5).Take(3).ToList();
        }
        public Tintuc Detail_News(int id)
        {
            return db.Tintucs.Find(id);
        }
        //Lấy tin số 234 cho phần bên trái
        public List<Tintuc> getnews(int id)
        {
            return db.Tintucs.Where(x => x.CategoryChildId == id && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).Take(4).ToList();
        }

        //Chuyên mục giải trí
        public List<Tintuc> getnews_giaitri()
        {
            return db.Tintucs.Where(x => x.CategoryId == 2 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Chuyên mục công nghệ
        public List<Tintuc> getnews_congnghe()
        {
            return db.Tintucs.Where(x => x.CategoryId == 1 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).ToList();
        }
        //Chuyên mục công nghệ 1
        public List<Tintuc> getnews_congnghe_getone()
        {
            return db.Tintucs.Where(x => x.CategoryId == 1 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }

        //Chuyên mục thế giới
        public List<Tintuc> getnews_thegioi()
        {
            return db.Tintucs.Where(x => x.CategoryId == 3 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Chuyên mục thể thao
        public List<Tintuc> getnews_thethao()
        {
            return db.Tintucs.Where(x => x.CategoryId == 4 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Chuyên mục gaming
        public List<Tintuc> getnews_gaming()
        {
            return db.Tintucs.Where(x => x.CategoryId == 5 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Chuyên mục phong thủy
        public List<Tintuc> getnews_kientruc()
        {
            return db.Tintucs.Where(x => x.CategoryId == 6 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Chuyên mục news
        public List<Tintuc> getnews_news()
        {
            return db.Tintucs.Where(x => x.CategoryId == 7 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Top 5 xem nhiều
        public List<Tintuc> top5viewnhieu()
        {
            return db.Tintucs.Where(x => x.Status == true && x.Tags != "index").OrderByDescending(x => x.ViewNo).Take(4).ToList();
        }

        public List<Tintuc> chuyenmuc(int id)
        {
            return db.Tintucs.Where(x => x.Status == true && x.CategoryId == id && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(6).ToList();
        }

        //Chuyên mục tin nhỏ pcs.
        public List<Tintuc> Pcs_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 8 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ pcs.
        public List<Tintuc> Mobile_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 9 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ tablet.
        public List<Tintuc> Tablet_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 10 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ cảera.
        public List<Tintuc> Camera_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 11 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ windows.
        public List<Tintuc> Windows_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 12 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Chuyên mục tin nhỏ sk.
        public List<Tintuc> Suckhoe_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 13 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ mve.
        public List<Tintuc> Movie_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 14 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ pic.
        public List<Tintuc> Picture_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 15 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ amt.
        public List<Tintuc> Amthuc_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 16 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ lf.
        public List<Tintuc> Lifestyle_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 17 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ auto.
        public List<Tintuc> Auto_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 19 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Chuyên mục tin nhỏ kd.
        public List<Tintuc> Kinhdoanh_news()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 20 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }

        //Blog
        public List<Tintuc> Blog()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 22 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).ToList();
        }
        //Blog top
        public List<Tintuc> Blog_top5()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 22 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(5).ToList();
        }

        //Tin infact
        public List<Tintuc> infact_detailnews()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 23 && x.Status == true && x.Tags != "index").OrderByDescending(x=>x.CreateDate).Take(1).ToList();
        }

        //Tin infact list to
        public List<Tintuc> infact_list_top()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 23 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Take(1).ToList();
        }
        //Tin infact list nhỏ
        public List<Tintuc> infact_list_tin()
        {
            return db.Tintucs.Where(x => x.CategoryChildId == 23 && x.Status == true && x.Tags != "index").OrderByDescending(x => x.CreateDate).Skip(1).ToList();
        }

        public void UpdateViewNo(int id)
        {
            var find = db.Tintucs.Find(id);
            find.ViewNo = find.ViewNo + 1;
            db.SaveChanges();
        }
    }
}
