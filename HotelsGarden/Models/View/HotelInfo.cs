using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class HotelInfo
    {
        [ReadOnly(true)]
        public string Id { get; set; }

        [ReadOnly(true)]
        public string Name { get; set; }

        [ReadOnly(true)]
        public string LocalizedName { get; set; }

        [ReadOnly(true)]
        public string Destination { get; set; }

        [ReadOnly(true)]
        public string DestinationRegionID { get; set; }

        [ReadOnly(true)]
        public string LongDestination { get; set; }

        [ReadOnly(true)]
        public string StreetAddress { get; set; }

        [ReadOnly(true)]
        public string City { get; set; }

        [ReadOnly(true)]
        public string Province { get; set; }

        [ReadOnly(true)]
        public string CountryCode { get; set; }

        [ReadOnly(true)]
        public double Latitude { get; set; }

        [ReadOnly(true)]
        public double Longitude { get; set; }

        [ReadOnly(true)]
        public string StarRating { get; set; }

        [ReadOnly(true)]
        public double GuestReviewRating { get; set; }

        [ReadOnly(true)]
        public int ReviewTotal { get; set; }

        [ReadOnly(true)]
        public Uri Image { get; set; }

        [ReadOnly(true)]
        public bool VipAccess { get; set; }

        [ReadOnly(true)]
        public bool IsOfficialRating { get; set; }

        [ReadOnly(true)]
        public Uri LocationUrl => new Uri($"https://www.google.com/maps/?q={Latitude},{Longitude}");
    }
}
