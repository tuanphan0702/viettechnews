﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;


namespace Model.DAO
{
    public class NguoidungDao
    {
        viettechnewsDbContext db = null;
        public NguoidungDao()
        {
            db = new viettechnewsDbContext();
        }

        public Nguoidung GetById(string userName)
        {
            return db.Nguoidungs.SingleOrDefault(x => x.Username == userName);
        }

        public int Login(string userName, string passWord)
        {
            var result = db.Nguoidungs.SingleOrDefault(x => x.Username == userName);
            if (result==null)
            {
                return 0;
            }
            else
            {
                if (result.Allowed==false)
                {
                    return -1;
                }
                else
                {
                    if (result.Password == passWord)
                        return 1;
                    else
                        return -2;
                }
            }
        }
    }
}
