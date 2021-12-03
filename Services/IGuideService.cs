using System.Collections.Generic;

namespace BardsKingPage.Services
{
    public interface IGuideService
    {
        void AddGuide(Guide newGuide);
        List<Guide> GetGuides();
    }
}