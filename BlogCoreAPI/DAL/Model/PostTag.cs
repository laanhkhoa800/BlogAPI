using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PostTag
    {
        public int TagID { get; set; }

        public int PostID { get; set; }
        [StringLength(50)]
        public string Key { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }
        public Post Post { get; set; }
    }
}
