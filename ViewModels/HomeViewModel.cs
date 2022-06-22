using System.Collections.Generic;
using Web.Models;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        public List<OurTeamCard> ourTeamCards { get; set; }
        public Settings Settings { get; set; }
    }
}
