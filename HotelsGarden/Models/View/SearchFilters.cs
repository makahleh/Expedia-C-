using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class SearchFilters
    {
        [DisplayName("Destination Name *")]
        public string DestinationName { get; set; } = String.Empty;

        [DisplayName("Minimum Trip Starting Date *")]
        public DateTime? MinTripStartDate { get; set; }

        [DisplayName("Maximum Trip Starting Date *")]
        public DateTime? MaxTripStartDate { get; set; }

        [DisplayName("Length of Stay *")]
        public int? LengthOfStay { get; set; }

        [DisplayName("Minimum Star Rating *")]
        public double? MinStarRating { get; set; }

        [DisplayName("Maximum Star Rating *")]
        public double? MaxStarRating { get; set; }

        [DisplayName("Minimum Total Rate *")]
        public double? MinTotalRate { get; set; }

        [DisplayName("Maximum Total Rate *")]
        public double? MaxTotalRate { get; set; }

        [DisplayName("Minimum Guest Rating *")]
        public double? MinGuestRating { get; set; }

        [DisplayName("Maximum Guest Rating *")]
        public double? MaxGuestRating { get; set; }
    }
}
