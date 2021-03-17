using DemoGameProject.Concrete;
using DemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Abstract
{
   public interface ISaleService
    {
        void SaleOperation(Campaign campaign, GameProduct gameProduct);
    }
}
