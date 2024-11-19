using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public  class Medication :IEntity

    {  public int Id { get; set; }
        [StringLength(50)]

        public string Name { get; set; }
        [StringLength(50)]

        public string Dosage { get; set; }
        [StringLength(50)]

        public string Frequency { get; set; }
        [StringLength(50)]

        public string SideEffects { get; set; }
        [StringLength(50)]

        public string PrescriptionId { get; set; }
        public virtual Prescripton Prescripton { get; set; }
    }
}
