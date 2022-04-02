using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    [Table("User")]
    public class User
    {
        [Key]

        public int UserID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string Mobile { get; set; }
        [StringLength(50)]

        public string Email { get; set; }
        [StringLength(32)]

        public string PassWord { get; set; }

        public DateTime Registered { get; set; }

        public DateTime LastLogin { get; set; }

        public string InTro { get; set; }

        [DataType(DataType.Text)]
        public string Profile { get; set; }

        [DataType(DataType.Text)]
        public string Role { get; set; }

        //Ở User, vì là table n, nên ta phải khai báo thêm 1 ICollection<Post>, điều này giúp chúng ta có thể Join,
        public ICollection<Post> Posts { get; set; }
        public ICollection<PostComment> PostComments { get; set; }


    }
}
