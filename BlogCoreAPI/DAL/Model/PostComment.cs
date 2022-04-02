using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PostComment
    {
        [Key]

        public int PostCommentID { get; set; }

        public int PostID { get; set; }

        public int ParentID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int Published { get; set; }
        public DateTime CreateAT { get; set; }
        public DateTime PublishedAT { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }
        public Post Post { get; set; }

        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User User { get; set; }
    }
}
