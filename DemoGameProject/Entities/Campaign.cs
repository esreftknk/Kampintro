using DemoGameProject.Entities;

namespace DemoGameProject.Concrete
{
    public class Campaign : IEntity
    {
        public string CampaignType { get; set; }
        public string CampaignName { get; set; }
    }
}