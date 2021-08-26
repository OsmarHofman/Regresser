using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper
{
    public class ReleaseRefnum
    {
        public string ReleaseXid { get; set; }

        public List<Refnum> ReleaseRefnums { get; set; }

        public ReleaseRefnum(string releaseXid)
        {
            ReleaseXid = releaseXid;
            ReleaseRefnums = new List<Refnum>();
        }

        public ReleaseRefnum(string releaseXid, List<Refnum> releaseRefnums)
        {
            ReleaseXid = releaseXid;
            ReleaseRefnums = releaseRefnums;
        }
    }
}
