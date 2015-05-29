using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_RSVRFSR_B
    {
        public virtual String STCD { get; set; }
        public virtual Int32 ACTYR { get; set; }
        public virtual String BGMD { get; set; }
        public virtual String EDMD { get; set; }
        public virtual Double FSLTDZ { get; set; }
        public virtual String FSTP { get; set; }
        public virtual Decimal FSLTDW { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

