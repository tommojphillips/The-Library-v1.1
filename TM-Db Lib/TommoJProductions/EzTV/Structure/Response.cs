using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TommoJProductions.EzTV.Structure
{
    public class Response
    {
        public string imdb_id;
        public int torrents_count;
        public int limit;
        public int page;
        public GetTorrentsInfo[] torrents;
    }
}
