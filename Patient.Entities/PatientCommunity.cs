using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class PatientCommunity:IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string CommunityName { get; set; }
        [StringLength(50)]

        public string Role { get; set; } // Hasta rolü  enum ?Member, Leader
        public DateTime JoinDate { get; set; } 
        public virtual PPatient Patient { get; set; }
    }

}
