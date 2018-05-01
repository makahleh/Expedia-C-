using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class Index
    {
        [ReadOnly(true)]
        public Offers Offers { get; set; } = new Offers();

        public SearchFilters Filters { get; set; } = new SearchFilters();
    }
}
