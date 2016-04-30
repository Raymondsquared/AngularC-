using System.Collections.Generic;

namespace AngularCSharp.Core.Models
{
    public class GenderPetsResponseDto
    {
        public string Gender { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }    
}
