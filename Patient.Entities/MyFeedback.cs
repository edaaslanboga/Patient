using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class MyFeedback :IEntity
    {   
        public int Id { get; set; }
        
        public int PatientID { get; set; } 
        public DateTime FeedbackDate { get; set; }
        [StringLength(50)]


        public string FeedbackText { get; set; } 
        public int Rating { get; set; } 
        public virtual PPatient Patient { get; set; }
    }

}
