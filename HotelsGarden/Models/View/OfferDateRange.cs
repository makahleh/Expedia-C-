using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class OfferDateRange
    {
        [ReadOnly(true)]
        public DateTime TravelStartDate { get; set; }

        [ReadOnly(true)]
        public DateTime TravelEndDate { get; set; }

        [ReadOnly(true)]
        public int LengthOfStay { get; set; }

        [ReadOnly(true)]
        public string TravelStartDateString => TravelStartDate.ToString(Constants.DateFormat);

        [ReadOnly(true)]
        public string TravelEndDateString => TravelEndDate.ToString(Constants.DateFormat);
    }
}
