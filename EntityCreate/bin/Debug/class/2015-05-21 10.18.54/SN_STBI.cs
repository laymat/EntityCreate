using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_STBI
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual String STNM { get; set; }
        public virtual String RVNM { get; set; }
        public virtual String HNCD { get; set; }
        public virtual String BSCD { get; set; }
        public virtual Decimal DRNA { get; set; }
        public virtual Decimal ESSTYR { get; set; }
        public virtual Decimal ESSTMTH { get; set; }
        public virtual String STTP { get; set; }
        public virtual String ADMTP { get; set; }
        public virtual String STPROP { get; set; }
        public virtual String STSCTP { get; set; }
        public virtual String FIREP { get; set; }
        public virtual String PROVCD { get; set; }
        public virtual String CITYCD { get; set; }
        public virtual String COUTCD { get; set; }
        public virtual String STLC { get; set; }
        public virtual String ADDVCD { get; set; }
        public virtual Decimal LGTD { get; set; }
        public virtual Decimal LTTD { get; set; }
        public virtual Decimal STEL { get; set; }
        public virtual String DTMNM { get; set; }
        public virtual Decimal DTMMDPR { get; set; }
        public virtual String REGBOD { get; set; }
        public virtual String COUNORG { get; set; }
        public virtual String ADMORGHYD { get; set; }
        public virtual String ADMORGOTH { get; set; }
        public virtual String ADMST { get; set; }
        public virtual String SURPT { get; set; }
        public virtual String MEAITEM { get; set; }
        public virtual String BLORG { get; set; }
        public virtual String RPORG { get; set; }
        public virtual String NT { get; set; }
        public virtual Decimal STATE { get; set; }
        public virtual String WRITEMAN { get; set; }
        public virtual DateTime WRITEDATE { get; set; }
        public virtual String AUDITEMAN { get; set; }
        public virtual DateTime AUDITEDATE { get; set; }
        public virtual String SUBMITUNIT { get; set; }
        public virtual String TELEPHONE { get; set; }
        public virtual String PRNM { get; set; }
        public virtual String MEACHINESE { get; set; }
        public virtual Decimal ANGLE { get; set; }
    }
}

