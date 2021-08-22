using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper
{
    public class ReleaseRefnum
    {
        public string ReleaseXid { get; set; }

        public Dictionary<string, string> ReleaseRefnums { get; set; }

        public ReleaseRefnum(string releaseXid)
        {
            ReleaseXid = releaseXid;
            ReleaseRefnums = new Dictionary<string, string>();
        }

        public ReleaseRefnum(string releaseXid, Dictionary<string, string> releaseRefnums)
        {
            ReleaseXid = releaseXid;
            ReleaseRefnums = releaseRefnums;
        }
    }
}
