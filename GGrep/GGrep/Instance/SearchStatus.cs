using System;
using System.Collections.Generic;
using System.Text;

namespace GGrep.Instance
{
    public class SearchStatus
    {
        private long hit = 0;
        public long Hit
        {
            get { return hit; }
            set { hit = value; }
        }
        private long total = 0;
        public long Total
        {
            get { return total; }
            set { total = value; }
        }
        private long finished = 0;
        public long Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        public int Progress
        {
            get { return (int)((double)finished * 100 / total); }
        }
    }
}
