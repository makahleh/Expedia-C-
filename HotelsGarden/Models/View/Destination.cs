using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class Destination
    {
        [ReadOnly(true)]
        public string RegionID { get; set; }

        [ReadOnly(true)]
        public string AssociatedMultiCityRegionId { get; set; }

        [ReadOnly(true)]
        public string LongName { get; set; }

        [ReadOnly(true)]
        public string ShortName { get; set; }

        [ReadOnly(true)]
        public string Country { get; set; }

        [ReadOnly(true)]
        public string Province { get; set; }

        [ReadOnly(true)]
        public string City { get; set; }

        [ReadOnly(true)]
        public string Tla { get; set; }

        [ReadOnly(true)]
        public string NonLocalizedCity { get; set; }
    }
}
