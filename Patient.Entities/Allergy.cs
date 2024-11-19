using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class Allergy:IEntity 

    {  public int Id { get; set; }
       public int PatientId { get; set; }
        [StringLength(50)]

        public string Allergen { get; set; }
        [StringLength(50)]

        public string Severity { get; set;} // şiddeti enum mild moderate severe
        [StringLength(50)]
        
        public string Reaction { get; set; }    
        public virtual PPatient Patient { get; set; }

    }
}
