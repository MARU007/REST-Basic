using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rest2.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public decimal? Weight { get; set; }
        [ForeignKey("IdNavigationVirtual")]
        public int IdNavigation { get; set; }
        public virtual Address IdNavigationVirtual { get; set; }

    }
}
