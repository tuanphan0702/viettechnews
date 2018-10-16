using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class DanhmucDao
    {
        viettechnewsDbContext db = null;
        public DanhmucDao()
        {
            db = new viettechnewsDbContext();
        }

        public List<Danhmuc> ListDanhmuc()
        {
            return db.Danhmucs.Where(x => x.Status == true).ToList();
        }

        public List<Danhmuc> ListDM_chuyenmuc(int catit)
        {
            return db.Danhmucs.Where(x => x.CategoryId == catit).ToList();
        }

        //Lấy riêng danh mục công nghệListDM_subCN
        public List<Danhmuc> ListDM_subCN()
        {
            return db.Danhmucs.OrderBy(x=>x.OrderNo).Skip(1).Take(5).ToList();
        }

        //Lấy riêng danh mục công nghệ
        public List<Danhmuc> ListDM_CN()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 1).ToList();
        }

        //Lấy riêng danh mục thế giới
        public List<Danhmuc> ListDM_TG()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 3).ToList();
        }

        //Lấy riêng danh mục trong chuyên tin công nghệ
        public List<Danhmuc> ListDM_CN_child()
        {
            return db.Danhmucs.Where(x => x.ParentId == 1 && x.CategoryId != 1).OrderByDescending(x => x.ParentId).ToList();
        }

        //Lấy riêng tin tức News CHA
        public List<Danhmuc> ListDM_News()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 7).ToList();
        }
        //Lấy riêng tin tức News con
        public List<Danhmuc> ListDM_Newschild()
        {
            return db.Danhmucs.Where(x => x.ParentId==7 && x.CategoryId != 7).OrderByDescending(x => x.ParentId).ToList();
        }

        //Lấy chuyên mục tin giải trí
        public List<Danhmuc> tendanhmuc_gt()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 2).ToList();
        }

        //Lấy chuyên mục tin Sport
        public List<Danhmuc> tendanhmuc_tt()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 4).ToList();
        }

        //Lấy chuyên mục tin Gamming
        public List<Danhmuc> tendanhmuc_gaming()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 5).ToList();
        }

        //Lấy chuyên mục tin kientruc
        public List<Danhmuc> tendanhmuc_kientruc()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 6).ToList();
        }

        //Lấy toàn bộ danh mục -tin tức
        public List<Danhmuc> danhmuc()
        {
            return db.Danhmucs.Where(x => x.CategoryId <=7).ToList();
        }

        //Lấy danh mục tin tức
        public List<Danhmuc> danhmuc_news()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 7).ToList();
        }

        //Lấy danh mục auto
        public List<Danhmuc> dm_auto()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 19).ToList();
        }

        public List<Danhmuc> getmnmb() // lấy menu 1 và menu 7
        {
            return db.Danhmucs.Where(x => x.CategoryId == 7 || x.CategoryId == 1).ToList();
        }

        //
        public List<Danhmuc> danhmuc_menumain()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 2 || x.CategoryId == 3 || x.CategoryId == 4 || x.CategoryId == 5 || x.CategoryId == 6).ToList();
        }

        //dm pc
        public List<Danhmuc> dm_pcs()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 8).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_mobile()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 9).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_tablet()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 10).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_camera()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 11).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_windows()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 12).ToList();
        }

        //dm pc
        public List<Danhmuc> dm_suckhoe()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 13).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_dulich()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 14).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_phongthuy()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 15).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_amthuc()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 16).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_lifest()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 17).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_kinhdoanh()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 20).ToList();
        }
        //dm pc
        public List<Danhmuc> dm_blog()
        {
            return db.Danhmucs.Where(x => x.CategoryId == 22).ToList();
        }

    }
}
