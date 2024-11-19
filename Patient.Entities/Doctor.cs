using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class Doctor :IEntity 
    {  public int Id { get; set; }
        [StringLength(50)]

        public string FirstName { get; set; }
        [StringLength(50)]

        public string LastName { get; set; }
        [StringLength(50)]

        public string Speciliation { get; set; }
        [StringLength(50)]

        public string PhoneNumber { get; set; }
        [StringLength(50)]

        public string Email { get; set; }
        public int Scor { get; set; }//????????????????
        

    }
}
