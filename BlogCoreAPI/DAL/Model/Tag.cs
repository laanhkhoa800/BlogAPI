using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    [Table("Tag")]
    public class Tag
    {
        [Key]

        public int TagID { get; set; }
        [StringLength(75)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTile { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
