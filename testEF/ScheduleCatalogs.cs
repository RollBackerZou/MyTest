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
    
    public partial class ScheduleCatalogs
    {
        public ScheduleCatalogs()
        {
            this.ScheduleCatalogs1 = new HashSet<ScheduleCatalogs>();
            this.Schedules = new HashSet<Schedules>();
        }
    
        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int Sequence { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual ICollection<ScheduleCatalogs> ScheduleCatalogs1 { get; set; }
        public virtual ScheduleCatalogs ScheduleCatalogs2 { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }
    }
}