using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class UserAccepted
    {
        [Key]
        public int Id { get; set; }
        public DateTime DoC { get; set; }
        public string FName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IPLocation { get; set; }
        public string FUrl { get; set; }
        public int ProjectId { get; set; }
        public int DocumentId { get; set; }
        public bool Confirm { get; set; }
        public string FormPage { get; set; }
    }
}
