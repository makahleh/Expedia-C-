using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class Hotel
    {
        [ReadOnly(true)]
        public OfferDateRange OfferDateRange { get; set; }

        [ReadOnly(true)]
        public Destination Destination { get; set; }

        [ReadOnly(true)]
        public HotelInfo Info { get; set; }

        [ReadOnly(true)]
        public HotelUrgencyInfo UrgencyInfo { get; set; }

        [ReadOnly(true)]
        public HotelPricingInfo PricingInfo { get; set; }

        [ReadOnly(true)]
        public HotelUrls Urls { get; set; }
    }
}
