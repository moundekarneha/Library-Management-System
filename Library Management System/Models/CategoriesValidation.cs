using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library_Management_System.Models
{
    [MetadataType(typeof(CategoriesMetaData))]
    public partial class Category
    {
        public class CategoriesMetaData
        {
            [DisplayName("Category Id")]
            public int id { get; set; }

            [DisplayName("Category Name")]
            public string catname { get; set; }

            [DisplayName("Category Status")]
            public string status { get; set; }

        }
    }
}