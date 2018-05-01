using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class OfferInfo
    {
        [ReadOnly(true)]
        public string SiteID { get; set; }

        [ReadOnly(true)]
        public string Language { get; set; }

        [ReadOnly(true)]
        public string Currency { get; set; }

        [ReadOnly(true)]
        public string UserSelectedCurrency { get; set; }
    }
}
