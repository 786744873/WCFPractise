using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServerByLiberary
{
    [DataContract]
    [Serializable]
    public class User
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
