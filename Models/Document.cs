using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public DateTime DoC { get { return DoC; } set { DoC = DateTime.Now; } }
        public int ProjectId { get; set; }
        public int TypeDocumentId { get; set; }
        public string ContentText { get; set; }
        public string Version { get; set; }
        public bool isActive { get; set; }
             

    }

    public class DocumentType
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get;set;}
    }
   
}
