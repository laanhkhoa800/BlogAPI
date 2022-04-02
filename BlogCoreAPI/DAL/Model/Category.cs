using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public int ParentID { get; set; }
        [StringLength(75)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTile { get; set; }
        [StringLength(100)]
        public string Slug { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }
        public ICollection<PostCategory> PostCategorys { get; set; }
    }
}
