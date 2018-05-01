using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class UserInfo
    {
        [ReadOnly(true)]
        public Persona Persona { get; set; }

        [ReadOnly(true)]
        public string UserId { get; set; }
    }
}
