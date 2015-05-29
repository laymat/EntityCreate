using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMMENUITEM
    {
        public virtual Decimal NODEID { get; set; }
        public virtual String NODENAME { get; set; }
        public virtual Decimal MENUID { get; set; }
        public virtual Decimal NODETYPE { get; set; }
        public virtual String NODEURL { get; set; }
        public virtual Decimal NODESORT { get; set; }
        public virtual Decimal ISENABLE { get; set; }
        public virtual String NODEDESCRIPTION { get; set; }
    }
}

