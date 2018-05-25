using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceDemoDataMessage
{
    [DataContract]
    public class Person
    {
        [DataMember(Name="IDD")]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}