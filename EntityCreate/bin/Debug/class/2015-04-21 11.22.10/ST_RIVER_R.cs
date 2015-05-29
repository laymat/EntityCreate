using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_RIVER_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal Z { get; set; }
        public virtual Decimal Q { get; set; }
        public virtual Decimal XSA { get; set; }
        public virtual Decimal XSAVV { get; set; }
        public virtual Decimal XSMXV { get; set; }
        public virtual String FLWCHRCD { get; set; }
        public virtual String WPTN { get; set; }
        public virtual String MSQMT { get; set; }
        public virtual String MSAMT { get; set; }
        public virtual String MSVMT { get; set; }
    }
}

