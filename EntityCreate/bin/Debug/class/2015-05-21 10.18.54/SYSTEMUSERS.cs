using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMUSERS
    {
        public virtual String ID { get; set; }
        public virtual String USERSORTID { get; set; }
        public virtual String USERNO { get; set; }
        public virtual String USERNAME { get; set; }
        public virtual String PWD { get; set; }
        public virtual Decimal SEX { get; set; }
        public virtual String TEL { get; set; }
        public virtual String PHONENO { get; set; }
        public virtual String E_MAIL { get; set; }
        public virtual String DESCRIPTION { get; set; }
        public virtual Decimal ISENABLE { get; set; }
        public virtual DateTime CREATDATE { get; set; }
    }
}

