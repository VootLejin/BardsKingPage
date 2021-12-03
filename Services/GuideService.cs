using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BardsKingPage.Services
{
    public class GuideService : IGuideService
    {
        private List<Guide> Guides = new List<Guide>
        {
            new Guide
            {
                Title = "Priconne Global: Gear and Stat Recommendations",
                Description = "Quick reference for how far to gear up a character. Good for quick reference and very easy to understand.",
                Link = new Uri(@"https://docs.google.com/spreadsheets/d/18VjvDwBrTinuWtqbxUxo0BNOvFpmztFO2p2D03tUxdA/edit#gid=1845258668"),
                Id = 0
            },
            new Guide
            {
                Title = "Princess Connect (Priconne) - Unique Equipment (UE) Chart",
                Description = "Indepth Guide for Unique Equipments (UE). Advanced, and not suitable for a quick read.",
                Link = new Uri(@"https://docs.google.com/spreadsheets/d/e/2PACX-1vQhgyX9t1IJ1dafnjksIg09cy0Wv_NiYZM3THtNjgtWD6WZSQPt0R_aVlFI-K-HnshqJndkyppihGfL/pubhtml#"),
                Id = 1
            }
        };

        public void AddGuide(Guide newGuide)
        {
            newGuide.Id = Guides.Count + 1;
            Guides.Add(newGuide);
        }

        public List<Guide> GetGuides()
        {
            return Guides;
        }
    }
}
