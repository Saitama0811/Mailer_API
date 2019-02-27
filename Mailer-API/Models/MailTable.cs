using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models
{
    public class MailTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long mail_ID { get; set; }
        [MaxLength(80)] public string mail_from { get; set; }
        [MaxLength(80)] public string mail_to_1 { get; set; }
        [MaxLength(80)] public string mail_to_2 { get; set; }
        [MaxLength(80)] public string mail_to_3 { get; set; }
        [MaxLength(80)] public string mail_to_4 { get; set; }
        [MaxLength(80)] public string mail_to_5 { get; set; }
        [MaxLength(100)] public string mail_subject { get; set; }
        [MaxLength(5000)] public string mail_body { get; set; }
        public DateTime mail_date { get; set; }
        public string mail_status { get; set; }
        public int is_starred { get; set; }
        public int is_important { get; set; }
        public string sender_delete_status { get; set; }
        public string receiver_delete_status { get; set; }
        [MaxLength(100)] public string attachment_1 { get; set; }
        [MaxLength(100)] public string attachment_2 { get; set; }
        [MaxLength(100)] public string attachment_3 { get; set; }
        [MaxLength(100)] public string attachment_4 { get; set; }
        [MaxLength(100)] public string attachment_5 { get; set; }

    }
}
