using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SYSTEMMENU
    {
        public virtual Decimal MENUID { get; set; }
        public virtual String MENUNAME { get; set; }
        public virtual String SYSTEMNAME { get; set; }
        public virtual String SUPERMENUID { get; set; }
        public virtual Decimal MENUSORT { get; set; }
        public virtual String DATABASETABLE { get; set; }
        public virtual String MENUURL { get; set; }
        public virtual Decimal ISMASK { get; set; }
        public virtual Decimal MENUTYPE { get; set; }
        public virtual String ICON { get; set; }
    }
}

