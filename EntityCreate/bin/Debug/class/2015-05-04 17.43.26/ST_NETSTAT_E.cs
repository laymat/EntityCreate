using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_NETSTAT_E
    {
        public virtual String INSTCD { get; set; }
        public virtual DateTime CHANGETIME { get; set; }
        public virtual String NETTYPE { get; set; }
        public virtual String NETSTATUS { get; set; }
    }
}

