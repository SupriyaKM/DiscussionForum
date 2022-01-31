using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3Entity
{
   public class PostModel
    {
        public int Post_Id { set; get; }
        public string Post_Title { set; get; }
        public string Post_Subtitle { set; get; }
        public string Post_Content { set; get; }
        public string Post_status { get; set; }
    }
}
