using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class HotelUrls
    {
        [ReadOnly(true)]
        public Uri Infosite { get; set; }

        [ReadOnly(true)]
        public Uri SearchResult { get; set; }
    }
}
