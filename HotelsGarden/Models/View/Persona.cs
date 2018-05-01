using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class Persona
    {
        [ReadOnly(true)]
        public string PersonaType { get; set; }
    }
}
