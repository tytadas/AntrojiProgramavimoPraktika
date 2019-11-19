using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web;

namespace AnotherProject.Models
{
    public class Category 
    {

        [Key]
        public int CategoryID { get; set; }
        public string CategoryType { get; set; }
        [DisplayName("Upload File")]
        public string CategoryImage { get; set; }



        public ICollection<Component> components { get; set; } 
    }
}
