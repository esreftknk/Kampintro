﻿using DemoGameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
