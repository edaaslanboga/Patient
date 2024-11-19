using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class Appointment: IEntity
    {
        public int Id { get; set; }

       
        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        [StringLength(50)]
        public string ReasonForVisit { get; set; }

        // Enum kullanarak status daha anlamlı hale getirildi
        public AppointmentStatus Status { get; set; }

        // Navigation properties
        public virtual PPatient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }

    // Enum tanımı
    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Cancelled
    }

}
