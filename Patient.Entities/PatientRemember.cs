using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class PatientRemember:IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string ReminderText { get; set; } 
        public DateTime ReminderDate { get; set; } 
        public bool IsCompleted { get; set; } 
        public virtual PPatient Patient { get; set; }
    }

}
