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
    
    public partial class WeatherStations
    {
        public WeatherStations()
        {
            this.Projects = new HashSet<Projects>();
        }
    
        public string Id { get; set; }
        public string Region { get; set; }
        public string Prefecture { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Type { get; set; }
        public Nullable<int> High { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
