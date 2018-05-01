using System.Threading.Tasks;
using HotelsGarden.Models.View;

namespace HotelsGarden.Services
{
    public interface IExpediaService
    {
        Task<Offers> GetOffersAsync(SearchFilters filters);
    }
}