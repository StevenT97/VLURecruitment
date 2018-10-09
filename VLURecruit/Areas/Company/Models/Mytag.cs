using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VLURecruit.Models;

namespace VLURecruit.Areas.Company.Models
{
    public class Mytag
    {
        public int[] SelectId { get; set; }
        public IEnumerable<Tag> Item { get; set; }
    }
}