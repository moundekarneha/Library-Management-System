using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library_Management_System.Models
{
    [MetadataType(typeof(PublisherMetaData))]
    public partial class Publisher
    {
        public class PublisherMetaData
        {
            [DisplayName("Publisher Id")]
            public int id { get; set; }

            [DisplayName("Publisher Name")]
            public string name { get; set; }

            [DisplayName("Publisher Address")]
            public string address { get; set; }

            [DisplayName("Publisher Phone")]
            public string phone { get; set; }

        }
    }
}