//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace testEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menus
    {
        public Menus()
        {
            this.Menus1 = new HashSet<Menus>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CssClassName { get; set; }
        public int Sequence { get; set; }
        public string ParentID { get; set; }
        public string FunctionID { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual Functions Functions { get; set; }
        public virtual ICollection<Menus> Menus1 { get; set; }
        public virtual Menus Menus2 { get; set; }
    }
}
