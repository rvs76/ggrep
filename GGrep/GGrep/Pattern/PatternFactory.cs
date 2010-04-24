using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GGrep.Pattern
{
    class PatternFactory
    {
        public static IPattern GetPattern(GForm _parent, string file)
        {
            switch (Path.GetExtension(file).ToLower())
            {
                //case ".pdf":
                //    return null;
                default:
                    break;
            }
            return new TxtPattern(_parent);
        }
    }
}
