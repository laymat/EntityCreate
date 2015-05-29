using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TABLE_E
    {
        public virtual String INSTCD { get; set; }
        public virtual String TABID { get; set; }
        public virtual String ISSTARTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

