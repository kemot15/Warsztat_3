using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warsztat_3.Models
{
    public class PersonModel
    {
        [Required]
        public int ID { get; set; }
        [Required, DisplayName("Imię"), StringLength(50)]
        public string FirstName { get; set; }
        [Required, DisplayName("Nazwisko"), StringLength(50)]
        public string LastName { get; set; }
        [Required, DisplayName("Telefon"), Range(111111111,999999999)]
        public int Phone { get; set; }
        [Required, DisplayName("E-mail"), StringLength(50)]
        public string Email { get; set; }
        [Required, DisplayName("Utworzono")]
        public DateTime Created { get; set; }
        [DisplayName("Zmodyfikowano")]
        public DateTime? Updated { get; set; }
    }
}