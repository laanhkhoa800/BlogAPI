using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model.ViewModel
{
    public class ViewPostAndComment
    {
        public Post ListPost { get; set; }
        public IEnumerable<PostComment> ListComment { get; set; }
    }
}
