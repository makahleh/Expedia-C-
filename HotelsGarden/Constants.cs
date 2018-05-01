namespace HotelsGarden
{
    public static class Constants
    {
        // ToDo: Move these const to configuration
        public const string BaseApiUrl = "https://offersvc.expedia.com";
        public const string BaseResourceUrl = "/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel";
        public const string AcceptHeaderMediaType = "application/json";
        public const string DateFormat = "dd MMM yyyy";
        public const string DateTimeFormat = "dd MMM yyyy HH:mm:ss";
        public const string ApiDateTimeFormat = "yyyy-MM-dd";
        public const string JavascriptDateTimeFormat = "yyyy-MM-dd";
    }
}
