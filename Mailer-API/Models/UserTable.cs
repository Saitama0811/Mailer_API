using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models
{
    public class UserTable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long user_ID { get; set; }

        [MaxLength(20)]public string first_name { get; set; }
        [MaxLength(20)] public string second_name { get; set; }
        [MaxLength(20)] public string username { get; set; }
        [MaxLength(16)] public string password { get; set; }
        [MaxLength(10)] public string phone_number { get; set; }

    }
}
