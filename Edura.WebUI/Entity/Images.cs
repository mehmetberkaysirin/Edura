using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Images
    {
        [Key]
        public int ImageID { get; set; }
        public string  ImageName { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}
