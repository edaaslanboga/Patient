using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class PatientPreferences:IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string PreferredContactMethod { get; set; }
        public bool LikesEmailNotifications { get; set; } 
        public bool LikesSMSNotifications { get; set; } 
        public virtual PPatient Patient { get; set; }
    }

}
