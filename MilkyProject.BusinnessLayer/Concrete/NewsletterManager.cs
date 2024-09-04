﻿using MilkyProject.BusinnessLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinnessLayer.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void TDelete(int id)
        {
            _newsletterDal.Delete(id);
        }

        public Newsletter TGetById(int id)
        {
            return _newsletterDal.GetById(id);  
        }

        public List<Newsletter> TGetListAll()
        {
            return _newsletterDal.GetListAll();
        }

        public int TGetTotalNewsletterCount()
        {
            return _newsletterDal.GetTotalNewsletterCount();
        }

        public void TInsert(Newsletter entity)
        {
            _newsletterDal.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
            _newsletterDal.Update(entity);
        }
    }
}
