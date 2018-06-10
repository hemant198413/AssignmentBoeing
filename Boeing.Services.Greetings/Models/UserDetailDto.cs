using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boeing.Services.Greetings.Models
{
    public class UserDetailDto
    {
       
        [Required( ErrorMessage = "PersonName is required")]
        [StringLength(100,MinimumLength =1 )]
        public string PersonName { get; set; }

    }
}