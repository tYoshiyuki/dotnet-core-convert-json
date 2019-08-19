using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DotNetCoreConvertJson.Models
{
    [DataContract]
    public class SampleModel
    {
        [DataMember(Name = "intValue")]
        public int IntValue { get; set; }

        [DataMember(Name = "stringValue")]
        public string StringValue { get; set; }

        [DataMember(Name = "dateTimeValue")]
        public DateTime DateTimeValue { get; set; }

        [DataMember(Name = "listValue")]
        public List<string> ListtValue { get; set; }

        [DataMember(Name = "mapValue")]
        public Dictionary<string, string> MapValue { get; set; }

        [DataMember(Name = "subSampleModel")]
        public SubSampleModel SubSampleModel { get; set; }
    }

    public class SubSampleModel
    {
        [DataMember(Name = "intValue")]
        public int IntValue { get; set; }

        [DataMember(Name = "stringValue")]
        public string StringValue { get; set; }
    }
}
