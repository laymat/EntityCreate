using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMUSERORGANIZATION
    {
        public virtual Decimal ID { get; set; }
        public virtual String USERID { get; set; }
        public virtual Decimal ORGANIZATIONTYPE { get; set; }
        public virtual String ORGANIZATIONID { get; set; }
    }
}

