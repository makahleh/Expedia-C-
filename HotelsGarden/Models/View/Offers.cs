using System.Collections.Generic;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class Offers
    {
        [ReadOnly(true)]
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
    }
}
