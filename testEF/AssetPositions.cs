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
    
    public partial class AssetPositions
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public int ProjectId { get; set; }
        public double Position { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public byte[] Timestamp { get; set; }
        public System.DateTime ReceiveDate { get; set; }
        public decimal Price { get; set; }
    
        public virtual Funds Funds { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
