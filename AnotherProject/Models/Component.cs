using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherProject.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string ComponentName { get; set; }
        public string AboutItem { get; set; }
        [DisplayName("Upload File")]
        public string Photo{ get; set; }

        public decimal Price { get; set; }

        public Nullable<int>  CategoryID { get; set; }
        public Category categories { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }


}
