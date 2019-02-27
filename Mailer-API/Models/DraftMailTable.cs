using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models
{
    public class DraftMailTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long draft_mail_ID { get; set; }
        [MaxLength(80)] public string mail_from { get; set; }
        [MaxLength(100)] public string mail_subject { get; set; }
        [MaxLength(5000)] public string mail_body { get; set; }
    }
}
