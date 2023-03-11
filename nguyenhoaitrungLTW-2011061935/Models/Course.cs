using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nguyenhoaitrungLTW_2011061935.Models
{
    public class Course
    {
        public int ID { get; set; }

        public ApplicationUser User { get; set; }
        [Required]
        public string LetureId { get; set; }
        [Required]
        [StringLength(255)]
        public string Plase { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }

        [Required]
        public byte CategoryId { get; set; }
    }
    
}