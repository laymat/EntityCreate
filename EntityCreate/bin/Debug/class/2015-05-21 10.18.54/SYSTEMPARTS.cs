using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMPARTS
    {
        public virtual String PARTID { get; set; }
        public virtual String PARTNAME { get; set; }
        public virtual String PARTDESCRIPTION { get; set; }
        public virtual Decimal PARTSORT { get; set; }
        public virtual DateTime CREATDATE { get; set; }
        public virtual Decimal ORGTP { get; set; }
        public virtual String ORGID { get; set; }
    }
}

