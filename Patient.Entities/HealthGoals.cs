using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class HealthGoals:IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string GoalDescription { get; set; } 
        public DateTime TargetDate { get; set; } 
        public bool IsAchieved { get; set; } // Hedefe ulaşıldı mı 
        public virtual PPatient Patient { get; set; }   
    }

}
