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
    
    public partial class TechnicalReports
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Version { get; set; }
        public double GaussianDistribution { get; set; }
        public int Type { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public double Value { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
