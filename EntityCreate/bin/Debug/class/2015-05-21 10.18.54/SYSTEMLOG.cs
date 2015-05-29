using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMLOG
    {
        public virtual Decimal SYSLOGID { get; set; }
        public virtual String LOGTYPE { get; set; }
        public virtual String LOGFORM { get; set; }
        public virtual String CONTENT { get; set; }
        public virtual DateTime LOGTIME { get; set; }
        public virtual String USERNAME { get; set; }
        public virtual Decimal MENUID { get; set; }
        public virtual String GUID { get; set; }
        public virtual String SYSTEMNAME { get; set; }
    }
}

