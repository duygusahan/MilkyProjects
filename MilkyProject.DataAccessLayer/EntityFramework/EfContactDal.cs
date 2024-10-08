﻿using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(MilkyContext context) : base(context)
        {
        }

        public List<Contact> GetLast4Contact()
        {
            using (var context = new MilkyContext())
            {
                return context.Contacts.OrderByDescending(x => x.ContactId).Take(4).ToList();
            }
        }

        public int GetTotalContactCount()
        {
            using (var context = new MilkyContext())
            {
                return context.Contacts.Count();
            }
        }

        
    }
}
