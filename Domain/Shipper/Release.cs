using System.Collections.Generic;

namespace Regresser.Domain.Shipper
{
    public class Release
    {
        public string ReleaseDomainName { get; set; }

        public string ReleaseXid { get; set; }

        public Dictionary<string, string> ReleaseRefnums { get; set; }

    }
}