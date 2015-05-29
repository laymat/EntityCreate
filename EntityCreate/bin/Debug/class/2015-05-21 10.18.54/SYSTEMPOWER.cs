using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMPOWER
    {
        public virtual Decimal ID { get; set; }
        public virtual String SYSTEMNAME { get; set; }
        public virtual Decimal MENUID { get; set; }
        public virtual String HANDLEID { get; set; }
        public virtual Decimal HANDLETYPE { get; set; }
        public virtual Decimal RIGHTID { get; set; }
        public virtual Decimal SIGN { get; set; }
        public virtual String CREATDATE { get; set; }
    }
}

