using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_LINE_LIST
    {
        public virtual Decimal SN_LINE_ID { get; set; }
        public virtual String SN_LINE_NAME { get; set; }
        public virtual String SN_LINE_DESCRIPTION { get; set; }
        public virtual String SN_LINE_VALUE { get; set; }
        public virtual DateTime SN_LINE_UPLOAD_TIME { get; set; }
        public virtual String SN_LINE_UPLOAD_USER { get; set; }
        public virtual String SN_LINE_FILE_NAME { get; set; }
        public virtual String SN_LINE_STYLE { get; set; }
    }
}

