using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class Billing :IEntity
    { 
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int AppointmentId { get; set; }  
        public decimal Amount { get; set; } 
        public DateTime BillingDate { get; set; }
        [StringLength(50)]

        public string PaymentStatus { get; set; }   // enum paid unpaid partiallypaid
        public virtual PPatient Patient { get; set; }
        public virtual Appointment Appointment { get; set; } 
    }
}
