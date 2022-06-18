using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library_Management_System.Models
{
    [MetadataType(typeof(BooksMetaData))]
    public partial class Book
    {
        public class BooksMetaData
        {

            [DisplayName("Book Name")]
            public string bname { get; set; }

            [DisplayName("Category Id")]
            public int c_id { get; set; }

            [DisplayName("Author Id")]
            public int a_id { get; set; }

            [DisplayName("Publisher Id")]
            public int p_id { get; set; }

            [DisplayName("Contents of the book")]
            public string contents { get; set; }

            [DisplayName("Number of Pages")]
            public Nullable<int> pages { get; set; }

            [DisplayName("Book Edition")]
            public Nullable<int> edition { get; set; }

            [DisplayName("Book Author Name")]
            public virtual Author Author { get; set; }

            [DisplayName("Book Category Name")]
            public virtual Category Category { get; set; }

            [DisplayName("Book Publisher Name")]
            public virtual Publisher Publisher { get; set; }

        }
    }
}