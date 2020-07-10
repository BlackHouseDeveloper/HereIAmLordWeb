using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Identity;

namespace HereIAmAPI.Model
{
    public class Profile : IdentityUser<Guid>
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(20)]
        public string FName { get; set; }

        [Required, StringLength(20)]
        public string LName { get; set; }

        [Required]
        public DateTime Bday { get; set; }

        

        [Required, StringLength(500)]
        public string Description { get; set; }
        public string ImagePath { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }

        public string UserId { get; set; }

        


    }
}
