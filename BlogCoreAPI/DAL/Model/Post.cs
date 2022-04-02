using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    [Table("Post")]
    public class Post
    {
        [Key]

        public int PostID { get; set; }
        public int AuthorID { get; set; }
        public int ParentID { get; set; }
        [StringLength(75)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTile { get; set; }
        [StringLength(100)]
        public string Slug { get; set; }
        [DataType(DataType.Text)]
        public string Sumary { get; set; }
        public int PubLished { get; set; }
        public DateTime CreateAT { get; set; }

        public DateTime UpdateAT { get; set; }
        public DateTime PublishedAT { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }

        public ICollection<PostCategory> PostCates { get; set; }
        public ICollection<PostMeta> PostMetas { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<PostComment> PostComments { get; set; }

        //Ở Post, ta phải khởi tạo virtual với class mà ta cần Foreign, còn lại hệ thống sẽ tự mapping cho ta.
        //1 post chỉ có một user
        public User users { get; set; }

        [NotMapped]
        public IFormFile ImageUploader { get; set; }
    }
}
