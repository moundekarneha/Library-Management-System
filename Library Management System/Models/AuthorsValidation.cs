using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library_Management_System.Models
{
    [MetadataType(typeof(AuthorsMetaData))]
    public partial class Author
    {
        public class AuthorsMetaData
        {
            [DisplayName("Author Id")]
            public int id { get; set; }

            [DisplayName("Author Name")]
            public string name { get; set; }

            [DisplayName("Author Address")]
            public string address { get; set; }

            [DisplayName("Author Phone Number")]
            public string phone { get; set; }


        }
    }
}