using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public class ICampaignManager
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
