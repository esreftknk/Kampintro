using DemoGameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Concrete
{
    class CampaingManager
    {
        public class CampaignManager : ICampaignService
        {
            public void Add(Campaign campaign)
            {
                Console.WriteLine(campaign.CampaignName + " isimli kampanya tanımlandı");
            }

            public void Delete(Campaign campaign)
            {
                Console.WriteLine(campaign.CampaignName + "isimli kampanya sonlandırıldı!");
            }

            public void Update(Campaign campaign)
            {
                Console.WriteLine(campaign.CampaignName + "isimli kampanya güncellendi");
            }
        }
    }
}
