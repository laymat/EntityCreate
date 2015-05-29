using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RVFCCH_B
    {
        public virtual String STCD { get; set; }
        public virtual Decimal LDKEL { get; set; }
        public virtual Decimal RDKEL { get; set; }
        public virtual Decimal WRZ { get; set; }
        public virtual Decimal WRQ { get; set; }
        public virtual Double GRZ { get; set; }
        public virtual Decimal GRQ { get; set; }
        public virtual Decimal FLPQ { get; set; }
        public virtual Decimal OBHTZ { get; set; }
        public virtual DateTime OBHTZTM { get; set; }
        public virtual Decimal IVHZ { get; set; }
        public virtual DateTime IVHZTM { get; set; }
        public virtual Decimal OBMXQ { get; set; }
        public virtual DateTime OBMXQTM { get; set; }
        public virtual Decimal IVMXQ { get; set; }
        public virtual DateTime IVMXQTM { get; set; }
        public virtual Decimal HMXS { get; set; }
        public virtual DateTime HMXSTM { get; set; }
        public virtual Decimal HMXAVV { get; set; }
        public virtual DateTime HMXAVVTM { get; set; }
        public virtual Decimal HLZ { get; set; }
        public virtual DateTime HLZTM { get; set; }
        public virtual Decimal HMNQ { get; set; }
        public virtual DateTime HMNQTM { get; set; }
        public virtual Decimal TAZ { get; set; }
        public virtual Decimal TAQ { get; set; }
        public virtual Decimal LAZ { get; set; }
        public virtual Decimal LAQ { get; set; }
        public virtual Decimal SFZ { get; set; }
        public virtual Decimal SFQ { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

