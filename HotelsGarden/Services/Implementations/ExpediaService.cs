using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HotelsGarden.Models.Domain;
using HotelsGarden.Models.View;
using Newtonsoft.Json;

namespace HotelsGarden.Services
{
    public class ExpediaService : IExpediaService
    {
        public ExpediaService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private readonly IMapper mapper;

        public async Task<Offers> GetOffersAsync(SearchFilters filters)
        {
            var client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue(Constants.AcceptHeaderMediaType);

            client.BaseAddress = new Uri(Constants.BaseApiUrl);
            client.DefaultRequestHeaders.Accept.Add(contentType);

            var resourceUrl = String.Concat(Constants.BaseResourceUrl, GetQueryString(filters));
            var response = await client.GetAsync(resourceUrl);
            var stringData = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<ExpediaOffers>(stringData);

            var mappedOffers = mapper.Map<Offers>(data.Offers);

            mappedOffers.Hotels = mappedOffers.Hotels
                .OrderByDescending(hotel => hotel.Info.GuestReviewRating)
                .ThenByDescending(hotel => hotel.Info.StarRating)
                .ThenBy(hotel => hotel.PricingInfo.AveragePriceValue)
                .ToList();

            return mappedOffers;
        }

        private string GetQueryString(SearchFilters filters)
        {
            if (filters == null)
            {
                return String.Empty;
            }

            var queryBuilder = new StringBuilder();

            if (!String.IsNullOrWhiteSpace(filters.DestinationName))
            {
                queryBuilder.AppendFormat("&destinationName={0}", Uri.EscapeDataString(filters.DestinationName));
            }

            if (filters.MinTripStartDate.HasValue)
            {
                queryBuilder.AppendFormat("&minTripStartDate=:{0}", filters.MinTripStartDate.Value.ToString(Constants.ApiDateTimeFormat));
            }

            if (filters.MaxTripStartDate.HasValue)
            {
                queryBuilder.AppendFormat("&maxTripStartDate=:{0}", filters.MaxTripStartDate.Value.ToString(Constants.ApiDateTimeFormat));
            }

            if (filters.LengthOfStay.HasValue && filters.LengthOfStay.Value > 0)
            {
                queryBuilder.AppendFormat("&lengthOfStay={0}", filters.LengthOfStay.Value);
            }

            if (filters.MinGuestRating.HasValue && filters.MinGuestRating.Value > 0)
            {
                queryBuilder.AppendFormat("&minGuestRating={0}", filters.MinGuestRating.Value);
            }

            if (filters.MaxGuestRating.HasValue && filters.MaxGuestRating.Value > 0)
            {
                queryBuilder.AppendFormat("&maxGuestRating={0}", filters.MaxGuestRating.Value);
            }

            if (filters.MinStarRating.HasValue && filters.MinStarRating.Value > 0)
            {
                queryBuilder.AppendFormat("&minStarRating={0}", filters.MinStarRating.Value);
            }

            if (filters.MaxStarRating.HasValue && filters.MaxStarRating.Value > 0)
            {
                queryBuilder.AppendFormat("&maxStarRating={0}", filters.MaxStarRating.Value);
            }

            if (filters.MinTotalRate.HasValue && filters.MinTotalRate.Value > 0)
            {
                queryBuilder.AppendFormat("&minTotalRate={0}", filters.MinTotalRate.Value);
            }

            if (filters.MaxTotalRate.HasValue && filters.MaxTotalRate.Value > 0)
            {
                queryBuilder.AppendFormat("&maxTotalRate={0}", filters.MaxTotalRate.Value);
            }

            return queryBuilder.ToString();
        }
    }
}
