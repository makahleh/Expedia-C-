﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using HotelsGarden.Models.Domain.Expedia;
using Newtonsoft.Json;

namespace HotelsGarden.Models.Domain
{
    public class ExpediaOffers
    {
        [JsonProperty("offerInfo")]
        public OfferInfo OfferInfo { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("offers")]
        public Offers Offers { get; set; }
    }
}
