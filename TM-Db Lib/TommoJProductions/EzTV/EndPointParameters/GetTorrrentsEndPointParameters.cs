using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TommoJProductions.EzTV.EndPointParameters
{
    public class GetTorrrentsEndPointParameters
    {
        public int limit { get; set; } = 30;
        public int page { get; set; } = 1;
        public string imdb_id { get; set; }
    }
}
