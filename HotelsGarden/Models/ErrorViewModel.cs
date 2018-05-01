using System.ComponentModel;

namespace HotelsGarden.Models
{
    public class ErrorViewModel
    {
        [ReadOnly(true)]
        public string RequestId { get; set; }

        [ReadOnly(true)]
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}