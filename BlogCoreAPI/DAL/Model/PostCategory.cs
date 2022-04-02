using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PostCategory
    {
        public int PostID { get; set; }
        public int CategoryID { get; set; }
        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}
