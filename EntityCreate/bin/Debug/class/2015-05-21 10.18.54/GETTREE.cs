using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class GETTREE
    {
        public virtual String ID { get; set; }
        public virtual String TYPE { get; set; }
        public virtual String NAME { get; set; }
        public virtual String PID { get; set; }
        public virtual String LV { get; set; }
    }
}

