using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class ST_CHG
    {
        public virtual String ID { get; set; }
        public virtual Decimal OPTY { get; set; }
        public virtual Decimal STLV { get; set; }
        public virtual String STNM { get; set; }
        public virtual String STCD { get; set; }
        public virtual String STTP { get; set; }
        public virtual Decimal ORGTP { get; set; }
        public virtual String ORGID { get; set; }
        public virtual String BLORG { get; set; }
        public virtual String EARS { get; set; }
        public virtual DateTime EADT { get; set; }
        public virtual Decimal STATE { get; set; }
        public virtual String DWMN { get; set; }
        public virtual String WRMN { get; set; }
        public virtual DateTime WRDT { get; set; }
        public virtual String ADMN { get; set; }
        public virtual DateTime ADDT { get; set; }
        public virtual String APMN { get; set; }
        public virtual DateTime APDT { get; set; }
        public virtual String ADIA { get; set; }
        public virtual String APIA { get; set; }
    }
}

