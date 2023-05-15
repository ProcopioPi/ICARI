using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterHound
{
    public class QueryResponse
    {
        public string[] terms;
        public float userScore;
        public float AIScore;
        public List<string> IDs;
        public List<ArticleInfo> articles;
    }
}
