﻿using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinnessLayer.Abstract
{
    public interface IServiceService:IGenericService<Service>
    {
        public int TGetTotalServiceCount();
    }
}
