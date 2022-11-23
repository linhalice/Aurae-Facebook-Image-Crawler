using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurae_Facebook_Image_Crawler
{
    internal class DataNextModel
    {
        public class Datum
        {
            public string full_picture { get; set; }
            public string id { get; set; }
        }

        public class Paging
        {
            public string previous { get; set; }
            public string next { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
            public Paging paging { get; set; }
        }
    }
}
