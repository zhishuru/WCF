using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2
{
    [DataContract]
    public class Number1 
    {

        public Number1(int num)是多少啊都是
        {
            Num = num;
        }
        [DataMember]
        public int Num { get; set; }
    }
}