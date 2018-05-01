using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class HotelPricingInfo
    {
        [ReadOnly(true)]
        public double AveragePriceValue { get; set; }

        [ReadOnly(true)]
        public double TotalPriceValue { get; set; }

        [ReadOnly(true)]
        public double CrossOutPriceValue { get; set; }

        [ReadOnly(true)]
        public double OriginalPricePerNight { get; set; }

        [ReadOnly(true)]
        public string Currency { get; set; }

        [ReadOnly(true)]
        public double PercentSavings { get; set; }

        [ReadOnly(true)]
        public bool Drr { get; set; }
    }
}
