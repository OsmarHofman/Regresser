using System.Collections.Generic;

namespace Regresser.Domain.Shipper
{
    public class Release
    {
        public string ReleaseDomainName { get; set; }

        public string ReleaseXid { get; set; }

        public List<Refnum> ReleaseRefnums { get; set; }
    }
}