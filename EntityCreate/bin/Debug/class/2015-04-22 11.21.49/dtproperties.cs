using System;

namespace 
{
    [Serializable]
    public class dtproperties
    {
        public virtual Int32 id { get; set; }
        public virtual Int32 objectid { get; set; }
        public virtual String property { get; set; }
        public virtual String value { get; set; }
        public virtual String uvalue { get; set; }
        public virtual Byte[] lvalue { get; set; }
        public virtual Int32 version { get; set; }
    }
}

