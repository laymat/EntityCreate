using System;

namespace 
{
    [Serializable]
    public class ST_SYSLOG_E
    {
        public virtual Decimal LOGLSH { get; set; }
        public virtual String LOGTYPE { get; set; }
        public virtual String LOGCONTENT { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

