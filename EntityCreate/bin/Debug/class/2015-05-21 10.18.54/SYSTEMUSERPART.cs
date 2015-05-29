using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMUSERPART
    {
        public virtual Decimal ID { get; set; }
        public virtual String USERID { get; set; }
        public virtual String PARTID { get; set; }
    }
}

