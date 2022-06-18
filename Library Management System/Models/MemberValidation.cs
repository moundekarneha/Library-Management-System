using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library_Management_System.Models
{
    [MetadataType(typeof(MemberMetaData))]
    public partial class Member
    {
        public class MemberMetaData
        {
            [DisplayName("Member Id")]
            public int id { get; set; }

            [DisplayName("Member Name")]
            public string name { get; set; }

            [DisplayName("Member Address")]
            public string address { get; set; }

            [DisplayName("Member Phone")]
            public string phone { get; set; }
        }
    }
}