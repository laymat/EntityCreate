using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_STCHG
    {
        public virtual String STID { get; set; }
        public virtual Decimal CHGNO { get; set; }
        public virtual String STCD { get; set; }
        public virtual String STNM { get; set; }
        public virtual String RVNM { get; set; }
        public virtual String HNCD { get; set; }
        public virtual String BSCD { get; set; }
        public virtual Decimal DRNA { get; set; }
        public virtual Decimal ESSTYR { get; set; }
        public virtual Decimal ESSTMTH { get; set; }
        public virtual Decimal CHGYR { get; set; }
        public virtual Decimal CHGMTH { get; set; }
        public virtual String AUTHORG { get; set; }
        public virtual String CHGCIR { get; set; }
        public virtual String CHGREA { get; set; }
        public virtual String ADMTP { get; set; }
        public virtual String STPROP { get; set; }
        public virtual String STLC { get; set; }
        public virtual String ADDVCD { get; set; }
        public virtual Decimal LGTD { get; set; }
        public virtual Decimal LTTD { get; set; }
        public virtual String ADMORGHYD { get; set; }
        public virtual String ADMORGOTH { get; set; }
        public virtual String NT { get; set; }
    }
}

