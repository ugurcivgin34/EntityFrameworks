using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndAdpp_GenericDAL.DAL;
using WndAdpp_GenericDAL.Model;

namespace WndAdpp_GenericDAL.BLL
{
    public class GnBLL<T> where T : class,IEntity
    {
        GnFilmDB db;
        //Dependecny Injection olmalı..
        public GnBLL(GnFilmDB _db)
        {
            db = _db;
        }

        public void Ekle(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public List<T> Liste()
        {
            return db.Set<T>().ToList();
        }
    }
}
