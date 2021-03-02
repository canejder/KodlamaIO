using System;
using System.Collections.Generic;

namespace GameMarketingProject.Business
{
    public class CampaignManager : IRegistryManager
    {
        private Campaign _campaign;
        private List<Campaign> _campaigns;
        public CampaignManager()
        {
            _campaigns = new List<Campaign>();
        }

        public void Create(IManagable campaign)
        {
            _campaign = (Campaign)campaign;
            _campaigns.Add(_campaign);
            Console.WriteLine("Kampanya oluşturuldu: " + _campaign.Name);
        }

        public void Update(IManagable campaign)
        {
            _campaign = (Campaign)campaign;
            _campaigns.Remove(_campaign);
            _campaigns.Add(_campaign);
            Console.WriteLine("Kampanya güncellendi: " + _campaign.Name);
        }

        public void Delete(IManagable campaign)
        {
            _campaign = (Campaign)campaign; 
            _campaigns.Remove(_campaign);
            Console.WriteLine("Kampanya silindi: " + _campaign.Name);
        }
        public Campaign ApplyCampaign(string campaignName)
        {
            foreach (Campaign campaign in _campaigns)
            {
                if (campaign.Name.Contains(campaignName))
                {
                    _campaign = campaign;
                }
            }
            return _campaign;
        }
    }
}